using Poker.Domain;

namespace Poker.Presentation.Interface;

public enum HeadingLevel
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six
}

public interface IUserInterfaceService
{
    IUserInterfaceService PromptForOption<T>(
        string prompt,
        Action<T> onValidInput,
        params IInputOption<T>[] options
        );

    IInputOption<T> PromptForOption<T>(
        string prompt,
        params IInputOption<T>[] options
        );

    IUserInterfaceService PromptForString(
        string prompt,
        int minLength,
        string defaultVal,
        Action<string> onValidInput
        );

    IUserInterfaceService PromptForInt(
        string prompt,
        int minVal,
        int maxVal,
        int defaultVal,
        Action<int> onValidInput
        );

    IUserInterfaceService PromptForMoney(
        string prompt,
        int minVal,
        int maxVal,
        int defaultVal,
        Action<int> onValidInput
        );

    IUserInterfaceService PromptForBool(
        string prompt,
        Action<bool> onValidInput
        );

    bool PromptForBool(string prompt);

    IUserInterfaceService WriteHeading(HeadingLevel level, string input);

    IUserInterfaceService WriteList(string heading, params string[] items);

    IUserInterfaceService Write(string input);

    IUserInterfaceService WriteLine(string input);

    IUserInterfaceService WriteLine();

    IUserInterfaceService WriteLines(params string[] lines);

    IUserInterfaceService RenderCards(List<Card> cards);
}
