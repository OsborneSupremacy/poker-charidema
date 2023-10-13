using Poker.Domain.Extensions;

namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FiveOfAKindTests
{
    [Fact]
    public void Qualify_True_When_Hand_Contains_Five_Of_A_Kind_With_One_Joker()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.FiveOfAKind, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfClubs,
                        Cards.AceOfSpades
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
    public void Qualify_True_When_Hand_Contains_Five_Of_A_Kind_With_Two_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.FiveOfAKind, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfSpades
                    }
                );
                x.WithJokerFor(Cards.AceOfSpades);
                x.WithJokerFor(Cards.AceOfClubs);
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_Hand_Does_Not_Contain_Five_Of_A_Kind()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.FiveOfAKind, HandQualifications.Eliminated)
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
            })
            .ExpectedNeededCards(Cards.All.WhereRank(Ranks.Ace));

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}

