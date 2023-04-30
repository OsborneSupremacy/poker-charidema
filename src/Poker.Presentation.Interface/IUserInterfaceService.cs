namespace Poker.Presentation.Interface;

public interface IUserInterfaceService
{
    IUserInterfaceService PromptForOption<T>(
        string prompt,
        Action<T> onValidInput,
        params IInputOption<T>[] options);

    IInputOption<T> PromptForOption<T>(
        string prompt,
        params IInputOption<T>[] options
        );

    IUserInterfaceService PromptForString(
        string prompt,
        uint minLength,
        Action<string> onValidInput
        );

    IUserInterfaceService PromptForInt(
        string prompt,
        int minVal,
        int maxVal,
        Action<int> onValidInput
        );

    IUserInterfaceService PromptForMoney(
        string prompt,
        int minVal,
        int maxVal,
        Action<int> onValidInput
        );

    IUserInterfaceService PromptForBool(
        string prompt,
        Action<bool> onValidInput
        );

    bool PromptForBool(string prompt);

    IUserInterfaceService WriteHeading(uint level, string input);

    IUserInterfaceService WriteList(string heading, params string[] items);

    IUserInterfaceService Write(string input);

    IUserInterfaceService WriteLine(string input);

    IUserInterfaceService WriteLine();

    IUserInterfaceService WriteLines(params string[] lines);
}
