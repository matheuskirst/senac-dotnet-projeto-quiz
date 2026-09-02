using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Dtos
{
    // Objeto para exibir questões em uma tentativa de quiz
    public class QuestaoExibicao
    {
        public int Id { get; set; }

        public int TemaId { get; set; }
        public string Tema { get; set; } = null!;

        public QuestaoNivelId NivelId { get; set; }
        public string Nivel { get; set; } = null!;

        public QuestaoTipo Tipo { get; set; }

        public string Enunciado { get; set; } = null!;
        public bool Respondida { get; set; }
        public bool? Acertou { get; set; }
        public int Pontos { get; set; }

        public List<AlternativaExibicao> Alternativas { get; set; } = null!;
    }
}
