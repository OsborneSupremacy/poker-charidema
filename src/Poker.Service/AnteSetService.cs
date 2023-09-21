﻿using Bogus;

namespace Poker.Service;

public class AnteSetService : IAnteSetService
{
    private readonly IRandomFactory _randomFactory;

    private readonly IUserInterfaceService _userInterfaceService;

    public AnteSetService(
        IRandomFactory randomFactory,
        IUserInterfaceService userInterfaceService
        )
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
    }

    public Task<uint> GetAsync(GameRequest request, Player button)
    {
        if (request.Match.AntePreferences.Fixed.HasValue)
            return Task.FromResult(request.Match.AntePreferences.Fixed.Value);

        var antePrefs = GetAntePrefs(request);

        uint anteAmount = button.Participant.Automaton switch
        {
            true => new Randomizer(_randomFactory.GetSeed())
                .UInt(antePrefs.Min.ValueOrZero(), antePrefs.Max.ValueOrMax()),
            false => GetAnteFromUser(antePrefs)
        };

        return Task.FromResult(anteAmount);
    }

    private AntePreferences GetAntePrefs(GameRequest request)
    {
        var minPlayerStack = request.Players.Min(p => p.Stack);

        var antePrefs = request.Match.AntePreferences;

        // all players have enough for max ante
        if (minPlayerStack >= antePrefs.Max)
            return antePrefs;

        var effectivePrefs = antePrefs with
        {
            Min = (minPlayerStack < antePrefs.Min) ? minPlayerStack : antePrefs.Min,
            Max = minPlayerStack
        };

        return effectivePrefs;
    }

    private uint GetAnteFromUser(AntePreferences antePrefs)
    {
        uint anteAmount = 0;
        _userInterfaceService
            .PromptForMoney(
                "Specify ante amount",
                antePrefs.Min.ValueOrZero(),
                antePrefs.Min.ValueOrMax(),
                input =>
                {
                    anteAmount = input;
                });
        return anteAmount;
    }
}
