using AntdUI;
using SenacQuizApp.Repositories;
using SenacQuizApp.Services;
using SenacQuizApp.Telas;
using SenacQuizApp.Data;

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
            PerguntaRepository perguntaRepository = new(contexto);
            AlternativaRepository alternativaRepository = new(contexto);
            QuizRepository quizRepository = new(contexto);

            AutenticacaoService usuarioService = new(contexto, usuarioRepository);
            QuizExecucaoService quizService = new(contexto, quizRepository, perguntaRepository, alternativaRepository, usuarioRepository);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AntdUI.Localization.Provider = new AntdUIBrLocalizer();
            AntdUI.Localization.SetLanguage("pt-BR");

            Application.Run(new FormApp(usuarioService, quizService));
        }
    }
}
