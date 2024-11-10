using Poker.Service;

namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class ClassicHandWinnerEvaluatorTests
{
    private Player _playerOne;

    private Player _playerTwo;

    private Player _playerThree;

    public ClassicHandWinnerEvaluatorTests()
    {
        PlayerFactory playerFactory = new(new RandomService(new TimeRandomFactory()));

        _playerOne = playerFactory.CreateAsync(new PlayerCreateRequest
        {
            Automaton = true,
            BeginningStack = 100,
            Id = Guid.NewGuid()
        }).GetAwaiter().GetResult();

        _playerTwo = playerFactory.CreateAsync(new PlayerCreateRequest
        {
            Automaton = true,
            BeginningStack = 100,
            Id = Guid.NewGuid()
        }).GetAwaiter().GetResult();

        _playerThree = playerFactory.CreateAsync(new PlayerCreateRequest
        {
            Automaton = true,
            BeginningStack = 100,
            Id = Guid.NewGuid()
        }).GetAwaiter().GetResult();
    }

    [Fact]
    public void Evaluate_WinnerIdentified_OnePlayerHasPairOfTwos()
    {
        // Arrange
        _playerOne = _playerOne with { Cards = [Cards.TwoOfSpades, Cards.TwoOfHearts] };
        _playerTwo = _playerTwo with { Cards = [Cards.TwoOfSpades, Cards.ThreeOfSpades] };
        _playerThree = _playerThree with { Cards = [Cards.TwoOfSpades, Cards.ThreeOfSpades] };

        EvaluateWinnerRequest request = new()
        {
            Players =
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
        response.Winners.Should().BeEquivalentTo(new List<Player> { _playerOne });
        response.WinningHand.Should().Be(Pairs.Twos);
    }

    [Fact]
    public void Evaluate_WinnersIdentified_TwoPlayersHavePairOfTwos()
    {
        // Arrange
        _playerOne = _playerOne with { Cards = [Cards.TwoOfSpades, Cards.TwoOfHearts] };
        _playerTwo = _playerTwo with { Cards = [Cards.TwoOfClubs, Cards.TwoOfDiamonds] };
        _playerThree = _playerThree with { Cards = [Cards.FiveOfSpades, Cards.ThreeOfSpades] };

        EvaluateWinnerRequest request = new()
        {
            Players =
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
        response.Winners.Should().BeEquivalentTo(new List<Player> { _playerOne, _playerTwo });
        response.WinningHand.Should().Be(Pairs.Twos);
    }

    [Fact]
    public void Evaluate_WinnerIdentified_TwoPlayersHavePairOfTwosButOneHasHigherKicker()
    {
        // Arrange
        _playerOne = _playerOne with { Cards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.AceOfClubs] };
        _playerTwo = _playerTwo with { Cards = [Cards.TwoOfClubs, Cards.TwoOfDiamonds, Cards.KingOfClubs] };
        _playerThree = _playerThree with { Cards = [Cards.FiveOfSpades, Cards.ThreeOfSpades, Cards.NineOfSpades] };

        EvaluateWinnerRequest request = new()
        {
            Players =
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
        response.Winners.Should().BeEquivalentTo(new List<Player> { _playerOne });
        response.WinningHand.Should().Be(Pairs.Twos);
    }
}
