namespace Poker.Domain.Functions;

public static class DefaultWinningsDistributor
{
    public static readonly WinningsDistributor Distribute = request =>
    {
        var pot = request.Pot;

        var winnerPayouts = new int[request.Winners.Count];
        for(int x = 0; x < winnerPayouts.Length; x++)
            winnerPayouts[x] = 0;

        while (pot > 0)
        {
            for (int x = 0; x < winnerPayouts.Length; x++)
            {
                if(pot <= 0)
                    break;
                winnerPayouts[x] += 1;
                pot -= 1;
            }
        }

        var pi = 0;
        
        List<Player> playersOut = new();
        var winnerIds = request.Winners.Select(w => w.Id).ToList();
        
        foreach (var player in request.Players)
            playersOut.Add
            (
                player with
                {
                    Stack = winnerIds.Contains(player.Id)
                        ? player.Stack + winnerPayouts[pi++]
                        : player.Stack
                }
            );

        return new DistributeWinningsResponse
        {
            Players = playersOut
        };
    };
}
