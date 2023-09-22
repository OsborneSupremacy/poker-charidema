namespace Poker.Domain.Extensions;

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

    public static List<Participant> GetRichest(this IList<Participant> input)
    {
        var maxStack = input.Max(x => x.Participant.Stack);
        return input.Where(x => x.Participant.Stack == maxStack).ToList();
    }
}
