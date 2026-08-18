using AntdUI;
using SenacQuizApp.banco.repositories;
using SenacQuizApp.Banco.Repositories;
using SenacQuizApp.Services;
using SenacQuizApp.Telas;

using SenacQuizApp.banco.config;

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
            QuizAppContexto contexto = new();

            UsuarioRepository usuarioRepository = new(contexto);
            QuizRepository quizRepository = new(contexto);
            PerguntaRepository perguntaRepository = new(contexto);

            UsuarioService usuarioService = new(usuarioRepository);
            QuizService quizService = new(quizRepository, perguntaRepository);
            PerguntaService perguntaService = new(perguntaRepository);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AntdUI.Localization.Provider = new AntdUIBrLocalizer();
            AntdUI.Localization.SetLanguage("pt-BR");

            Application.Run(new FormPrincipal(usuarioService, quizService, perguntaService));
        }
    }
}
