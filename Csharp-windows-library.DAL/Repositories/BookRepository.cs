using Csharp_windows_library.DAL.Data;
using Csharp_windows_library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_windows_library.DAL.Repositories
{
    public class BookRepository
    {
        WindowsLibraryContext context = new WindowsLibraryContext();
        public List<Book> GetBooks()
        {
            return context.Books.ToList();
        }

        public Book GetBookById(int? id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }

        public Book GetBookByName(string name)
        {
            return context.Books.FirstOrDefault(x => x.BookName == name);
        }

        public void AddBook(Book book)
        {
            context.Books.Add(book);

            context.SaveChanges();
        }
    }
}
