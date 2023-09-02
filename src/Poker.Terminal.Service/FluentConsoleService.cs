using Poker.Presentation.Interface;
using Poker.Utility;
using Spectre.Console;

namespace Poker.Terminal.Service;

public class FluentConsoleService : IUserInterfaceService
{
    public IUserInterfaceService WriteLines(params string[] messages)
    {
        foreach (var message in messages)
            AnsiConsole.WriteLine(message);
        return this;
    }

    public IUserInterfaceService Write(string message)
    {
        AnsiConsole.Write(message);
        return this;
    }

    public IUserInterfaceService WriteLine(string message)
    {
        AnsiConsole.WriteLine(message);
        return this;
    }

    public IUserInterfaceService WriteLine()
    {
        AnsiConsole.WriteLine();
        return this;
    }

    public string PromptForString(string prompt, uint minLength)
    {
        var result = string.Empty;
        while ((result?.Length ?? 0) < minLength)
        {
            result = AnsiConsole.Prompt(
                new TextPrompt<string>($"{prompt}: ")
                    .Validate(input => input.Length >= minLength,
                        $"Input must be at least {minLength} characters long.")
                );
        }
        return result!;
    }

    public IUserInterfaceService PromptForString(
        string prompt,
        uint minLength,
        Action<string> onValidInput
        )
    {
        onValidInput(PromptForString(prompt, minLength)!);
        return this;
    }

    public int PromptForInt(string prompt, int minVal, int maxVal)
    {
        int result = minVal - 1;
        while (result < minVal || result > maxVal)
        {
            result = AnsiConsole.Prompt(
                new TextPrompt<int>($"{prompt} {minVal}-{maxVal}: ")
                    .Validate(input =>
                    {
                        if (input < minVal || input > maxVal)
                            return ValidationResult.Error($"Input must be between {minVal} and {maxVal}.");
                        return ValidationResult.Success();
                    })
                );
        }
        return result;
    }

    public IUserInterfaceService PromptForInt(
        string prompt,
        int minVal,
        int maxVal,
        Action<int> onValidInput
        )
    {
        onValidInput(PromptForInt(prompt, minVal, maxVal)!);
        return this;
    }

    public int PromptForMoney(string prompt, int minVal, int maxVal)
    {
        int result = minVal - 1;
        while (result < minVal || result > maxVal)
        {
            result = AnsiConsole.Prompt(
                new TextPrompt<int>($"{prompt} {minVal:C} - {maxVal:C}: ")
                    .Validate(input =>
                    {
                        if (input < minVal || input > maxVal)
                            return ValidationResult.Error($"Input must be between {minVal:C} and {maxVal:C}.");
                        return ValidationResult.Success();
                    })
                );
        }
        return result;
    }

    public IUserInterfaceService PromptForMoney(
        string prompt,
        int minVal,
        int maxVal,
        Action<int> onValidInput
        )
    {
        onValidInput(PromptForMoney(prompt, minVal, maxVal)!);
        return this;
    }

    public bool PromptForBool(string prompt) => AnsiConsole.Confirm(prompt);

    public IUserInterfaceService PromptForBool(
        string prompt,
        Action<bool> onValidInput
        )
    {
        onValidInput(PromptForBool(prompt)!);
        return this;
    }

    public IInputOption<T> PromptForOption<T>(string prompt, params IInputOption<T>[] options)
    {
        var optionChoices = options.Select(option => option.Name).ToArray();

        while (true)
        {
            var selectedOption = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .AddChoices(optionChoices)
                    .Title(prompt)
            );

            var index = Array.IndexOf(optionChoices, selectedOption);
            var option = options[index];

            if (AnsiConsole.Confirm($"Selected option: {option.Name}. Is this correct? (y/n)"))
                return option;
        }
    }

    public IUserInterfaceService PromptForOption<T>(
        string prompt,
        Action<T> onValidInput,
        params IInputOption<T>[] options
        )
    {
        onValidInput(PromptForOption(prompt, options).GetValue());
        return this;
    }

    public IUserInterfaceService WriteHeading(uint level, string input)
    {
        AnsiConsole.MarkupLine($"[bold]{'*'.Repeat(100)}[/]");
        AnsiConsole.MarkupLine($"[bold]{input}[/]");
        AnsiConsole.MarkupLine($"[bold]{'*'.Repeat(100)}[/]");
        AnsiConsole.WriteLine();
        return this;
    }

    public IUserInterfaceService WriteList(string heading, params string[] items)
    {
        foreach(var item in items)
            AnsiConsole.MarkupLine($"[bold]* {item}[/]");
        return this;
    }
}

public class InputOption<T> : IInputOption<T>
{
    public string Name { get; set; }

    public Func<T> GetValue { get; set; }

    public InputOption(string name, Func<T> getValue)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        GetValue = getValue ?? throw new ArgumentNullException(nameof(getValue));
    }
}
