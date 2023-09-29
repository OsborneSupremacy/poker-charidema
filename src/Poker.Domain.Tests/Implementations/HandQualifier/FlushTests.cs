﻿namespace Poker.Domain.Tests.Implementations.HandQualifier;

[ExcludeFromCodeCoverage]
public class FlushTests
{
    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Flush()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Flush)
            .ExpectedInHand(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.TenOfHearts,
                        Cards.FiveOfHearts,
                        Cards.ThreeOfHearts,
                        Cards.TwoOfHearts
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Flush_With_Joker()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Flush)
            .ExpectedInHand(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.TenOfHearts,
                        Cards.FiveOfHearts,
                        Cards.ThreeOfHearts,
                        Cards.CreateJoker() with { Impersonating = Cards.KingOfHearts }
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_Returns_True_When_Hand_Contains_Flush_With_Two_Jokers()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Flush)
            .ExpectedInHand(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.CreateJoker() with { Impersonating = Cards.QueenOfHearts },
                        Cards.FiveOfHearts,
                        Cards.ThreeOfHearts,
                        Cards.CreateJoker() with { Impersonating = Cards.KingOfHearts }
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }

    [Fact]
    public void Qualify_Returns_False_When_Hand_Does_Not_Contain_Flush()
    {
        // arrange
        var fixture = new HandQualifierTestFixture()
            .For(Hands.Flush)
            .ExpectedInDeadCards(x =>
            {
                x.With(
                    new List<Card>() {
                        Cards.AceOfHearts,
                        Cards.TenOfHearts,
                        Cards.FiveOfHearts,
                        Cards.ThreeOfHearts,
                        Cards.TwoOfDiamonds
                    }
                );
            });

        // act
        var result = fixture.Execute();

        // assert
        result.ShouldBeAsExpected();
    }
}
