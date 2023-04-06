﻿namespace Poker.Terminal.Service;

public class FluentConsole
{
    public FluentConsole WriteLines(params string[] messages)
    {
        foreach(var message in messages)
            Console.WriteLine(message);
        return this;
    }

    public FluentConsole Write(string message)
    {
        Console.Write(message);
        return this;
    }

    public FluentConsole WriteLine(string message)
    {
        Console.WriteLine(message);
        return this;
    }

    public FluentConsole WriteLine()
    {
        Console.WriteLine();
        return this;
    }

    public string PromptForString(
        string prompt,
        uint minLength
        )
    {
        var result = string.Empty;
        while ((result?.Length ?? 0) < minLength)
        {
            Console.Write($"{prompt}: ");
            result = Console.ReadLine()?.Trim() ?? string.Empty;
        }
        return result!;
    }

    public FluentConsole PromptForString(
        string prompt,
        uint minLength,
        Action<string> onValidInput
        )
    {
        var result = PromptForString(prompt, minLength);
        onValidInput(result!);
        return this;
    }

    public int PromptForInt(
        string prompt,
        int minVal,
        int maxVal
        )
    {
        var result = minVal - 1;
        while (result < minVal || result > maxVal)
        {
            Console.Write($"{prompt} {minVal}-{maxVal}: ");
            _ = int.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }

    public FluentConsole PromptForInt(
        string prompt,
        int minVal,
        int maxVal,
        Action<int> onValidInput
        )
    {
        var result = PromptForInt(prompt, minVal, maxVal);
        onValidInput(result!);
        return this;
    }

    public int PromptForMoney(
        string prompt,
        int minVal,
        int maxVal
        )
    {
        var result = minVal - 1;
        while (result < minVal || result > maxVal)
        {
            Console.Write($"{prompt} {minVal:C} - {maxVal:C}: ");
            _ = int.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }

    public FluentConsole PromptForMoney(
        string prompt,
        int minVal,
        int maxVal,
        Action<int> onValidInput
        )
    {
        var result = PromptForMoney(prompt, minVal, maxVal);
        onValidInput(result!);
        return this;
    }

    public bool PromptForBool(string prompt)
    {
        bool? result = null;
        while (!result.HasValue)
        {
            Console.Write($"{prompt} (1, Y = Yes, 0, 2, N = No): ");
            result = Console.ReadKey().Key switch
            {
                ConsoleKey.D1 or ConsoleKey.Y => true,
                ConsoleKey.D0 or ConsoleKey.D2 or ConsoleKey.N => false,
                _ => null
            };
            Console.WriteLine();
        }
        return result.Value;
    }

    public FluentConsole PromptForBool(
        string prompt,
        Action<bool> onValidInput
        )
    {
        var result = PromptForBool(prompt);
        onValidInput(result!);
        return this;
    }

    public InputOption<T> PromptForOption<T>(string prompt, params InputOption<T>[] options)
    {
        InputOption<T>? selectedOption = null;

        while (selectedOption is null)
        {
            Console.WriteLine($"{prompt}");

            uint i = 0;
            foreach (var option in options)
                Console.WriteLine($"[{++i}] {option.Name}");

            if (uint.TryParse(Console.ReadKey().KeyChar.ToString(), out var optionId))
                selectedOption = options[optionId - 1];

            Console.WriteLine();
        }

        return selectedOption;
    }

    public FluentConsole PromptForOption<T>(
        string prompt,
        Action<T> onValidInput,
        params InputOption<T>[] options)
    {
        var result = PromptForOption(prompt, options);
        onValidInput(result.GetValue());
        return this;
    }
}

public class InputOption<T>
{
    public string Name { get; set; }

    public Func<T> GetValue { get; set; }

    public InputOption(string name, Func<T> getValue)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        GetValue = getValue ?? throw new ArgumentNullException(nameof(getValue));
    }
}
