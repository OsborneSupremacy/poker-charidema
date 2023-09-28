namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class StraightTests
{
    [Fact]
    public void Qualify_True_When_Straight_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.Straight
            })
            .ExpectedInHand(x =>
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
    public void Qualify_False_When_No_Straight_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Eliminated,
                RemainingCards = 0,
                Hand = Hands.Straight
            })
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
