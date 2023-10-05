﻿namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FiveOfAKindTests
{
    [Fact]
    public void Qualify_True_When_Hand_Contains_Five_Of_A_Kind_With_One_Joker()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.FiveOfAKind)
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
                x.WithJoker(Cards.AceOfSpades);
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
            .For(Hands.FiveOfAKind)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.AceOfDiamonds,
                        Cards.AceOfSpades
                    }
                );
                x.WithJoker(Cards.AceOfSpades);
                x.WithJoker(Cards.AceOfClubs);
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
            .For(Hands.FiveOfAKind)
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
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}

