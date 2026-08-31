using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public class ConquistaDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTimeOffset DataAquisicao { get; set; }
    }
}
