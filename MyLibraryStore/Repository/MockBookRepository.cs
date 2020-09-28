using MyLibraryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyLibraryStore.Repository
{
    public class MockBookRepository:IBookRepository
    {
        public void AddBook(BookRepository book)
        {
            throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1,BookName="Wings Of Fire",Author="Apj Kalam",ISBN="I5749",PublishedDate=Convert.ToDateTime("10/04/2020")},
                 new Book{Id=2,BookName="World India",Author="Rufoson",ISBN="I9749",PublishedDate=Convert.ToDateTime("10/09/1998")},
                  new Book{Id=3,BookName="Two States",Author="Chethan Baghath",ISBN="I5749",PublishedDate=Convert.ToDateTime("09/08/2009")}
            };
        }
    }
}
