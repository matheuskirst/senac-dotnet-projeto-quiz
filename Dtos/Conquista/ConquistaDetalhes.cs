using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Conquista
{
    public class ConquistaDetalhes
    {
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Desbloqueada { get; set; }
        public DateTimeOffset? DataDesbloqueio { get; set; }
        public double PorcentagemDesbloqueioGlobal { get; set; }
        public bool Secreta { get; set; }
        public string? IconPath { get; set; }
    }
}
