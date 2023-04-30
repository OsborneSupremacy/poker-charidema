namespace Poker.Presentation.Interface;

public interface IInputOption<T>
{
    string Name { get; }

    Func<T> GetValue { get; }
}
