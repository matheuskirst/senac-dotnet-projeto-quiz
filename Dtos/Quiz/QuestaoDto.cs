using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenacQuizApp.Enums;

namespace SenacQuizApp.Dtos.Quiz
{
    public class QuestaoDto
    {
        public int Id { get; set; }
        public string Enunciado { get; set; } = null!;
        public QuestaoTipoId Tipo { get; set; }
        public int Pontos { get; set; }
        public bool Respondida { get; set; }
        public List<AlternativaDto> Alternativas { get; set; } = null!;
    }
}
