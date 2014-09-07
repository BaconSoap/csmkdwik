namespace MarkdownSharpPlus.Transformers
{
    public interface IMarkdownService
    {
		IMarkdownPage GetPage(string docId);

    	string ToHtml(string markdown);
    }
}