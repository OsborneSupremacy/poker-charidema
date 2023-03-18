namespace Poker.Service;

public class ConsoleUiService : IUiService
{
    public Task<bool> PromptToPlayAgainAsync(int countOfGamesPlayed)
    {
        if(countOfGamesPlayed == 0)
            return Task.FromResult(true);
        return Task.FromResult(true);
    }
}
