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

        public QuestaoTipoId TipoId { get; set; }
        public string Tipo { get; set; } = string.Empty;

        public QuestaoNivelId NivelId { get; set; }
        public string Nivel { get; set; } = string.Empty;

        public int TemaId { get; set; }
        public string Tema { get; set; } = string.Empty;

        public string Enunciado { get; set; } = null!;
        public bool Respondida { get; set; }
        public bool? Acertou { get; set; }
        public int Pontos { get; set; }

        public List<AlternativaExibicao>? Alternativas { get; set; }
    }
}
