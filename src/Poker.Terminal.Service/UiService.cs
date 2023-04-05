using Poker.Service.Interface;
using Poker.Library;
using Poker.Library.Interface;
using Poker.Service;
using Bogus;
using Poker.Library.Variants;

namespace Poker.Terminal.Service;

public class UiService : IGamePreferencesService, IMatchPreferencesService
{
    private readonly PlayerFactory _playerFactory;

    private readonly IRandomFactory _randomFactory;

    public UiService(PlayerFactory playerFactory, IRandomFactory randomFactory)
    {
        _playerFactory = playerFactory ?? throw new ArgumentNullException(nameof(playerFactory));
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public Task<double> GetAnte(IPlayer button)
    {
        throw new NotImplementedException();
    }

    public Task<IDeck> GetDeck(IPlayer button)
    {
        throw new NotImplementedException();
    }

    public async Task<MatchArgs> GetMatchArgs()
    {
        Console.WriteLine("Welcome to OsborneSupremacy/poker-charidema!");
        Console.WriteLine(new string('*', 100));
        Console.WriteLine();

        var userName = PromptForString("What should we call you?", 1);
        Console.WriteLine();

        Console.WriteLine($"Nice to meet you, {userName}!");
        Console.WriteLine();

        var playerCount = PromptForInt("How many other players would you like to be part of this match?", 1, 10);
        Console.WriteLine();

        var startingStack = PromptForMoney("How much money should players start with?", 10, 1000000);
        Console.WriteLine();

        List<IPlayer> players = new();

        var user = new Player
        {
            Id = Guid.NewGuid(),
            Name = userName,
            Stack = startingStack,
            BeginningStack = startingStack,
            Automaton = false
        };

        players.Add(user);

        for (int p = 0; p < playerCount; p++)
            players.Add(
                await _playerFactory
                    .CreateAsync(
                        new PlayerCreateArgs
                        {
                            BeginningStack = startingStack,
                            Id = Guid.NewGuid(),
                            Automaton = true
                        }
                    )
            );

        Console.WriteLine($"The other players are:");
        foreach (var player in players.Where(x => x.Id != user.Id))
            Console.WriteLine($"* {player.Name}");

        Console.WriteLine();

        var fixedNumberOfGames = PromptForOption<uint?>
            (
                "Do you want to play indefinitely, or a fixed number of games?",
                new("Play indefinitely",
                    () => { return null; }
                ),
                new("Play fixed number of rounds",
                    () => { return (uint)PromptForInt("How many games?", 1, 100); }
                )
            )
            .GetValue();

        Console.WriteLine();

        var fixedAnte = PromptForOption<uint?>
            (
                "Should the ante amount be dealer's choice, or fixed?",
                new("Dealer's choice ante amount",
                    () => { return null; }
                ),
                new("Fixed ante amount",
                    () => { return (uint)PromptForMoney("Specify fixed ante amount", 1, startingStack); }
                )
            ).GetValue();


        Console.WriteLine();

        Console.ReadKey();

        return new MatchArgs {

            Players = players,

            InitialButton = new Faker() {
                Random = new Randomizer(_randomFactory.GetSeed())
            }.PickRandom(players),

            FixedNumberOfGames = fixedNumberOfGames,
            FixedAnte = fixedAnte,
            FixedDeck = new Library.Classic.Deck(),
            FixedVariant = new FiveCardDraw()
        };
    }

    public Task<bool> GetPlayAgain()
    {
        throw new NotImplementedException();
    }

    public Task<IVariant> GetVariant(IPlayer button)
    {
        throw new NotImplementedException();
    }

    private string PromptForString(string prompt, uint minLength)
    {
        var result = string.Empty;
        while ((result?.Length ?? 0) < minLength)
        {
            Console.Write($"{prompt}: ");
            result = Console.ReadLine()?.Trim() ?? string.Empty;
        }
        return result!;
    }

    private int PromptForInt(string prompt, int minVal, int maxVal)
    {
        var result = minVal - 1;
        while(result < minVal || result > maxVal)
        {
            Console.Write($"{prompt} {minVal}-{maxVal}: ");
            _ = int.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }

    private int PromptForMoney(string prompt, int minVal, int maxVal)
    {
        var result = minVal - 1;
        while (result < minVal || result > maxVal)
        {
            Console.Write($"{prompt} {minVal:C} - {maxVal:C}: ");
            _ = int.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }

    private InputOption<T> PromptForOption<T>(string prompt, params InputOption<T>[] options)
    {
        InputOption<T>? selectedOption = null;

        while (selectedOption is null)
        {
            Console.WriteLine($"{prompt}");

            uint i = 0;
            foreach (var option in options)
                Console.WriteLine($"[{++i}] {option.Name}");

            if(uint.TryParse(Console.ReadKey().KeyChar.ToString(), out var optionId))
                selectedOption = options[optionId - 1];

            Console.WriteLine();
        }

        return selectedOption;
    }

    protected class InputOption<T>
    {
        public string Name { get; set; }

        public Func<T> GetValue { get; set; }

        public InputOption(string name, Func<T> getValue)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            GetValue = getValue ?? throw new ArgumentNullException(nameof(getValue));
        }
    }
}
