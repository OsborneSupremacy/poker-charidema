namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier RoyalFlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
        {
            var straightFlush =
                StraightFlushHandQualifier!(request with { Hand = HandDefinitions.StraightFlush })!;

            if(straightFlush.IsRoyalFlush())
                return straightFlush with { Hand = HandDefinitions.RoyalFlush };

            var potentialRoyal = FindPotentialStraightFlushes(request)
                .Where(sf => sf.TheoreticalHighRank() == Ranks.Ace)
                .WithFewestNeededCards();

            if(potentialRoyal.Any())
                return request.Hand.ToUnqualifiedHand(
                    potentialRoyal.First(),
                    potentialRoyal.First().EnoughRemainingCards()
                );

            return straightFlush with
            {
                HandQualification = HandQualifications.Eliminated
            };
        };

    private static bool IsRoyalFlush(this QualifiedHandResponse straightFlush) =>
        straightFlush.Qualifies() switch
        {
            true => straightFlush.HighRank == Ranks.Ace,
            false => false
        };

}
