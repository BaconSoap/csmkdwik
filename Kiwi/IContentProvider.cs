namespace Kiwi.Markdown
{
	public interface IContentProvider
	{
		IMarkdownPage GetContent(string docId);
	}
}