using Csharp_windows_library.DAL.Data;
using Csharp_windows_library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_windows_library.DAL.Repositories
{
    public class UserRepository
    {
        WindowsLibraryContext context = new WindowsLibraryContext();
        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User GetUserById(int? id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);

            context.SaveChanges();
        }
    }
}
