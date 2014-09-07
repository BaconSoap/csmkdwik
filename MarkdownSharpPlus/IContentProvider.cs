namespace MarkdownSharpPlus.Transformers
{
	public interface IContentProvider
	{
		IMarkdownPage GetContent(string docId);
	}
}