namespace Poker.Domain;

public delegate QualifiedHand HandQualifier(
    Hand hand,
    List<Card> cards,
    uint remainingCardCount
);
