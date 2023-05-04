using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_windows_library.PL
{
    public partial class Menu : Form
    {
        private string _username;
        private string _password;
        public Menu(string username, string password)
        {
            _password = password;
            _username = username;

            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
