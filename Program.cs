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
            AutenticacaoService usuarioService = new();
            QuizDiarioService quizDiarioService = new();
            UsuarioService usuarioPerfilService = new();
            RankingService rankingService = new();
            HistoricoService historicoService = new();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AntdUI.Localization.Provider = new AntdUIBrLocalizer();
            AntdUI.Localization.SetLanguage("pt-BR");

            Application.Run(new FormApp(usuarioService, quizDiarioService, usuarioPerfilService, rankingService, historicoService));
        }
    }
}
