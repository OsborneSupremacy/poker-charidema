namespace Poker.Service.Interface;

public interface IGamePreferencesService
{
    Task<int> GetAnte(Player button);

    Task<Variant> GetVariant(Player button);

    Task<Deck> GetDeck(Player button);

    Task<bool> GetPlayAgain(GameResponse game);
}
