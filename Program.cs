using SenacQuizApp.Features.Login;
using SenacQuizApp.Forms;

namespace SenacQuizApp
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
            ModelLogin modelLogin = new ModelLogin();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLogin(modelLogin));
        }
    }
}