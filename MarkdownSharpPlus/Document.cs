using System;

namespace MarkdownSharpPlus.Transformers
{
    [Serializable]
    public class Document
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}