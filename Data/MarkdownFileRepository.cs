using System;

namespace Data
{
	public class MarkdownFileRepository: IMarkdownRepository
	{
		public MarkdownFileRepository()
		{
		}
			
		public string GetMarkdownDocument(string path)
		{
			return @"
###[Hello](hello)

This is a markdown document. It was compiled by MarkdownSharp and Kiwi, and has support for fenced code blocks, like this:
```c#
var a = ""hello"";
var b = (string text) => ""hello "" + text;
Console.WriteLine(b(a));
```


Markdown Wiki Sharp is a project to enable writing a wiki in Markdown. Markdown is a much more natural syntax than standard MediaWiki syntax.

Right now it is C# app hosted in ASP.NET, but it can easily be converted to a command-line app, and thus into a packaged node-webkit app for a fake-native experience.

####TODO

- [ ] thing one
- [x] thing two
- [X] thing two

";
		}

	}
}

