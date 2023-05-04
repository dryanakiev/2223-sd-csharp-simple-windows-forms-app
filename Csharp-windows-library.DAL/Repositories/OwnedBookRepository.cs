using Csharp_windows_library.DAL.Data;
using Csharp_windows_library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_windows_library.DAL.Repositories
{
    public class OwnedBookRepository
    {
        WindowsLibraryContext context = new WindowsLibraryContext();

        public List<Book> GetAllBooksOwnedByUser(User user)
        {
            List<Book> books = new List<Book>();

            BookRepository bookRepository = new BookRepository();

            var ownedBooks = context.OwnedBooks.Where(x=>x.UserId == user.Id).ToList();

            foreach(var book in ownedBooks)
            {
                books.Add(bookRepository.GetBookById(book.BookId));
            }

            return books;
        }

        public List<User> GetAllUsersByOwnedBook(Book book)
        {
            List<User> users = new List<User>();

            UserRepository userRepository = new UserRepository();

            var owners = context.OwnedBooks.Where(x=>x.BookId == book.Id).ToList();

            foreach(var user in owners)
            {
                users.Add(userRepository.GetUserById(user.UserId));
            }

            return users;
        }
    }
}
