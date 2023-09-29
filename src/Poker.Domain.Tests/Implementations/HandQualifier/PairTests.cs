namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class PairTests
{
    [Fact]
    public void Qualify_True_When_Pair_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Pair)
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
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_True_When_Pair_Exists_Because_Of_Joker()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Pair)
            .ExpectedInHand(x =>
            {
                x.With(Cards.NineOfClubs);
                x.With(Cards.CreateJoker() with { Impersonating = Cards.NineOfSpades } );
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
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Jokers_In_HandCards_When_Two_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Pair)
            .ExpectedInHand(x =>
            {
                x.With(Cards.CreateJoker() with { Impersonating = Cards.AceOfSpades });
                x.With(Cards.CreateJoker() with { Impersonating = Cards.AceOfHearts });
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
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Jokers_In_HandCards_When_All_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Pair)
            .ExpectedInHand(x =>
            {
                x.With(Cards.CreateJoker() with { Impersonating = Cards.AceOfSpades });
                x.With(Cards.CreateJoker()  with { Impersonating = Cards.AceOfHearts });
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
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_No_Pair_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Pair)
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
        result.ShouldBeAsExpected();
    }
}
