namespace Poker.Domain.Functions;

public static class FisherYatesShuffleAlgorithm
{
    public static readonly ShuffleAlgorithm Shuffle = (random, deckIn) =>
    {
        List<Card> cardsOut = new();
        cardsOut.AddRange(deckIn.Cards);
        
        for (int i = cardsOut.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (cardsOut[j], cardsOut[i]) = (cardsOut[i], cardsOut[j]);
        }

        return deckIn with { Cards = cardsOut };
    };
}
