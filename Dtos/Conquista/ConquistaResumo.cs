using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Conquista
{
    public class ConquistaResumo
    {
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public DateTimeOffset DataDesbloqueio { get; set; }
        public string? IconPath { get; set; }
    }
}
