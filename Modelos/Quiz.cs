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
        public DateTime DataInicio { get; set; } = DateTime.UtcNow;
        public DateOnly DataExibido { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        public DateTime? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public bool IsConcluido { get; set; } = false;
        public int PontuacaoTotal { get; set; } = 0;

        public ICollection<Pergunta> Perguntas { get; set; } = new List<Pergunta>();
        public ICollection<UsuarioResposta> PerguntasRespondidas { get; set; } = new List<UsuarioResposta>();

        public void Concluir(int pontuacao)
        {
            if (IsConcluido) throw new InvalidOperationException("Esse quiz já foi concluido");

            IsConcluido = true;
            DataConcluido = DateTime.UtcNow;
            TempoDeConclusao = DataConcluido - DataInicio;

            PontuacaoTotal = pontuacao;
        }
    }
}
