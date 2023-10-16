namespace Poker.Service.Interface;

public interface IGamePreferencesService
{
    Task<int> GetAnte(Participant button);

    Task<Variant> GetVariant(Participant button);

    Task<Deck> GetDeck(Participant button);

    Task<bool> GetPlayAgain(GameResponse game);
}
