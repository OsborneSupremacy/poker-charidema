namespace Poker.Domain.Implementations;

public record Bet : IWageringMove
{
    public string ImperativeName => "Bet";

    public string DescriptiveName => "bets {amount}";
}
