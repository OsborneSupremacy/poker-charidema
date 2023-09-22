namespace Poker.Service;

public class HandRankingService
{
    public QualifiedHandResponse GetBestHand(QualifiedHandRequest request)
    {
        foreach(var hand in Hands.All.OrderByDescending(x => x.Value))
        {
            var response = hand.HandQualifier(request);
            if(response.Qualifies())
                return response;
        }

        return Hands.NoHand.HandQualifier(request);
    }
}
