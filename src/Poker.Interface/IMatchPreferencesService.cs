namespace Poker.Interface;

public interface IMatchPreferencesService
{
    Task<Player> GetInitialButton(List<Player> players);

    Task<bool> GetKeepPlaying();

    Task<Deck?> GetFixedDeck(Player button);

    Task<IVariant?> GetFixedVariant(Player button);
}
