namespace Poker.Domain.Extensions;

public static class PhaseRequestExtensions
{
    /// <summary>
    /// Transforms a <see cref="PhaseRequest"/> into a <see cref="PhaseResponse"/>,
    /// not changing any of the shared properties, and populating true for the GameOver
    /// property. Use to exit a phase early.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static PhaseResponse ToGameOverResponse(this PhaseRequest input) =>
        new()
        {
            Deck = input.Deck,
            CommunityCards = input.CommunityCards,
            Participants = input.Participants,
            Winners = [],
            GameOver = true,
            Pot = input.Pot
        };
}
