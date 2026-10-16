namespace Poker.Test.Utility;

/// <summary>
/// Answers each "play another game?" prompt with the next scripted answer,
/// and counts the prompts it receives.
/// </summary>
public class TestGamePreferencesService : IGamePreferencesService
{
    private readonly Queue<bool> _playAgainAnswers;

    public TestGamePreferencesService(params bool[] playAgainAnswers)
    {
        _playAgainAnswers = playAgainAnswers.ToQueue();
    }

    public int PlayAgainPromptCount { get; private set; }

    public Task<int> GetAnte(Player button) => throw new NotSupportedException();

    public Task<Variant> GetVariant(Player button) => throw new NotSupportedException();

    public Task<Deck> GetDeck(Player button) => throw new NotSupportedException();

    public Task<bool> GetPlayAgain(CompletedGame game) => GetPlayAgain();

    public Task<bool> GetPlayAgain(string lastVariantName) => GetPlayAgain();

    private Task<bool> GetPlayAgain()
    {
        PlayAgainPromptCount++;
        return Task.FromResult(_playAgainAnswers.Dequeue());
    }
}
