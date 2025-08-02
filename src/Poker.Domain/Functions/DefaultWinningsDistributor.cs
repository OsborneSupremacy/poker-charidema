namespace Poker.Domain.Functions;

public static class DefaultWinningsDistributor
{
    public static readonly WinningsDistributor Distribute = request =>
    {
        var pot = request.Pot;

        var winnerPayouts = new int[request.Winners.Count];
        for (int x = 0; x < winnerPayouts.Length; x++)
            winnerPayouts[x] = 0;

        while (pot > 0)
        {
            for (int x = 0; x < winnerPayouts.Length; x++)
            {
                if (pot <= 0)
                    break;
                winnerPayouts[x] += 1;
                pot -= 1;
            }
        }

        var pi = 0;

        var winnerIds = request.Winners.Select(w => w.Id).ToList();

        var playersOut = request.Participants
            .Select(p => p with
            {
                Stack = winnerIds.Contains(p.Id)
                    ? p.Stack + winnerPayouts[pi++]
                    : p.Stack
            })
            .ToList();

        return new DistributeWinningsResponse
        {
            Participants = playersOut
        };
    };
}
