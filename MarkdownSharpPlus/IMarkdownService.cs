using Data;

namespace MarkdownSharpPlus.Transformers
{
    public interface IMarkdownService
    {
		MarkdownPage GetPage(string docId);

    	string ToHtml(string markdown);
    }
}