namespace Poker.Service.Interface;

public interface IGamePreferencesService
{
    Task<uint> GetAnte(Player button);

    Task<IVariant> GetVariant(Player button);

    Task<IDeck> GetDeck(Player button);

    Task<bool> GetPlayAgain(Game game);
}
