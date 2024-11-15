﻿using Microsoft.Extensions.Hosting;
using Poker.Domain.Messaging;
using Poker.Service.Abstractions;

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

        AnsiConsole.Clear();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        // ReSharper disable once AsyncVoidLambda
        _applicationLifetime.ApplicationStarted.Register(async () =>
        {
            MatchResponse matchResponse = MatchResponses.Empty with
            {
                PlayAgain = true
            };

            while (matchResponse.PlayAgain)
            {
                AnsiConsole.Clear();

                var matchRequest = await _matchPreferencesService
                    .CreateMatchRequest(matchResponse);

                matchResponse = await _matchService.PlayAsync(matchRequest);
            }
            _applicationLifetime.StopApplication();
        });
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
