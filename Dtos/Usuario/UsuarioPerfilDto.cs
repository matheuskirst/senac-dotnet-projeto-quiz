using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Dtos.Usuario
{
    public class UsuarioPerfilDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = null!;
        public DateTimeOffset DataDeCadastro { get; set; }
        public UsuarioNivelId NivelId { get; set; }
        public string Nivel { get; set; } = null!;
        public int PontuacaoTotal { get; set; }
        public int TotalAcertos { get; set; }
        public int TotalRespondidos { get; set; }
        public int AtualAcertosSeguidos { get; set; }
        public int MaxAcertosSeguidos { get; set; }
        public string TemaMaisAcertado { get; set; } = null!;
        public int QuantidadeTemaMaisAcertado { get; set; }
        public List<ConquistaDto> Conquistas { get; set; } = null!;
    }
}
