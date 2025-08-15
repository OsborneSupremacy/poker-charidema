namespace Poker.Domain.Events;

public record CardDealtToParticipant
{
    public required Participant Participant { get; init; }

    public required Card Card  { get; init; }
}
