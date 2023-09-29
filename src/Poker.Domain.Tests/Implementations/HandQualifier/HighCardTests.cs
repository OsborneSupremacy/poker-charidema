namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class HighCardTests
{
    [Fact]
    public void Qualify_Get_Highest_Ranking_Card()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.HighCard)
            .ExpectedInHand(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfSpades
                    }
                );
            })
            .ExpectedInKicker(x => {
                x.With(
                    new List<Card>() {
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
    public void Qualify_Get_Joker_When_Joker_Is_Highest()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.HighCard)
            .ExpectedInHand(x =>
            {
                x.With(
                     Cards.CreateJoker() with { Impersonating = Cards.AceOfSpades }
                );
            })
            .ExpectedInKicker(x => {
                x.With(
                    new List<Card>() {
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
}
