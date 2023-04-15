using Bogus;

namespace Poker.Terminal.Service;

public class UiService : IGamePreferencesService, IMatchPreferencesService
{
    private readonly PlayerFactory _playerFactory;

    private readonly IRandomFactory _randomFactory;

    private readonly FluentConsoleService _c;

    public UiService(
        PlayerFactory playerFactory,
        IRandomFactory randomFactory,
        FluentConsoleService console
        )
    {
        _playerFactory = playerFactory ?? throw new ArgumentNullException(nameof(playerFactory));
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _c = console ?? throw new ArgumentNullException(nameof(console));
    }

    public Task<double> GetAnte(IPlayer button)
    {
        throw new NotImplementedException();
    }

    public Task<IDeck> GetDeck(IPlayer button)
    {
        throw new NotImplementedException();
    }

    public async Task<MatchArgs> GetMatchArgs(Match? lastMatch)
    {
        var userName = string.Empty;
        int playerCount = 0;
        int startingStack = 0;
        uint? fixedNumberOfGames = null;
        uint? fixedAnte = null;

        _c.WriteLines(
            "Welcome to OsborneSupremacy/poker-charidema!",
            new string('*', 100),
            string.Empty
        )

        .PromptForString(
            "What should we call you?", 1, (string name) =>
            {
                userName = name;
                _c.WriteLine($"Nice to meet you, {userName}!");
            })

        .WriteLine()

        .PromptForInt("How many other players would you like to be part of this match?", 1, 10, (int c) =>
        {
            playerCount = c;
        })

        .WriteLine()

        .PromptForMoney("How much money should players start with?", 10, 1000000, (int m) =>
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
                    int gameCount = 0;
                    _c.PromptForInt("How many games?", 1, 100, input =>
                    {
                        gameCount = input;
                    });
                    return (uint)gameCount;
                }
            )
        )

        .WriteLine()

        .PromptForOption(
            "Should the ante amount be dealer's choice, or fixed?",
            anteAmount =>
            {
                fixedAnte = anteAmount;
            },
            new InputOption<uint?>(
                "Dealer's choice ante amount", () => { return null; }
            ),
            new InputOption<uint?>("Fixed ante amount", () =>
            {
                int anteAmount = 0;
                _c.PromptForMoney("Specify fixed ante amount", 1, startingStack, input =>
                {
                    anteAmount = input;
                });
                return (uint)anteAmount;
            })
        );

        var players = await GeneratePlayers(userName, startingStack, playerCount)
            .ToListAsync();

        return new MatchArgs
        {

            Players = players,

            InitialButton = new Faker()
            {
                Random = new Randomizer(_randomFactory.GetSeed())
            }.PickRandom(players),

            FixedNumberOfGames = fixedNumberOfGames,
            FixedAnte = fixedAnte,
            FixedDeck = new Library.Classic.Deck(),
            FixedVariant = new FiveCardDraw()
        };
    }

    protected async IAsyncEnumerable<IPlayer> GeneratePlayers(string userName, double startingStack, int playerCount)
    {
        yield return new Player
        {
            Id = Guid.NewGuid(),
            Name = userName,
            Stack = startingStack,
            BeginningStack = startingStack,
            Automaton = false
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

    public Task<bool> GetPlayAgain() =>
        Task.FromResult(_c.PromptForBool("Play Again?"));

    public Task<IVariant> GetVariant(IPlayer button)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ConfirmStartAsync() =>
        Task.FromResult(_c.PromptForBool("Ready to Begin?"));

    public IMatchPreferencesService Write(string input)
    {
        _c.Write(input);
        return this;
    }

    public IMatchPreferencesService WriteLine(string input)
    {
        _c.WriteLine(input);
        return this;
    }

    public IMatchPreferencesService WriteLine()
    {
        _c.WriteLine();
        return this;
    }

    public IMatchPreferencesService WriteLines(params string[] lines)
    {
        _c.WriteLines(lines);
        return this;
    }
}
