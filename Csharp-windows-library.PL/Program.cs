using Csharp_windows_library.PL.Controllers;

namespace Csharp_windows_library.PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();

            while (true)
            {
                Login login = new Login();
                Menu menu = new Menu();

                Application.Run(login);
                Application.Run(menu);
            }
        }
    }
}