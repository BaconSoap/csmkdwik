using Data;

namespace MarkdownSharpPlus.Transformers
{
	public interface IContentProvider
	{
		MarkdownPage GetContent(string docId);
	}
}