namespace Poker.Service;

/// <inheritdoc />
internal class SystemRandomFactory : IRandomFactory
{
    public Random Create() =>
        new(GetSeed());

    public int GetSeed() =>
        Random.Shared.Next();
}
