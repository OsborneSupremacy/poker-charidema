namespace Poker.Domain.Tests.Extensions;

public static class QualifiedHandResponseExtensions
{
    public static void ShouldBeAsExpected(this QualifiedHandResponse result, HandBuilder builder)
    {
        result.HandCards.Should().BeEquivalentTo(builder.GetExpectedHandCards());
        result.Kickers.Should().BeEquivalentTo(builder.GetExpectedKickers());
        result.DeadCards.Should().BeEmpty();
    }
}
