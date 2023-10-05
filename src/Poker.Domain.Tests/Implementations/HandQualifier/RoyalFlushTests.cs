namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class RoyalFlushTests
{
    [Fact]
    public void Qualify_True_When_RoyalFlus_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.RoyalFlush)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfSpades,
                        Cards.KingOfSpades,
                        Cards.QueenOfSpades,
                        Cards.JackOfSpades,
                        Cards.TenOfSpades
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_StraightFlush_But_No_RoyalFlush_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.RoyalFlush)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.NineOfSpades,
                        Cards.KingOfSpades,
                        Cards.QueenOfSpades,
                        Cards.JackOfSpades,
                        Cards.TenOfSpades
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
