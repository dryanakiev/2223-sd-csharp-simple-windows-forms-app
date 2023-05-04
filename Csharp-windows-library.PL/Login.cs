using Csharp_windows_library.PL.Controllers;

namespace Csharp_windows_library.PL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        LoginController controller = new LoginController();
        MenuController menu = new MenuController();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = TextBoxPassword.Text;

            if (controller.Login(username, password))
            {
                menu.Pass(username, password);

                this.Close();
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}