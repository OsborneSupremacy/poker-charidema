namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class StraightTests
{
    [Fact]
    public void Qualify_True_When_Straight_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Straight)
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
            .For(Hands.Straight)
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
                x.WithJoker(Cards.AceOfSpades);
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
            .For(Hands.Straight)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfHearts,
                        Cards.JackOfClubs
                    }
                );
                x.WithJoker(Cards.TenOfHearts);
                x.WithJoker(Cards.AceOfSpades);
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
            .For(Hands.Straight)
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
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
