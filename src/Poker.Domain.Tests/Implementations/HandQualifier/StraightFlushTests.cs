namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class StraightFlushTests
{
    [Fact]
    public void Qualify_True_When_StraightFlush_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.StraightFlush, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
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

    [Fact]
    public void Qualify_False_When_Flush_But_No_Straight_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.StraightFlush, HandQualifications.Eliminated)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.EightOfSpades,
                        Cards.KingOfSpades,
                        Cards.QueenOfSpades,
                        Cards.JackOfSpades,
                        Cards.TenOfSpades
                    }
                );
            })
            .ExpectedNeededCard(new() { Rank = Ranks.Ace, Suit = Suits.Spades });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_Straight_But_No_Flush_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.StraightFlush, HandQualifications.Eliminated)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfSpades,
                        Cards.JackOfSpades,
                        Cards.TenOfSpades,
                        Cards.EightOfSpades
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
