namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FiveOfAKindTests
{
    [Fact]
    public void Qualify_True_When_Hand_Contains_Five_Of_A_Kind_With_One_Joker()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.FiveOfAKind
            })
            .ExpectedInHand(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfClubs,
                        Cards.AceOfSpades,
                        Cards.CreateJoker() with { Impersonating = Cards.AceOfSpades }
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
    }

    [Fact]
    public void Qualify_True_When_Hand_Contains_Five_Of_A_Kind_With_Two_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Qualifies,
                RemainingCards = 0,
                Hand = Hands.FiveOfAKind
            })
            .ExpectedInHand(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfSpades,
                        Cards.CreateJoker() with { Impersonating = Cards.AceOfSpades },
                        Cards.CreateJoker() with { Impersonating = Cards.AceOfClubs }
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
    }

    [Fact]
    public void Qualify_False_When_Hand_Does_Not_Contain_Five_Of_A_Kind()
    {
        // arrange
        var fixture = new HandQualifierTestFixture(
            new()
            {
                ExpectedHandQualification = HandQualifications.Eliminated,
                RemainingCards = 0,
                Hand = Hands.FiveOfAKind
            })
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfClubs,
                        Cards.AceOfSpades,
                        Cards.KingOfSpades
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected(fixture);
    }
}

