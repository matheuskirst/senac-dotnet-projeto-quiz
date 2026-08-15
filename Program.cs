using AntdUI;
using SenacQuizApp.Features.Cadastro;
using SenacQuizApp.Features.Login;
using SenacQuizApp.Features.TelaPrincipal;

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
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AntdUI.Localization.Provider = new AntdUIBrLocalizer();
            AntdUI.Localization.SetLanguage("pt-BR");

            Application.Run(new FormPrincipal());
        }
    }
}
