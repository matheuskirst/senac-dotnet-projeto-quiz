using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Usuarios;

namespace SenacQuizApp.Modelos
{
    public class RushHistorico
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }
        public Usuario Usuario { get; set; } = null!;

        public int RecordeAntigo { get; set; }
        public int RecordeNovo { get; set; }

        public DateTimeOffset DataRecordeBatido { get; set; } = DateTimeOffset.UtcNow;
    }
}
