using Poker.Library.Variants;

namespace Poker.Service;

public class ConsoleUiService : IUiService
{
    public Task<Player> PromptForInitialButton(List<Player> players)
    {
        return Task.FromResult(players[0]);
    }

    public Task<double> PromptForAnteAmount(Player button) => throw new NotImplementedException();

    public Task<bool> PromptToPlayAgainAsync(int countOfGamesPlayed)
    {
        if(countOfGamesPlayed == 0)
            return Task.FromResult(true);
        return Task.FromResult(true);
    }

    public Task<IVariant> PromptForVariant(Player button)
    {
        return Task.FromResult(new FiveCardDraw() as IVariant);
    }
}
