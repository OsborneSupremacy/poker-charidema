﻿namespace Poker.Service;

public class ConsolePreferencesService : IMatchPreferencesService, IGamePreferencesService
{
    public Task<double> GetAnte(Player button) => throw new NotImplementedException();

    public Task<Deck> GetDeck(Player button) => throw new NotImplementedException();

    public Task<Deck?> GetFixedDeck(Player button) => throw new NotImplementedException();

    public Task<IVariant?> GetFixedVariant(Player button) => throw new NotImplementedException();

    public Task<Player> GetInitialButton(List<Player> players) => throw new NotImplementedException();

    public Task<bool> GetKeepPlaying() => throw new NotImplementedException();

    public Task<IVariant> GetVariant(Player button) => throw new NotImplementedException();
}
