namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class ThreeOfAKindTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Three_Of_A_Kind()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfHearts,
            Cards.AceOfDiamonds,
            Cards.AceOfClubs,
            Cards.FourOfHearts,
            Cards.NineOfHearts
        };

        var expectedHand = new List<Card>()
        {
            Cards.AceOfHearts,
            Cards.AceOfDiamonds,
            Cards.AceOfClubs
        };

        var expectedKickers = new List<Card>()
        {
            Cards.NineOfHearts,
            Cards.FourOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.ThreeOfAKind
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Qualifies);
        result.HandCards.Should().BeEquivalentTo(expectedHand);
        result.Kickers.Should().BeEquivalentTo(expectedKickers);
        result.DeadCards.Any().Should().BeFalse();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Three_Of_A_Kind()
    {
        // arrange
        List<Card> playerCards = new() {
            Cards.AceOfHearts,
            Cards.TwoOfDiamonds,
            Cards.ThreeOfClubs,
            Cards.FourOfHearts,
            Cards.FiveOfHearts
        };

        var request = new QualifiedHandRequest
        {
            Cards = playerCards,
            RemainingCardCount = 0,
            Hand = Hands.ThreeOfAKind
        };

        // act
        var result = HandQualifierDelegates.MatchingRankHandQualifier(request);

        // assert
        result.HandQualification.Should().Be(HandQualifications.Eliminated);
    }
}

