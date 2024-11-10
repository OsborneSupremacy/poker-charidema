namespace Poker.Presentation.Library;

public class InputOption<T> : IInputOption<T>
{
    public required string Name { get; init; }

    public required Func<T> GetValue { get; init; }

    public InputOption(string name, Func<T> getValue)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        GetValue = getValue ?? throw new ArgumentNullException(nameof(getValue));
    }
}
