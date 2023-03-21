namespace Poker.Interface;

public interface IUiService
{
    Task<Player> PromptForInitialButton(List<Player> players);

    Task<bool> PromptToPlayAgainAsync(int countOfGamesPlayed);

    Task<double> PromptForAnteAmount(Player button);
}
