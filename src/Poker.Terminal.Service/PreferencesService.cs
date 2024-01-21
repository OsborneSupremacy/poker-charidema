using Poker.Domain.Classic;
using Poker.Domain.Implementations.Variants;
using Poker.Domain.Messaging;

namespace Poker.Terminal.Service;

public class PreferencesService : IGamePreferencesService, IMatchPreferencesService
{
    private readonly PlayerFactory _playerFactory;

    private readonly IRandomService _randomService;

    private readonly IUserInterfaceService _c;

    public PreferencesService(
        PlayerFactory playerFactory,
        IRandomService randomService,
        IUserInterfaceService console
        )
    {
        _playerFactory = playerFactory ?? throw new ArgumentNullException(nameof(playerFactory));
        _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
        _c = console ?? throw new ArgumentNullException(nameof(console));
    }

    public Task<int> GetAnte(Player button)
    {
        throw new NotImplementedException();
    }

    public Task<Deck> GetDeck(Player button)
    {
        throw new NotImplementedException();
    }

    public async Task<MatchRequest> CreateMatchRequest(MatchResponse? lastMatch)
    {
        var userName = string.Empty;
        int playerCount = 0;
        int startingStack = 0;
        int fixedNumberOfGames = 0;

        _c.WriteHeading(HeadingLevel.One, "Welcome to poker-charidema!")

        .PromptForString(
            "Please enter your name", 1, Environment.UserName.ToTitleCase(), name =>
            {
                userName = name;
                _c.WriteLine($"Welcome, {userName}!");
            })

        .WriteLine()

        .PromptForInt("How many other players would you like to be part of this match?", 1, 9, 2, c =>
        {
            playerCount = c;
        })

        .WriteLine()

        .PromptForMoney("How much money should players start with?", 10, 1000000, 1000, m =>
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
            new InputOption<int>(
                "Play indefinitely", () => 0
            ),
            new InputOption<int>(
                "Play fixed number of games", () =>
                {
                    int gameCount = 0;
                    _c.PromptForInt("How many games?", 1, 100, 10, input =>
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
                Games = []
            },

            InitialButton = _randomService.PickFromList(players)
        };
    }

    private AntePreferences GetAntePreferences(int startingStack)
    {
        AntePreferences antePreferences = new()
        {
            AnteType = AnteTypes.Empty,
            Fixed = 0,
            Min = 0,
            Max = 0
        };

        _c.PromptForOption(
            "Should the ante amount be dealer's choice, or fixed?",
            pref =>
            {
                antePreferences = pref;
            },
            new InputOption<AntePreferences>(
                "Dealer's choice ante amount", () => {

                    int min = 0;

                    // subtracting 1 because we can't make the minimum ante equal to the 
                    // starting stack -- otherwise it will be impossible for there to be a 
                    // range. And if there's not a range, dealer's choice doesn't make sense.
                    _c.PromptForMoney("Minimum ante", 0, startingStack - 1, 1, input =>
                    {
                        min = input;
                    });

                    int max = 0;
                    _c.PromptForMoney("Maximum ante", min + 1, startingStack, startingStack, input =>
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
                int anteAmount = 0;
                _c.PromptForMoney("Specify fixed ante amount", 1, startingStack, 25, input =>
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

        return antePreferences;
    }

    private async IAsyncEnumerable<Player> GeneratePlayers(
        string userName,
        int startingStack,
        int playerCount
        )
    {
        yield return new Player
        {
            Id = Guid.NewGuid(),
            Name = userName,
            Stack = startingStack,
            BeginningStack = startingStack,
            Automaton = false,
            Busted = false,
            Cards = [],
            Stake = 0,
            Folded = false
        };

        for (int p = 0; p < playerCount; p++)
            yield return await _playerFactory
                .CreateAsync(
                    new PlayerCreateRequest
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

    public Task<Variant> GetVariant(Player button)
    {
        throw new NotImplementedException();
    }
    
    public Task<bool> ConfirmStartAsync() =>
        Task.FromResult(_c.PromptForBool("Ready to Begin?"));

    public Task<bool> GetPlayAgain(Game game) =>
        Task.FromResult(_c.PromptForBool($"Would you like to play another game of {game.Variant.Name}?"));
}
