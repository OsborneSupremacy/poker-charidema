namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class ThreeOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Three_Of_A_Kind()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.ThreeOfAKind, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                    Cards.AceOfHearts,
                    Cards.AceOfDiamonds,
                    Cards.AceOfClubs
                    }
                );
            })
            .ExpectedInKicker(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.NineOfHearts,
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
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Three_Of_A_Kind()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.ThreeOfAKind, HandQualifications.Eliminated)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfSpades,
                        Cards.ThreeOfClubs,
                        Cards.FourOfHearts,
                        Cards.FiveOfHearts
                    }
                );
            })
            .ExpectedNeededCard(new() { Rank = Ranks.Ace, Suit = Suits.Empty });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}

