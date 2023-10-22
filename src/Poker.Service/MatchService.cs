﻿using Poker.Domain.Implementations.Variants;

namespace Poker.Service;

public class MatchService : IMatchService
{
    private readonly IMatchPreferencesService _matchPreferencesService;

    private readonly IGamePreferencesService _gamePreferencesService;

    private readonly IUserInterfaceService _userInterfaceService;
    
    private readonly IGameCoordinationService _gameCoordinationService;

    public MatchService(
        IMatchPreferencesService matchPreferencesService,
        IGamePreferencesService gamePreferencesService,
        IUserInterfaceService userInterfaceService,
        IGameCoordinationService gameCoordinationService
        )
    {
        _matchPreferencesService = matchPreferencesService ?? throw new ArgumentNullException(nameof(matchPreferencesService));
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _gameCoordinationService = gameCoordinationService ?? throw new ArgumentNullException(nameof(gameCoordinationService));
    }

    private async Task<MatchResponse> PlayFixedNumberOfGames(MatchRequest request)
    {
        MatchMessage message = new()
        {
            Cancelled = false,
            Match = request.Match,
            GameResponse = new()
            {
                Game = Games.Empty,
                Players = new(),
                Variant = EmptyVariant.GetVariant(),
                Button = Players.Empty         
            }
        };

        while (request.Match.Games.Count < request.Match.FixedNumberOfGames)
            message = await _gameCoordinationService.ExecuteAsync(
                new GameRequest
                {
                    Match = message.Match,
                    Players = message.Match.Players,
                    Variant = message.Match.FixedVariant,
                    Deck = message.Match.FixedDeck,
                    Button = message.GameResponse.Button
                }
            );

        return new MatchResponse
        {
            Cancelled = false,
            Match = message.Match,
            Winners = message.Match.Players.GetRichest(),
            PlayAgain = message.Match.Games.Count < request.Match.FixedNumberOfGames
        };
    }

    private async Task<MatchResponse> PlayIndefinitely(MatchRequest request)
    {
        var players = request.Match.Players.ToList();

        var button = players
            .SingleOrDefault(x => x.Id == request.InitialButton.Id)
            ?? players.First();
        
        MatchMessage message = new()
        {
            Cancelled = false,
            Match = request.Match,
            GameResponse = new()
            {
                Game = Games.Empty,
                Players = request.Match.Players,
                Button = button,
                Variant = EmptyVariant.GetVariant()
            }
        };

        var keepPlaying = true;
        while (keepPlaying)
        {
            message = await _gameCoordinationService.ExecuteAsync(new GameRequest { 
                Match = message.Match,
                Players = message.Match.Players,
                Variant = message.Match.FixedVariant,
                Deck = message.Match.FixedDeck,
                Button = message.GameResponse.Button
            });

            keepPlaying =
                await _gamePreferencesService.GetPlayAgain(message.GameResponse);
        }

        return new MatchResponse
        {
            Cancelled = false,
            Match = message.Match,
            Winners = message.Match.Players.GetRichest(),
            PlayAgain = message.Match.Games.Count < request.Match.FixedNumberOfGames
        };
    }

    private Task WriteMatchStartInfoAsync(Match match)
    {
        var s = _userInterfaceService;

        s.WriteHeading(HeadingLevel.Two, "Welcome to the new match!");

        s.WriteList("Players:", match.Players.Select(x => x.Name).ToArray());

        s.WriteHeading(HeadingLevel.Three, $"The match type is {match.FixedVariant.Name}");

        s.WriteLine(
            match.FixedNumberOfGames.HasValue()
            ? $"The match will consist of {match.FixedNumberOfGames} games."
            : $"The match has no fixed number of games."
        );

        return Task.CompletedTask;
    }

    public async Task<MatchResponse> PlayAsync(MatchRequest request)
    {
        await WriteMatchStartInfoAsync(request.Match);

        var resultTask =
            await _matchPreferencesService.ConfirmStartAsync() switch
            {
                false => CancelMatchAsync(request.Match),
                true =>
                    EvaluateResult(
                        await
                        (
                            request.Match.FixedNumberOfGames switch
                            {
                                > 0 => PlayFixedNumberOfGames(request),
                                _ => PlayIndefinitely(request)
                            }
                        )
                    )
            };

        return await resultTask;
    }

    private async Task<MatchResponse> CancelMatchAsync(Match match)
    {
        _userInterfaceService.WriteLine("Match was cancelled.");
        return new MatchResponse
        {
            Cancelled = true,
            Match = match,
            Winners = new(),
            PlayAgain = await _matchPreferencesService.GetPlayAgain(match)
        };
    }

    private async Task<MatchResponse> EvaluateResult(MatchResponse responseIn) => 
        new()
        {
            Cancelled = false,
            Match = responseIn.Match,
            Winners = new(),
            PlayAgain = await _matchPreferencesService.GetPlayAgain(responseIn.Match)
        };
}
