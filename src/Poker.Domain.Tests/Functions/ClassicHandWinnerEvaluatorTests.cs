using Poker.Service;
using Poker.Service.Messaging;

namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class ClassicHandWinnerEvaluatorTests
{
    private Participant _playerOne;

    private Participant _playerTwo;

    private Participant _playerThree;

    public ClassicHandWinnerEvaluatorTests()
    {
        PlayerFactory playerFactory = new(new RandomService(new SystemRandomFactory()));

        _playerOne = playerFactory.CreateAsync(new PlayerCreateRequest
        {
            Automaton = true,
            BeginningStack = 100,
            Id = Guid.NewGuid()
        }).GetAwaiter().GetResult().ToParticipant();

        _playerTwo = playerFactory.CreateAsync(new PlayerCreateRequest
        {
            Automaton = true,
            BeginningStack = 100,
            Id = Guid.NewGuid()
        }).GetAwaiter().GetResult().ToParticipant();

        _playerThree = playerFactory.CreateAsync(new PlayerCreateRequest
        {
            Automaton = true,
            BeginningStack = 100,
            Id = Guid.NewGuid()
        }).GetAwaiter().GetResult().ToParticipant();
    }

    [Fact]
    public void Evaluate_WinnerIdentified_OnePlayerHasPairOfTwos()
    {
        // Arrange
        _playerOne = _playerOne.DealCardsFaceDownTo([Cards.TwoOfSpades, Cards.TwoOfHearts]);
        _playerTwo = _playerTwo.DealCardsFaceDownTo([Cards.TwoOfSpades, Cards.ThreeOfSpades]);
        _playerThree = _playerThree.DealCardsFaceDownTo([Cards.TwoOfSpades, Cards.ThreeOfSpades]);

        EvaluateWinnerRequest request = new()
        {
            Participants =
            [
                _playerOne,
                _playerTwo,
                _playerThree
            ],
            HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
            HandEvaluator = ClassicHandEvaluator.Evaluate
        };

        // Act
        var response = ClassicWinnerEvaluator.Evaluate(request);

        // Assert
        response.Winners.Should().BeEquivalentTo([_playerOne]);
        response.WinningHand.Should().Be(Pairs.Twos);
    }

    [Fact]
    public void Evaluate_WinnersIdentified_TwoPlayersHavePairOfTwos()
    {
        // Arrange
        _playerOne = _playerOne.DealCardsFaceDownTo([Cards.TwoOfSpades, Cards.TwoOfHearts]);
        _playerTwo = _playerTwo.DealCardsFaceDownTo([Cards.TwoOfClubs, Cards.TwoOfDiamonds]);
        _playerThree = _playerThree.DealCardsFaceDownTo([Cards.FiveOfSpades, Cards.ThreeOfSpades]);

        EvaluateWinnerRequest request = new()
        {
            Participants =
            [
                _playerOne,
                _playerTwo,
                _playerThree
            ],
            HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
            HandEvaluator = ClassicHandEvaluator.Evaluate
        };

        // Act
        var response = ClassicWinnerEvaluator.Evaluate(request);

        // Assert
        response.Winners.Should().BeEquivalentTo([_playerOne, _playerTwo ]);
        response.WinningHand.Should().Be(Pairs.Twos);
    }

    [Fact]
    public void Evaluate_WinnerIdentified_TwoPlayersHavePairOfTwosButOneHasHigherKicker()
    {
        // Arrange
        _playerOne = _playerOne.DealCardsFaceDownTo([Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.AceOfClubs]);
        _playerTwo = _playerTwo.DealCardsFaceDownTo([Cards.TwoOfClubs, Cards.TwoOfDiamonds, Cards.KingOfClubs]);
        _playerThree = _playerThree.DealCardsFaceDownTo([Cards.FiveOfSpades, Cards.ThreeOfSpades, Cards.NineOfSpades]);

        EvaluateWinnerRequest request = new()
        {
            Participants =
            [
                _playerOne,
                _playerTwo,
                _playerThree
            ],
            HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
            HandEvaluator = ClassicHandEvaluator.Evaluate
        };

        // Act
        var response = ClassicWinnerEvaluator.Evaluate(request);

        // Assert
        response.Winners.Should().BeEquivalentTo([_playerOne]);
        response.WinningHand.Should().Be(Pairs.Twos);
    }

    [Fact]
    public void Evaluate_WinnerIdentified_ThreePlayersHaveAceHighAndKickersDecideAfterFirstKicker()
    {
        // Arrange
        // Kickers: One K-9-4-3, Two K-8-7-2, Three Q-9-5-2. One wins on the second kicker.
        _playerOne = _playerOne.DealCardsFaceDownTo(
            [Cards.AceOfSpades, Cards.KingOfHearts, Cards.NineOfClubs, Cards.FourOfDiamonds, Cards.ThreeOfSpades]);
        _playerTwo = _playerTwo.DealCardsFaceDownTo(
            [Cards.AceOfHearts, Cards.KingOfDiamonds, Cards.EightOfSpades, Cards.SevenOfClubs, Cards.TwoOfDiamonds]);
        _playerThree = _playerThree.DealCardsFaceDownTo(
            [Cards.AceOfClubs, Cards.QueenOfSpades, Cards.NineOfDiamonds, Cards.FiveOfHearts, Cards.TwoOfSpades]);

        EvaluateWinnerRequest request = new()
        {
            Participants =
            [
                _playerOne,
                _playerTwo,
                _playerThree
            ],
            HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
            HandEvaluator = ClassicHandEvaluator.Evaluate
        };

        // Act
        var response = ClassicWinnerEvaluator.Evaluate(request);

        // Assert
        response.Winners.Should().BeEquivalentTo([_playerOne]);
        response.WinningHand.Should().Be(HighCards.Ace);
    }

    [Fact]
    public void Evaluate_WinnersIdentified_ThreePlayersHaveAceHighAndTwoHaveSameBestKickers()
    {
        // Arrange
        // Kickers: One K-9-4-3, Two K-9-4-3, Three Q-9-4-3. One and Two tie.
        _playerOne = _playerOne.DealCardsFaceDownTo(
            [Cards.AceOfSpades, Cards.KingOfHearts, Cards.NineOfClubs, Cards.FourOfDiamonds, Cards.ThreeOfSpades]);
        _playerTwo = _playerTwo.DealCardsFaceDownTo(
            [Cards.AceOfHearts, Cards.KingOfDiamonds, Cards.NineOfSpades, Cards.FourOfClubs, Cards.ThreeOfDiamonds]);
        _playerThree = _playerThree.DealCardsFaceDownTo(
            [Cards.AceOfClubs, Cards.QueenOfSpades, Cards.NineOfDiamonds, Cards.FourOfHearts, Cards.ThreeOfHearts]);

        EvaluateWinnerRequest request = new()
        {
            Participants =
            [
                _playerOne,
                _playerTwo,
                _playerThree
            ],
            HandCollectionEvaluator = DefaultHandCollectionEvaluator.Evaluate,
            HandEvaluator = ClassicHandEvaluator.Evaluate
        };

        // Act
        var response = ClassicWinnerEvaluator.Evaluate(request);

        // Assert
        response.Winners.Should().BeEquivalentTo([_playerOne, _playerTwo]);
        response.WinningHand.Should().Be(HighCards.Ace);
    }
}
