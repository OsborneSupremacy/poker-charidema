﻿using Poker.Domain.Extensions;

namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FullHouseTests
{
    [Fact]
    public void Qualify_True_When_FullHouse_Exist()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.FullHouse, HandQualifications.Qualifies)
            .ExpectedContributing(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.TwoOfHearts,
                        Cards.TwoOfDiamonds,
                        Cards.TwoOfSpades,
                        Cards.FourOfDiamonds,
                        Cards.FourOfHearts
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_No_FullHouse_Exists()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.FullHouse, HandQualifications.Eliminated)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.TwoOfHearts,
                        Cards.TwoOfDiamonds,
                        Cards.TwoOfSpades,
                        Cards.FourOfDiamonds,
                        Cards.FiveOfDiamonds
                    }
                );
            })
            .ExpectedNeededCards(
                Cards.FourOfSpades,
                Cards.FourOfClubs,
                Cards.FourOfHearts,
                Cards.FiveOfSpades,
                Cards.FiveOfClubs,
                Cards.FiveOfHearts
            );

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_False_When_No_ThreeOfAKind_Or_Pair_Exists()
    {
        var fixture = new HandQualifierTestFixture()
            .For(HandDefinitions.FullHouse, HandQualifications.Eliminated)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.TwoOfHearts,
                        Cards.TwoOfDiamonds,
                        Cards.ThreeOfClubs,
                        Cards.FourOfDiamonds,
                        Cards.FiveOfDiamonds
                    }
                );
             })
            .ExpectedNeededCards(
                Cards.TwoOfClubs,
                Cards.TwoOfSpades,
                Cards.ThreeOfSpades,
                Cards.ThreeOfHearts,
                Cards.ThreeOfDiamonds,
                Cards.FourOfClubs,
                Cards.FourOfSpades,
                Cards.FourOfHearts,
                Cards.FiveOfClubs,
                Cards.FiveOfSpades,
                Cards.FiveOfHearts
            );

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
