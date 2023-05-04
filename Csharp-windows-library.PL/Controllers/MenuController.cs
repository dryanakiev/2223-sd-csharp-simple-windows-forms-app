using Csharp_windows_library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_windows_library.PL.Controllers
{
    public class MenuController
    {
        public Menu menu;
        User user;
        string username;
        string password;

        public MenuController() 
        {
            menu = new Menu(username, password);
        }

        public void Pass(string x, string y)
        {
            username = x; 
            password = y;
        }
    }
}
