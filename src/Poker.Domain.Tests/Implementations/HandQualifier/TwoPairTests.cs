namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class TwoPairTests
{
    [Fact]
    public void Qualify_True_When_Two_Pairs_Exist()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.TwoPair
            })
            .ExpectedInHand(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.TwoOfHearts,
                        Cards.TwoOfDiamonds,
                        Cards.FourOfHearts,
                        Cards.FourOfDiamonds
                    }
                );
            })
            .ExpectedInKicker(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.NineOfHearts
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_Only_One_Pair_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Eliminated,
                RemainingCards = 0,
                Hand = Hands.TwoPair
            })
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.TwoOfHearts,
                        Cards.TwoOfDiamonds,
                        Cards.FiveOfHearts,
                        Cards.FourOfDiamonds
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
