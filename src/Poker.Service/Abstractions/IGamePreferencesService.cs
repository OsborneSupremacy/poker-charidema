namespace Poker.Service.Abstractions;

public interface IGamePreferencesService
{
    Task<int> GetAnte(Player button);

    Task<Variant> GetVariant(Player button);

    Task<Deck> GetDeck(Player button);

    Task<bool> GetPlayAgain(CompletedGame game);

    Task<bool> GetPlayAgain(string lastVariantName);
}
