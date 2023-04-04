using Poker.Interface;
using Poker.Library;
using Poker.Library.Interface;

namespace Poker.Terminal.Service;

public class UiService : IGamePreferencesService, IMatchPreferencesService
{
    public UiService()
    {
        Console.BackgroundColor = ConsoleColor.DarkGreen;
    }

    public Task<double> GetAnte(Player button)
    {
        throw new NotImplementedException();
    }

    public Task<IDeck> GetDeck(Player button)
    {
        throw new NotImplementedException();
    }

    public Task<MatchArgs> GetMatchArgs()
    {
        Console.WriteLine("Welcome to OsborneSupremacy/poker-charidema!");
        Console.ReadKey();
        return Task.FromResult(new MatchArgs { 
            InitialButton = new Player {
                Id = Guid.NewGuid(),
                Name = "Ben",
                BeginningStack = 100,
                Stack = 100
            },
            FixedNumberOfGames = null,
            FixedDeck = new Library.Classic.Deck(),
            FixedVariant = null
        });
    }

    public Task<bool> GetPlayAgain()
    {
        throw new NotImplementedException();
    }

    public Task<IVariant> GetVariant(Player button)
    {
        throw new NotImplementedException();
    }
}
