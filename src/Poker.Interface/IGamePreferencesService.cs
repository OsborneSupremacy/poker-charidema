namespace Poker.Service.Interface;

public interface IGamePreferencesService
{
    Task<uint> GetAnte(Participant button);

    Task<IVariant> GetVariant(Participant button);

    Task<IDeck> GetDeck(Participant button);

    Task<bool> GetPlayAgain(Game game);
}
