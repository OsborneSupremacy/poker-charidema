namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FiveOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Five_Of_A_Kind()
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
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Five_Of_A_Kind()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfHearts,
            Cards.AceOfDiamonds,
            Cards.AceOfClubs,
            Cards.AceOfSpades,
            Cards.KingOfSpades
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.FiveOfAKind
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}

