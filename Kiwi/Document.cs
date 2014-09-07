using System;

namespace MarkdownSharpPlus.Markdown
{
    [Serializable]
    public class Document
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}