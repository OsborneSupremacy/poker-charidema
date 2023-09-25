namespace Poker.Domain.Tests.Extensions;

public static class QualifiedHandResponseExtensions
{
    public static void ShouldBeAsExpected(
        this QualifiedHandResponse result,
        HandQualifierTestFixture fixture
        )
    {
        result.HandQualification.Should().Be(fixture.ExpectedHandQualification);
        result.HandCards.Should().BeEquivalentTo(fixture.ExpectedHandCards);
        result.Kickers.Should().BeEquivalentTo(fixture.ExpectedKickers);
        result.DeadCards.Should().BeEquivalentTo(fixture.ExpectedDeadCards);
    }
}
