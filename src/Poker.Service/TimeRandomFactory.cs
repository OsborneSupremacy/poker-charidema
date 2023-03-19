namespace Poker.Service;

public class TimeRandomFactory : IRandomFactory
{
    public Random Create() =>
        new(DateTime.Now.Millisecond);
}
