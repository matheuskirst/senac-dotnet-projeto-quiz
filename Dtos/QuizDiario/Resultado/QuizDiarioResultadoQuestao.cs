using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.QuizDiario.Resultado
{
    public class QuizDiarioResultadoQuestao
    {
        public int Id { get; set; }
        public string Enunciado { get; set; } = null!;
        public int TemaId { get; set; }
        public string Tema { get; set; } = null!;
        public QuestaoNivelId NivelId { get; set; }
        public string Nivel { get; set; } = null!;
        public QuestaoTipoId TipoId { get; set; }
        public string Tipo { get; set; } = null!;
        public int Pontos { get; set; }
        public bool Acertou { get; set; }
        public List<QuizDiarioResultadoAlternativa> Alternativas { get; set; } = null!;
    }
}
