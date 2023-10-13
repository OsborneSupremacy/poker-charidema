using Poker.Domain.Extensions;

namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class StraightTests
{
    [Fact]
    public void Qualify_True_When_Straight_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.Straight, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
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
    public void Qualify_True_When_Straight_Exists_With_One_WildCard()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.Straight, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfHearts,
                        Cards.JackOfClubs,
                        Cards.TenOfDiamonds
                    }
                );
                x.WithJokerFor(Cards.AceOfSpades);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_True_When_Straight_Exists_With_Two_WildCards()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.Straight, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.KingOfSpades,
                        Cards.QueenOfHearts,
                        Cards.JackOfClubs
                    }
                );
                x.WithJokerFor(Cards.TenOfSpades);
                x.WithJokerFor(Cards.AceOfSpades);
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
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.Straight, HandQualifications.Eliminated)
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
            })
            .ExpectedNeededCards(
                Cards.All
                    .WhereRank(Ranks.Nine)
                    .Concat(
                        Cards.All.WhereRank(Ranks.Ace)
                    )
                .ToList()
            );

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
