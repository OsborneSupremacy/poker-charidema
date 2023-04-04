using Poker.Service.Interface;
using Poker.Library;
using Poker.Library.Interface;
using Poker.Service;

namespace Poker.Terminal.Service;

public class UiService : IGamePreferencesService, IMatchPreferencesService
{
    private readonly PlayerFactory _playerFactory;

    public UiService(PlayerFactory playerFactory)
    {
        _playerFactory = playerFactory ?? throw new ArgumentNullException(nameof(playerFactory));
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

        Console.ReadKey();

        return new MatchArgs { 
            InitialButton = user,
            FixedNumberOfGames = null,
            FixedDeck = new Library.Classic.Deck(),
            FixedVariant = null
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

    private uint PromptForInt(string prompt, uint minVal, uint maxVal)
    {
        var result = minVal - 1;
        while(result < minVal || result > maxVal)
        {
            Console.Write($"{prompt} {minVal}-{maxVal}: ");
            _ = uint.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }

    private uint PromptForMoney(string prompt, uint minVal, uint maxVal)
    {
        var result = minVal - 1;
        while (result < minVal || result > maxVal)
        {
            Console.Write($"{prompt} {minVal:C} - {maxVal:C}: ");
            _ = uint.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }
}
