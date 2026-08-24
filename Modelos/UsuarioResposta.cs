using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class UsuarioResposta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; } = null!;
        public int QuestaoId { get; set; }
        public Questao Questao { get; set; } = null!;
        public bool Acertou { get; set; }
        public int PontuacaoFinal { get; set; } = 0;
        public DateTime? DataDeResposta { get; set; } = DateTime.UtcNow;
    }
}
