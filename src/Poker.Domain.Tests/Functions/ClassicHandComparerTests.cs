namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class ClassicHandComparerTests
{
    private static ParticipantHand CreatePairOfTwos(Card twoOne, Card twoTwo, params Card[] kickers) =>
        new()
        {
            Participant = Participants.Empty,
            Hand = Pairs.Twos,
            HandCards = new() { Standard = [twoOne, twoTwo], Wild = [] },
            Kickers = kickers,
            DeadCards = []
        };

    [Fact]
    public void Compare_WildKickerWins_OtherHandHasKingKicker()
    {
        // Arrange
        var withWildKicker = CreatePairOfTwos(
            Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.CreateJoker(), Cards.FiveOfClubs, Cards.FourOfClubs);
        var withKingKicker = CreatePairOfTwos(
            Cards.TwoOfClubs, Cards.TwoOfDiamonds, Cards.KingOfSpades, Cards.FiveOfDiamonds, Cards.FourOfDiamonds);

        // Act
        var result = ClassicHandComparer.Compare(withWildKicker, withKingKicker);

        // Assert
        result.Should().BePositive();
    }

    [Fact]
    public void Compare_Tie_SameRanksInDifferentSuits()
    {
        // Arrange
        var x = CreatePairOfTwos(
            Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.KingOfSpades, Cards.FiveOfClubs, Cards.FourOfClubs);
        var y = CreatePairOfTwos(
            Cards.TwoOfClubs, Cards.TwoOfDiamonds, Cards.KingOfHearts, Cards.FiveOfDiamonds, Cards.FourOfDiamonds);

        // Act
        var result = ClassicHandComparer.Compare(x, y);

        // Assert
        result.Should().Be(0);
    }

    [Fact]
    public void Compare_HigherHandDefinitionWins_LowerHandHasHigherRanks()
    {
        // Arrange
        var pairOfTwos = CreatePairOfTwos(
            Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.AceOfSpades, Cards.KingOfClubs, Cards.QueenOfClubs);

        ParticipantHand twoPair = new()
        {
            Participant = Participants.Empty,
            Hand = TwoPair.ThreesOverTwos,
            HandCards = new()
            {
                Standard = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds],
                Wild = []
            },
            Kickers = [Cards.FourOfClubs],
            DeadCards = []
        };

        // Act
        var result = ClassicHandComparer.Compare(pairOfTwos, twoPair);

        // Assert
        result.Should().BeNegative();
    }

    [Fact]
    public void Compare_LargerGroupComparedFirst_FullHouses()
    {
        // Arrange
        ParticipantHand threesOverAces = new()
        {
            Participant = Participants.Empty,
            Hand = FullHouses.ThreesOverAces,
            HandCards = new()
            {
                Standard =
                [
                    Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs,
                    Cards.AceOfSpades, Cards.AceOfHearts
                ],
                Wild = []
            },
            Kickers = [],
            DeadCards = []
        };

        ParticipantHand foursOverTwos = new()
        {
            Participant = Participants.Empty,
            Hand = FullHouses.FoursOverTwos,
            HandCards = new()
            {
                Standard =
                [
                    Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs,
                    Cards.TwoOfSpades, Cards.TwoOfHearts
                ],
                Wild = []
            },
            Kickers = [],
            DeadCards = []
        };

        // Act
        var result = ClassicHandComparer.Compare(threesOverAces, foursOverTwos);

        // Assert
        result.Should().BeNegative();
    }
}
