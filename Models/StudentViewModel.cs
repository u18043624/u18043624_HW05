using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18043624_HW05.Models
{
	public class StudentViewModel
	{
		public int studentID { get; set; }
		public string name { get; set; }
		public string surname { get; set; }
		public string birthdate { get; set; } // put in correct format
		public string gender { get; set; }
		public string studentClass { get; set; }
		public int point { get; set; }
	}
}