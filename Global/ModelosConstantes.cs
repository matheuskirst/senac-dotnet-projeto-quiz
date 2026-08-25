namespace SenacQuizApp.Global
{
    public static class ModelosConstantes
    {
        public static class Usuario
        {
            public const int MaxUsernameLength = 32;
            public const int MaxNicknameLength = 32;
            public const int MaxSenhaLength = 100;
        }

        public static class UsuarioNivel
        {
            public const int MaxNomeLength = 150;
        }

        public static class Questao
        {
            public const int MaxEnunciadoLength = 800;
        }

        public static class QuestaoTema
        {
            public const int MaxNomeLength = 150;
        }

        public static class QuestaoNivel
        {
            public const int MaxNomeLength = 150;
        }

        public static class QuestaoTipo
        {
            public const int MaxNomeLength = 150;
        }

        public static class Alternativa
        {
            public const int MaxTextoLength = 400;
        }

        public static class Conquista
        {
            public const int MaxNomeLength = 150;
            public const int MaxDescricaoLength = 500;
        }
    }
}
