﻿using Microsoft.Extensions.Hosting;
using Poker.Library;
using Spectre.Console;

namespace Poker.Terminal;

public class ConsoleHostedService : IHostedService
{
    private readonly IMatchService _matchService;

    private readonly IMatchPreferencesService _matchPreferencesService;

    private readonly IHostApplicationLifetime _applicationLifetime;

    public ConsoleHostedService(
        IMatchService matchService,
        IMatchPreferencesService matchPreferencesService,
        IHostApplicationLifetime applicationLifetime
        )
    {
        _matchService = matchService ?? throw new ArgumentNullException(nameof(matchService));
        _matchPreferencesService = matchPreferencesService ?? throw new ArgumentNullException(nameof(matchPreferencesService));
        _applicationLifetime = applicationLifetime ?? throw new ArgumentNullException(nameof(applicationLifetime));

        AnsiConsole.Background = Color.DarkGreen;
        AnsiConsole.Clear();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _applicationLifetime.ApplicationStarted.Register(async () =>
        {
            MatchResult? matchResult = null;
            while (true)
            {
                AnsiConsole.Clear();

                var matchArgs = await _matchPreferencesService
                    .GetMatchArgs(matchResult?.Match);

                matchResult = await _matchService.PlayAsync(matchArgs);

                if (!matchResult.PlayAgain)
                    break;
            };
            _applicationLifetime.StopApplication();
        });
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
