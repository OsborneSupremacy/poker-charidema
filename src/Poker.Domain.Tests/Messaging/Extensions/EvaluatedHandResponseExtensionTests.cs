namespace Poker.Domain.Tests.Messaging.Extensions;

[ExcludeFromCodeCoverage]
public class EvaluatedHandResponseExtensionTests
{
    [Fact]
    public void ToPlayerHand_ExpectedResult_WhenPairOfTwos()
    {
        // Arrange
        Card joker = Cards.CreateJoker();

        Queue<Card> unusedWild = new();
        unusedWild.Enqueue(joker);

        var response = new EvaluatedHandResponse
        {
            Participant = Participants.Empty,
            Hand = Pairs.Twos,
            HandQualification = HandQualifications.Qualifies,
            EvaluatedHandSegments =
            [
                new()
                {
                    MeetsRequirements = true,
                    Contributing = new() { Standard = [Cards.TwoOfClubs, Cards.TwoOfDiamonds], Wild = [] },
                    Outstanding = new() { RequiredCount = 0, EligibleCards = [] },
                    UnusedCards = new UnusedCardsMessage
                    {
                        // the unused cards in the particular segments don't matter. The final
                        // list of unused cards is a property of the EvaluatedHandResponse
                        UnusedStandard = [],
                        UnusedWild = new()
                    }
                }
            ],
            UnusedCards = new UnusedCardsMessage
            {
                UnusedStandard =
                [
                    Cards.ThreeOfClubs,
                    Cards.FourOfClubs,
                    Cards.FiveOfClubs
                ],
                UnusedWild = unusedWild
            },
            RemainingCardCount = 0
        };

        ParticipantHand expectedResult = new()
        {
            Participant = Participants.Empty,
            Hand = Pairs.Twos,
            HandCards = new()
            {
                Standard =
                [
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                ],
                Wild = []
            },
            Kickers =
            [
                joker,
                Cards.FiveOfClubs,
                Cards.FourOfClubs
            ],
            DeadCards = [Cards.ThreeOfClubs]
        };

        // Act
        var result = response.ToPlayerHand();

        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}

