namespace Poker.Interface;

public interface IUiService
{
    Task<bool> PromptToPlayAgainAsync(int countOfGamesPlayed);
}
