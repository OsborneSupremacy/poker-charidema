namespace Poker.Domain.Implementations.Moves;

public record Bet : IWageringMove
{
    public string ImperativeName => "Bet";

    public string DescriptiveName => "bets {amount}";
}
