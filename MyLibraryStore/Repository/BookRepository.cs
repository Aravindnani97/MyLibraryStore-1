using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryStore.Data;
using MyLibraryStore.Models;

namespace MyLibraryStore.Repository
{
    public  class BookRepository : IBookRepository
    {
        public ApplicationDbContext _dbContext = null;
         public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public void AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

       

        public Book GetBookById(int id) => _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

       
    }
}
