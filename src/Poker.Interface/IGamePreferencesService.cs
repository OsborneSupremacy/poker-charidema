namespace Poker.Service.Interface;
public interface IGamePreferencesService
{
    Task<double> GetAnte(IPlayer button);

    Task<IVariant> GetVariant(IPlayer button);

    Task<IDeck> GetDeck(IPlayer button);
}
