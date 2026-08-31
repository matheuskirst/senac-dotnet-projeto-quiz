using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class UsuarioTemasProgresso
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int TemaId { get; set; }
        public QuestaoTema Tema { get; set; } = null!;
        public int RespostasCorretas { get; set; }
    }
}
