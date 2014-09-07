using System;
using System.Collections.Generic;

namespace Web
{
	public class PageDto
	{
		public string Title {get; set;}
		public string Contents { get; set;}
		public Dictionary<string, CheckboxDto> Checkboxes { get; set;}

		public PageDto()
		{
			Checkboxes = new Dictionary<string, CheckboxDto>();
		}
	}
}

