
namespace Poker.Interface;

public interface IGamePreferencesService
{
    Task<double> GetAnte(Player button);

    Task<IVariant> GetVariant(Player button);

    Task<Deck> GetDeck(Player button);
}
