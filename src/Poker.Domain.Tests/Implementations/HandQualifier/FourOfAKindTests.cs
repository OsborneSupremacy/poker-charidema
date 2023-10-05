namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FourOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Four_Of_A_Kind()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.FourOfAKind)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfClubs,
                        Cards.AceOfSpades
                    }
                );
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.NineOfHearts);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Four_Of_A_Kind_With_Joker()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.FourOfAKind)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfClubs,
                        Cards.AceOfSpades
                    }
                );
                x.WithJoker(Cards.AceOfDiamonds);
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.NineOfHearts);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Four_Of_A_Kind_With_Two_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.FourOfAKind)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfSpades
                    }
                );
                x.WithJoker(Cards.AceOfDiamonds);
                x.WithJoker(Cards.AceOfClubs);
            })
            .ExpectedInKicker(x =>
            {
                x.With(Cards.NineOfHearts);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Four_Of_A_Kind()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.FourOfAKind)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfClubs,
                        Cards.KingOfSpades,
                        Cards.NineOfHearts
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}

