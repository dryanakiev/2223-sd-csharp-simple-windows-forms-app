using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_windows_library.BLL;
using Csharp_windows_library.Models;
using Csharp_windows_library.PL;

namespace Csharp_windows_library.PL.Controllers
{
    public class LoginController
    {
        UserService service = new UserService();
        public bool Login(string username, string password) 
        { 
            User user = new User() { Username = username, Password = password};



            return service.VerifyUser(user);
        }
    }
}
