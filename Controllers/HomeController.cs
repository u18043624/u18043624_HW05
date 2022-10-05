using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using u18043624_HW05.Models;

namespace u18043624_HW05.Controllers
{
	
	public class HomeController : Controller
	{
		private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
		public ActionResult Books()
		{
			try
			{
				myConnection.Open();
				SqlCommand myCommand = new SqlCommand("Select books.bookId, books.name, books.pagecount, books.point, books.authorId, books.typeId", myConnection);
				SqlDataReader myReader = myCommand.ExecuteReader();
				Globals.bookList.Clear();

				while(myReader.Read()) //while there are still rows to read
				{
					BookViewModel book = new BookViewModel();
					book.bookID = (int)myReader["bookId"];
					book.name = myReader["name"].ToString();
					book.pageCount = (int)myReader["pagecount"];
					book.point = (int)myReader["point"];
					book.author.authorID = (int)myReader["authorId"];
					book.type.typeID = (int)myReader["typeId"];
					Globals.bookList.Add(book);
				}
			}
			catch (Exception)
			{
				//ViewBag.Message = err.Message;
				ViewBag.Status = 0;
			}
			finally
			{
				myConnection.Close();
			}


			return View();
		}

		public ActionResult BookDetails()
		{
			try
			{
				myConnection.Open();
				SqlCommand myCommand = new SqlCommand("Select borrows.bookId, borrows.takenDate, borrows.broughtDate, borrows.studentId", myConnection);
				SqlDataReader myReader = myCommand.ExecuteReader();
				Globals.borrowList.Clear();

				while (myReader.Read()) //while there are still rows to read
				{
					BorrowViewModel detail = new BorrowViewModel();
					detail.borrowID = (int)myReader["bookId"];
					detail.takenDate = myReader["takenDate"].ToString();
					detail.broughtDate = myReader["broughtDate"].ToString();
					detail.student.name = myReader["name"].ToString();
					Globals.borrowList.Add(detail);
				}
			}
			catch (Exception)
			{
				//ViewBag.Message = err.Message;
				ViewBag.Status = 0;
			}
			finally
			{
				myConnection.Close();
			}

			return View();
		}

		public ActionResult Students()
		{
			try
			{
				myConnection.Open();
				SqlCommand myCommand = new SqlCommand("Select students.studentId, students.name, students.surname, students.birthdate, students.authorId, students.typeId", myConnection);
				SqlDataReader myReader = myCommand.ExecuteReader();
				Globals.bookList.Clear();

				while (myReader.Read()) //while there are still rows to read
				{
					StudentViewModel student = new StudentViewModel();
					student.studentID = (int)myReader["bookId"];
					student.name = myReader["name"].ToString();
					student.surname = myReader["surname"].ToString();
					student.birthdate = myReader["birthdate"].ToString();
					student.gender = myReader["gender"].ToString();
					student.studentClass = myReader["studentClass"].ToString();
					student.point = (int)myReader["point"];
					Globals.studentList.Add(student);
				}
			}
			catch (Exception)
			{
				//ViewBag.Message = err.Message;
				ViewBag.Status = 0;
			}
			finally
			{
				myConnection.Close();
			}

			return View();
		}

		public ActionResult Search()
		{
			return View();
		}
		  
		public ActionResult Clear()
		{
			return View();
		}

	}
}