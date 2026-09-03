using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Modelos.Questoes;

namespace SenacQuizApp.Dtos.Ranking
{
    public class UsuarioRankGeral
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = null!;
        public int PontuacaoTotal { get; set; }
        public string Nivel { get; set; } = null!;
        public int TotalAcertos { get; set; }
        public int TotalRespondidos { get; set; }
        public TemaDestaque? TemaMaisAcertado { get; set; }

        public string TemaMaisAcertadoNome => TemaMaisAcertado?.Nome ?? "Nenhum";
        public int TemaMaisAcertadoAcertos => TemaMaisAcertado?.RespostasCorretas ?? 0;
    }
}
