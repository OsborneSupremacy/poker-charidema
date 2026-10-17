namespace Poker.Test.Utility;

/// <summary>
/// Discards all output. Prompts are not supported, since tests should not
/// depend on user input.
/// </summary>
public class TestUserInterfaceService : IUserInterfaceService
{
    public IUserInterfaceService PromptForOption<T>(
        string prompt,
        Action<T> onValidInput,
        params IInputOption<T>[] options
        ) =>
        throw new NotSupportedException();

    public IInputOption<T> PromptForOption<T>(
        string prompt,
        params IInputOption<T>[] options
        ) =>
        throw new NotSupportedException();

    public IReadOnlyList<Card> PromptForCards(string prompt, ParticipantHand hand) =>
        throw new NotSupportedException();

    public IUserInterfaceService PromptForString(
        string prompt,
        int minLength,
        string defaultVal,
        Action<string> onValidInput
        ) =>
        throw new NotSupportedException();

    public IUserInterfaceService PromptForInt(
        string prompt,
        int minVal,
        int maxVal,
        int defaultVal,
        Action<int> onValidInput
        ) =>
        throw new NotSupportedException();

    public IUserInterfaceService PromptForMoney(
        string prompt,
        int minVal,
        int maxVal,
        int defaultVal,
        Action<int> onValidInput
        ) =>
        throw new NotSupportedException();

    public IUserInterfaceService PromptForBool(
        string prompt,
        Action<bool> onValidInput
        ) =>
        throw new NotSupportedException();

    public bool PromptForBool(string prompt) =>
        throw new NotSupportedException();

    public IUserInterfaceService WriteHeading(HeadingLevel level, string input) => this;

    public IUserInterfaceService WriteList(string heading, IEnumerable<string> items) => this;

    public IUserInterfaceService WriteList(string heading, params string[] items) => this;

    public IUserInterfaceService Write(string input) => this;

    public IUserInterfaceService WriteLine(string input) => this;

    public IUserInterfaceService WriteLine() => this;

    public IUserInterfaceService WriteLines(params string[] lines) => this;

    public IUserInterfaceService RenderCards(string heading, ParticipantHand hand) => this;
}
