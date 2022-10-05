using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18043624_HW05.Models
{
	public class BookViewModel
	{
		public int bookID { get; set; }
		public string name { get; set; }
		public int pageCount { get; set; }
		public int point { get; set; }
		public AuthorViewModel author { get; set; }
		public TypeViewModel type { get; set; }

		public BookViewModel()
		{
			AuthorViewModel author = new AuthorViewModel();
			TypeViewModel type = new TypeViewModel();
		}
		
	}
}