namespace Poker.Domain;

public enum HandQualifications
{
    DoesNotQualify,
    Possible,
    Qualifies
}

public record QualifiedHand
{
    public required Hand Hand { get; set; }

    public HandQualifications HandQualification { get; init; }

    public required List<Card> HandCards { get; init; }

    public required List<Card> Kickers { get; init; }

    public required List<Card> DeadCards { get; init; }
}
