using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class PerguntaRespondida
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
        public int PerguntaId { get; set; }
        public Pergunta? Pergunta { get; set; }
        public bool Acertou { get; set; }
        public decimal Bonus { get; set; }
        public int PontuacaoFinal { get; set; }
        public DateTime? DataDeResposta { get; set; } = DateTime.UtcNow;
    }
}
