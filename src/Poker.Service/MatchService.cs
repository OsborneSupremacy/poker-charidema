using Poker.Domain.Implementations.Variants;

namespace Poker.Service;

public class MatchService : IMatchService
{
    private readonly IMatchPreferencesService _matchPreferencesService;

    private readonly IGamePreferencesService _gamePreferencesService;

    private readonly IGameService _gameService;
    
    private readonly IDealerService _dealerService;

    private readonly IUserInterfaceService _userInterfaceService;

    public MatchService(
        IMatchPreferencesService matchPreferencesService,
        IGamePreferencesService gamePreferencesService,
        IGameService gameService,
        IUserInterfaceService userInterfaceService,
        IDealerService dealerService)
    {
        _matchPreferencesService = matchPreferencesService ?? throw new ArgumentNullException(nameof(matchPreferencesService));
        _gamePreferencesService = gamePreferencesService ?? throw new ArgumentNullException(nameof(gamePreferencesService));
        _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _dealerService = dealerService ?? throw new ArgumentNullException(nameof(dealerService));
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
        {
            message = await CoordinateGameAsync(
                new GameRequest
                {
                    Match = message.Match,
                    Players = message.Match.Players,
                    Variant = message.Match.FixedVariant,
                    Deck = message.Match.FixedDeck,
                    Button = message.GameResponse.Button
                }
            );
        }

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
            message = await CoordinateGameAsync(new GameRequest { 
                Match = message.Match,
                Players = message.Match.Players,
                Variant = message.Match.FixedVariant,
                Deck = message.Match.FixedDeck,
                Button = message.GameResponse.Button
            });

            WriteStandings(message.Match);

            keepPlaying =
                await _gamePreferencesService.GetPlayAgain(message.GameResponse!);
        }

        return new MatchResponse
        {
            Cancelled = false,
            Match = message.Match,
            Winners = message.Match.Players.GetRichest(),
            PlayAgain = message.Match.Games.Count < request.Match.FixedNumberOfGames
        };
    }

    private void WriteStandings(Match match)
    {
        _userInterfaceService.WriteHeading(HeadingLevel.Five, "Standings");
        foreach (var player in match.Players.OrderByDescending(p => p.Stack))
            _userInterfaceService.WriteLine($"{player.Name} - {player.Stack:C}");
        _userInterfaceService.WriteLine();
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

    /// <summary>
    /// It may unclear why this method is needed. Here's what it does that
    /// GameService does not do:
    /// 
    /// Invokes the game service, add the results to the match, updates
    /// the player information
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task<MatchMessage> CoordinateGameAsync(GameRequest request)
    {
        var gamesOut = request.Match.Games;

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Starting game {request.Match.Games.Count + 1}");

        // pass button to next player if it's not the first game
        var button = gamesOut.Any()
            ? request.Match.Players.NextPlayer(request.Button)
            : request.Button;

        var gameResponse = await _gameService.PlayAsync(
            new GameRequest()
            {
                Match = request.Match,
                Players = request.Match.Players,
                Variant = request.Match.FixedVariant,
                Deck = request.Match.FixedDeck,
                Button = button
            }
        );

        gamesOut.Add(gameResponse);

        _userInterfaceService
            .WriteHeading(HeadingLevel.Four, $"Game over! TBD wins.");

        gamesOut.Add(gameResponse);

        // TODO: Find a better place for this
        List<Card> cards = gameResponse.Game.Deck.Cards;
        foreach(var player in gameResponse.Players)
            cards.AddRange(player.Cards);
        
        var deck = await _dealerService.ShuffleAsync(gameResponse.Game.Deck with
        {
            Cards = cards
        });
        
        var matchOut = request.Match with
        {
            Games = gamesOut,
            Players = gameResponse.Players
        };

        WriteStandings(matchOut);
        
        return new MatchMessage {
            Match = matchOut with { FixedDeck = deck },
            Cancelled = false,
            GameResponse = gameResponse
        };
    }

    private async Task<MatchResponse> EvaluateResult(MatchResponse responseIn) => 
        new MatchResponse()
        {
            Cancelled = false,
            Match = responseIn.Match,
            Winners = new(),
            PlayAgain = await _matchPreferencesService.GetPlayAgain(responseIn.Match)
        };
}
