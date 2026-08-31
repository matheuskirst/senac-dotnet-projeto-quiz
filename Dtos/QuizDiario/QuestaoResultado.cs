using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.QuizDiario
{
    // Questão com resposta correta para exibição do quiz diário concluído
    public class QuestaoResultado
    {
        public int Id { get; set; }

        public int TemaId { get; set; }
        public string Tema { get; set; } = null!;

        public QuestaoNivelId NivelId { get; set; }
        public string Nivel { get; set; } = null!;

        public QuestaoTipo Tipo { get; set; }

        public string Enunciado { get; set; } = null!;
        public int Pontos { get; set; }
        public bool Acertou { get; set; }

        public List<AlternativaCorreta> Alternativas { get; set; } = null!;
    }
}
