using Bogus;
using Poker.Domain;
using Poker.Domain.Classic;
using Poker.Domain.Messaging;
using Poker.Presentation.Interface;

namespace Poker.Terminal.Service;

public class PreferencesService : IGamePreferencesService, IMatchPreferencesService
{
    private readonly PlayerFactory _playerFactory;

    private readonly IRandomFactory _randomFactory;

    private readonly IUserInterfaceService _c;

    public PreferencesService(
        PlayerFactory playerFactory,
        IRandomFactory randomFactory,
        IUserInterfaceService console
        )
    {
        _playerFactory = playerFactory ?? throw new ArgumentNullException(nameof(playerFactory));
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _c = console ?? throw new ArgumentNullException(nameof(console));
    }

    public Task<uint> GetAnte(Participant button)
    {
        throw new NotImplementedException();
    }

    public Task<Deck> GetDeck(Participant button)
    {
        throw new NotImplementedException();
    }

    public async Task<MatchRequest> CreateMatchRequest(MatchResponse? lastMatch)
    {
        var userName = string.Empty;
        uint playerCount = 0;
        uint startingStack = 0;
        uint? fixedNumberOfGames = null;

        _c.WriteHeading(HeadingLevel.One, "Welcome to OsborneSupremacy/poker-charidema!")

        .PromptForString(
            "Please enter your name", 1, (string name) =>
            {
                userName = name;
                _c.WriteLine($"Welcome, {userName}!");
            })

        .WriteLine()

        .PromptForInt("How many other players would you like to be part of this match?", 1, 9, (uint c) =>
        {
            playerCount = c;
        })

        .WriteLine()

        .PromptForMoney("How much money should players start with?", 10, 1000000, (uint m) =>
        {
            startingStack = m;
        })

        .WriteLine()

        .PromptForOption(
            "Do you want to play indefinitely, or a fixed number of games?",
            gameCount =>
            {
                fixedNumberOfGames = gameCount;
            },
            new InputOption<uint?>(
                "Play indefinitely", () => { return null; }
            ),
            new InputOption<uint?>(
                "Play fixed number of games", () =>
                {
                    uint gameCount = 0;
                    _c.PromptForInt("How many games?", 1, 100, input =>
                    {
                        gameCount = input;
                    });
                    return gameCount;
                }
            )
        )

        .WriteLine();

        var antePreferences = GetAntePreferences(startingStack);

        var players = await GeneratePlayers(userName, startingStack, playerCount)
            .ToListAsync();

        return new MatchRequest
        {
            Match = new Match
            {
                Players = players,
                FixedNumberOfGames = fixedNumberOfGames,
                AntePreferences = antePreferences,
                FixedDeck = new Deck {
                    Cards = Cards.All,
                    NumberOfJokers = 0
                },
                FixedVariant = FiveCardDraw.GetVariant(),
                StartingStack = startingStack,
                Games = new()
            },

            InitialButton = new Faker()
            {
                Random = new Randomizer(_randomFactory.GetSeed())
            }.PickRandom(players),
        };
    }

    private AntePreferences GetAntePreferences(uint startingStack)
    {
        AntePreferences? antePreferences = null;

        _c.PromptForOption(
            "Should the ante amount be dealer's choice, or fixed?",
            pref =>
            {
                antePreferences = pref;
            },
            new InputOption<AntePreferences>(
                "Dealer's choice ante amount", () => {

                    uint min = 0;

                    // subtracting 1 because we can't make the minimum ante equal to the 
                    // starting stack -- otherwise it will be impossible for there to be a 
                    // range. And if there's not a range, dealer's choice doesn't make sense.
                    _c.PromptForMoney("Mininum ante", 0, startingStack - 1, input =>
                    {
                        min = input;
                    });

                    uint max = 0;
                    _c.PromptForMoney("Maximum ante", min + 1, startingStack, input =>
                    {
                        max = input;
                    });

                    return new AntePreferences
                    {
                        Min = min,
                        Max = max,
                        Fixed = 0,
                        AnteType = AnteTypes.DealersChoice
                    };
                }
            ),
            new InputOption<AntePreferences>("Fixed ante amount", () =>
            {
                uint anteAmount = 0;
                _c.PromptForMoney("Specify fixed ante amount", 1, startingStack, input =>
                {
                    anteAmount = input;
                });
                return new AntePreferences {
                    Fixed = anteAmount,
                    Min = 0,
                    Max = 0,
                    AnteType = AnteTypes.Fixed
                };
            })
        );

        return antePreferences!;
    }

    protected async IAsyncEnumerable<Participant> GeneratePlayers(
        string userName,
        uint startingStack,
        uint playerCount
        )
    {
        yield return new Participant
        {
            Id = Guid.NewGuid(),
            Name = userName,
            Stack = startingStack,
            BeginningStack = startingStack,
            Automaton = false,
            Busted = false
        };

        for (int p = 0; p < playerCount; p++)
            yield return await _playerFactory
                .CreateAsync(
                    new PlayerCreateArgs
                    {
                        BeginningStack = startingStack,
                        Id = Guid.NewGuid(),
                        Automaton = true
                    });
    }

    public Task<bool> GetPlayAgain(Match? lastMatch) =>
        Task.FromResult(_c.PromptForBool("Would you like to play another match?"));

    public Task<bool> GetPlayAgain(GameResponse lastGame) =>
        Task.FromResult(_c.PromptForBool($"Would you like to play another game of {lastGame.Variant.Name}?"));

    public Task<Variant> GetVariant(Participant button)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ConfirmStartAsync() =>
        Task.FromResult(_c.PromptForBool("Ready to Begin?"));

    public IUserInterfaceService PromptForOption<T>(string prompt, Action<T> onValidInput, params IInputOption<T>[] options) =>
        PromptForOption(prompt, onValidInput, options);

    public IInputOption<T> PromptForOption<T>(string prompt, params IInputOption<T>[] options) =>
        PromptForOption(prompt, options);

    public Task<bool> GetPlayAgain(Game game) =>
        Task.FromResult(_c.PromptForBool($"Would you like to play another game of {game.Variant.Name}?"));
}
