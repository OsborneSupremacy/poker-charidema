namespace Poker.Service;

public class HandRankingService
{
    public QualifiedHandResponse GetBestHand(QualifiedHandRequest request)
    {
        foreach(var hand in HandDefinitions.All.OrderByDescending(x => x.Value))
        {
            var response = hand.HandQualifier(request);
            if(response.Qualifies())
                return response;
        }

        return HandDefinitions.NoHand.HandQualifier(request);
    }
}
