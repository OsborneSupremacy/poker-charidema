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
            Hand = Pairs.Twos,
            HandQualification = HandQualifications.Qualifies,
            EvaluatedHandSegments = new List<EvaluatedHandSegmentResponse>
            {
                new()
                {
                    MeetsRequirements = true,
                    Contributing = new()
                    {
                        Standard = new()
                        {
                            Cards.TwoOfClubs,
                            Cards.TwoOfDiamonds                 
                        },
                        Wild = new()
                    },
                    Outstanding = new()
                    {
                        RequiredCount = 0,
                    EligibleCards = new()
                    },
                    UnusedCards = new UnusedCardsMessage
                    {
                        // the unused cards in the particular segments don't matter. The final
                        // list of unused cards is a property of the EvaluatedHandResponse
                        UnusedStandard = new(),
                        UnusedWild = new()
                    }
                }
            },
            UnusedCards = new UnusedCardsMessage
            {
                UnusedStandard = new List<Card>
                {
                    Cards.ThreeOfClubs,
                    Cards.FourOfClubs,
                    Cards.FiveOfClubs
                },
                UnusedWild = unusedWild
            },
            RemainingCardCount = 0
        };
        
        PlayerHand expectedResult = new()
        {
            Hand = Pairs.Twos,
            HandCards = new()
            {
                Standard = new()
                {
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds                  
                },
                Wild = new()
            },
            Kickers = new()
            {
                joker,
                Cards.FiveOfClubs,
                Cards.FourOfClubs
            },
            DeadCards = new()
            {
                Cards.ThreeOfClubs
            }
        };
        
        // Act
        var result = response.ToPlayerHand();
        
        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}

