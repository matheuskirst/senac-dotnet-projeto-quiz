using SenacQuizApp.Features.Cadastro;
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
            ModelCadastro modelCadastro = new ModelCadastro();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormCadastro(modelCadastro));
        }
    }
}