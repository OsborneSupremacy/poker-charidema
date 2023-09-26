namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class PairTests
{
    [Fact]
    public void Qualify_True_When_Pair_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new() {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.Pair
            })
            .ExpectedInHand(x =>
            {
                x.With(Cards.TwoOfHearts);
                x.With(Cards.TwoOfDiamonds);
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.FourOfHearts);
                x.With(Cards.EightOfHearts);
                x.With(Cards.NineOfHearts);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
    }

    [Fact]
    public void Qualify_True_When_Pair_Exists_Because_Of_Joker()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.Pair
            })
            .ExpectedInHand(x =>
            {
                x.With(Cards.NineOfClubs);
                x.With(Cards.CreateJoker());
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.FourOfHearts);
                x.With(Cards.EightOfHearts);
                x.With(Cards.TwoOfHearts);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
    }

    [Fact]
    public void Jokers_In_HandCards_When_Two_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.Pair
            })
            .ExpectedInHand(x =>
            {
                x.With(Cards.CreateJoker());
                x.With(Cards.CreateJoker());
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.FourOfHearts);
                x.With(Cards.EightOfHearts);
                x.With(Cards.TwoOfHearts);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
        result
            .HandCards
            .Where(x => x.Impersonating == Cards.AceOfSpades)
            .SingleOrDefault()
            .Should()
            .NotBeNull();

        result
            .HandCards
            .Where(x => x.Impersonating == Cards.AceOfHearts)
            .SingleOrDefault()
            .Should()
            .NotBeNull();
    }

    [Fact]
    public void Jokers_In_HandCards_When_All_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.Pair
            })
            .ExpectedInHand(x =>
            {
                x.With(Cards.CreateJoker());
                x.With(Cards.CreateJoker());
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.CreateJoker());
                x.With(Cards.CreateJoker());
                x.With(Cards.CreateJoker());
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
    }

    [Fact]
    public void Qualify_False_When_No_Pair_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Eliminated,
                RemainingCards = 0,
                Hand = Hands.Pair
            })
            .ExpectedInDeadCards(x =>
            {
                x.With(new List<Card> {
                    Cards.TwoOfHearts,
                    Cards.ThreeOfDiamonds,
                    Cards.FourOfHearts,
                    Cards.EightOfHearts,
                    Cards.NineOfHearts
                });
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
    }
}
