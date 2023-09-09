namespace Poker.Service.Interface;

public interface IGamePreferencesService
{
    Task<uint> GetAnte(IPlayer button);

    Task<IVariant> GetVariant(IPlayer button);

    Task<IDeck> GetDeck(IPlayer button);

    Task<bool> GetPlayAgain(Game game);
}
