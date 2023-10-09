namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class StraightTests
{
    [Fact]
    public void Qualify_True_When_Straight_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Straight, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfHearts,
                        Cards.JackOfClubs,
                        Cards.TenOfDiamonds,
                        Cards.NineOfSpades
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_True_When_Straight_Exists_With_One_WildCard()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Straight, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfHearts,
                        Cards.JackOfClubs,
                        Cards.TenOfDiamonds
                    }
                );
                x.WithJokerFor(Cards.AceOfSpades);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_True_When_Straight_Exists_With_Two_WildCards()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Straight, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfHearts,
                        Cards.JackOfClubs
                    }
                );
                x.WithJokerFor(Cards.TenOfSpades);
                x.WithJokerFor(Cards.AceOfSpades);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_No_Straight_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Straight, HandQualifications.Eliminated)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfHearts,
                        Cards.JackOfClubs,
                        Cards.TenOfDiamonds,
                        Cards.EightOfSpades
                    }
                );
            })
            .ExpectedNeededCard(new() { Rank = Ranks.Nine, Suit = Suits.Empty });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
