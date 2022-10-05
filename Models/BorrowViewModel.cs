using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18043624_HW05.Models
{
	public class BorrowViewModel
	{
		public int borrowID { get; set; }
		public string takenDate { get; set; }
		public string broughtDate { get; set; }
		public StudentViewModel student { get; set; }

		public BorrowViewModel()
		{
			StudentViewModel student = new StudentViewModel();
		}
	}
}