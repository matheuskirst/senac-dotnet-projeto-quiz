using SenacQuizApp.Dtos.Conquista;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Dtos.Usuario
{
    // Objeto para exibir perfil do usuário
    public class UsuarioPerfil
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
        public TemaDestaque? TemaMaisAcertado { get; set; }
        public List<ConquistaDetalhes> Conquistas { get; set; } = null!;
    }
}
