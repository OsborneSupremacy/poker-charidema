namespace Poker.Presentation.Interface;

public interface IInputOption<out T>
{
    string Name { get; }

    Func<T> GetValue { get; }
}
