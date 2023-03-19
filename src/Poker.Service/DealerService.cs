namespace Poker.Service;

public class DealerService : IDealerService
{
    private readonly IRandomFactory _randomFactory;

    public DealerService(IRandomFactory randomFactory)
    {
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
    }

    public Task<Deck> ShuffleAsync(Deck deck)
    {
        var random = _randomFactory.Create();

        // Fisher-Yates shuffle algorithm
        for (int i = deck.Cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (deck.Cards[j], deck.Cards[i]) = (deck.Cards[i], deck.Cards[j]);
        }

        return Task.FromResult(deck);
    }
}