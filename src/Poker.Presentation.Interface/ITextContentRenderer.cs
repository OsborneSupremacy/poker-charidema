namespace Poker.Presentation.Interface;

public interface ITextContentRenderer
{
    public Task<ITextContentRenderer> Render(ITextContent content);

    public Task<ITextContentRenderer> Render(IEnumerable<ITextContent> content);
}
