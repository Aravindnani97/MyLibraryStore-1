using Microsoft.AspNetCore.Mvc;
using MyLibraryStore.Models;
using MyLibraryStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Controllers
{
    public class BooksController:Controller
    {
        private IBookRepository _bookRepos = null;
        

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books=_bookRepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
           var book= _bookRepos.GetBookById(id);
            return View(book);
        }

        [HttpGet]
       public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.AddBook(book);
            return RedirectToAction("Index", "Books");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }

        //[HttpPost]
        //public void EditBook(int id,
        //                     Book book)
        //{ 

        //    var copy = _dbContext.Books.SingleOrDefault(x => x.Id == id);
        //    copy.BookName = book.BookName;
        //    copy.Author = book.Author;
        //    copy.ISBN = book.ISBN;
        //    copy.PublishedDate = book.PublishedDate;
        //   // copy.Genre = book.Genre;
        //    _dbContext.SaveChanges();

        //}
    }
}
