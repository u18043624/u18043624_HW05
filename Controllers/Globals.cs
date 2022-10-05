using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u18043624_HW05.Models;

namespace u18043624_HW05.Controllers
{
	public static class Globals
	{
		public static string ConnectionString = "Data Source=MSIROURKE\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True";
		public static List<BookViewModel> bookList = new List<BookViewModel>(); // data reloaded
		public static List<BorrowViewModel> borrowList = new List<BorrowViewModel>(); // data reloaded
		public static List<StudentViewModel> studentList = new List<StudentViewModel>(); // data reloaded
	}
}