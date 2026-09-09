using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public class QuestaoDados
    {
        public int Id { get; set; }

        public QuestaoTipoId TipoId { get; set; }
        public string Tipo { get; set; } = string.Empty;

        public QuestaoNivelId NivelId { get; set; }
        public string Nivel { get; set; } = string.Empty;

        public int TemaId { get; set; }
        public string Tema { get; set; } = string.Empty;

        public string Enunciado { get; set; } = null!;
        public int Pontos { get; set; }

        public List<AlternativaResposta>? Alternativas { get; set; }
        public bool? VerdadeiroFalso { get; set; }
    }
}
