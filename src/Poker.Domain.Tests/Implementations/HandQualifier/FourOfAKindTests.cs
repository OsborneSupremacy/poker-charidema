namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FourOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Four_Of_A_Kind()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfHearts,
            Cards.AceOfDiamonds,
            Cards.AceOfClubs,
            Cards.AceOfSpades,
            Cards.NineOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.FourOfAKind
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.HandCards.Should().BeEquivalentTo(new List<Card>()
        {
            Cards.AceOfHearts,
            Cards.AceOfDiamonds,
            Cards.AceOfClubs,
            Cards.AceOfSpades
        });
        result.Kickers.Should().BeEquivalentTo(new List<Card>() { Cards.NineOfHearts });
        result.DeadCards.Should().BeEmpty();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Four_Of_A_Kind()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfHearts,
            Cards.AceOfDiamonds,
            Cards.AceOfClubs,
            Cards.KingOfSpades,
            Cards.NineOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.FourOfAKind
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}

