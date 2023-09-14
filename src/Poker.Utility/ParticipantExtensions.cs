using Poker.Library;

namespace Poker.Utility;

public static class ParticipantExtensions
{
    public static Participant NextPlayer(
        this List<Participant> participant,
        Participant currentParticipant
        )
    {
        var index = participant
            .FindIndex(x => x.Id == currentParticipant.Id);

        if (index == participant.Count - 1)
            return participant.First();

        return participant[index + 1];
    }
}
