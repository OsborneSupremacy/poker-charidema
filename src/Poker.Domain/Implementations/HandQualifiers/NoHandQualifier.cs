namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier NoHandQualifier { get; } =
        (QualifiedHandRequest request) =>
        {
            return new QualifiedHandResponse
            {
                Hand = request.Hand,
                HandQualification = HandQualifications.Qualifies,
                HandCards = new(),
                Kickers = new(),
                DeadCards = request.Cards
            };
        };
}
