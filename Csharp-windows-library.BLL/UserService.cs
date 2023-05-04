using Csharp_windows_library.Models;
using Csharp_windows_library.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_windows_library.BLL
{
    public class UserService
    {
        public bool VerifyUser(User user)
        {
            UserRepository instance = new UserRepository();

            return (instance.GetUsers().FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password) != null) ;
        }
    }
}
