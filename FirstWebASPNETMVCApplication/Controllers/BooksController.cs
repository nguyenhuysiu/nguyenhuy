using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebASPNETMVCApplication.Models;

namespace FirstWebASPNETMVCApplication.Controllers
{
    public class BooksController : Controller
    {
        private List<Book> listBooks;
        /// <summary>
        /// ham khoi tao BooksController
        /// </summary>
        public BooksController()
        {
            listBooks = new List<Book>();
            //populate Sample Book Data
            listBooks.Add(new Book()
            {
                Id = 1,
                Title = "Sach 1",
                Author = "tac gia sach",
                PublicYear = 2017,
                Price = 40000,
                Cover ="content/Images/Book1.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "Sach 2",
                Author = "tac gia sach",
                PublicYear = 2018,
                Price = 50000,
                Cover = "content/Images/Book2.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Sach 3",
                Author = "tac gia sach",
                PublicYear = 2019,
                Price = 10000,
                Cover = "content/Images/Book3.jpg"
            });
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "List Books page";
            return View(listBooks);
        }
    }
}