using SenacQuizApp.Enums;

namespace SenacQuizApp.Dtos.Usuario
{
    public class UsuarioPerfilDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = null!;
        public DateTime? DataDeCadastro { get; set; }
        public UsuarioNivelId NivelId { get; set; }
        public string Nivel { get; set; } = null!;
        public int PontuacaoTotal { get; set; }
        public int TotalAcertos { get; set; }
        public int TotalRespondidos { get; set; }
        public int AtualAcertosConsecutivos { get; set; }
        public int MaxAcertosConsecutivos { get; set; }
    }
}
