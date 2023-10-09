namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class TwoPairTests
{
    [Fact]
    public void Qualify_True_When_Two_Pairs_Exist()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.TwoPair, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
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
        var fixture = new HandQualifierTestFixture()
            .For(Hands.TwoPair, HandQualifications.Eliminated)
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
            })
            .ExpectedNeededCard(new List<Rank> { Ranks.Five, Ranks.Two }, Suits.All);

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_Possible_When_Only_One_Pair_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.TwoPair, HandQualifications.Possible)
            .WithCardsRemaining(1)
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
            })
            .ExpectedNeededCard(new List<Rank> { Ranks.Five, Ranks.Two }, Suits.All);

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
