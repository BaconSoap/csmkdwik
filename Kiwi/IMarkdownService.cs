namespace Kiwi.Markdown
{
    public interface IMarkdownService
    {
		IMarkdownPage GetPage(string docId);

    	string ToHtml(string markdown);
    }
}