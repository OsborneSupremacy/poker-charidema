namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FullHouseTests
{
    [Fact]
    public void Qualify_True_When_FullHouse_Exist()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.FullHouse, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.TwoOfHearts,
                        Cards.TwoOfDiamonds,
                        Cards.TwoOfSpades,
                        Cards.FourOfDiamonds,
                        Cards.FourOfHearts
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_No_FullHouse_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.FullHouse, HandQualifications.Eliminated)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.TwoOfHearts,
                        Cards.TwoOfDiamonds,
                        Cards.TwoOfSpades,
                        Cards.FourOfDiamonds,
                        Cards.FiveOfDiamonds
                    }
                );
            })
            .ExpectedNeededCard(new() { Rank = Ranks.Five, Suit = Suits.Empty });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
