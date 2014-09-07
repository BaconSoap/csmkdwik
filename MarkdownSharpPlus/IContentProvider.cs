namespace MarkdownSharpPlus.Markdown
{
	public interface IContentProvider
	{
		IMarkdownPage GetContent(string docId);
	}
}