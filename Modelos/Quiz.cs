using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Quiz
    {
        public int Id { get; set; }
        public int UsuarioId {  get; set; }
        public Usuario Usuario { get; set; } = null!;
        public DateTime DataDeCriacao { get; set; } = DateTime.UtcNow;
        public DateTime? DataDeConclusao { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public bool IsConcluido { get; set; } = false;
        public int PontuacaoTotal { get; set; } = 0;

        public ICollection<Pergunta> Perguntas { get; set; } = new List<Pergunta>();
        public ICollection<PerguntaRespondida> PerguntasRespondidas { get; set; } = new List<PerguntaRespondida>();

        public void Concluir(int pontuacao)
        {
            if (IsConcluido) throw new InvalidOperationException("Esse quiz já foi concluido");

            IsConcluido = true;
            DataDeConclusao = DateTime.UtcNow;
            TempoDeConclusao = DataDeConclusao - DataDeCriacao;

            PontuacaoTotal = pontuacao;
        }
    }
}
