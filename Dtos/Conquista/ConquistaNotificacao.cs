using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Conquista
{
    public class ConquistaNotificacao
    {
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string? IconPath { get; set; }
    }
}
