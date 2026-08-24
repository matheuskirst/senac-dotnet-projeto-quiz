using SenacQuizApp.Global;
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
        public DateOnly DataExibido { get; set; } = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());
        public bool IsConcluido { get; set; } = false;
        public DateTime? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int PontuacaoTotal { get; set; } = 0;

        public ICollection<Questao> Questoes { get; set; } = new List<Questao>();
        public ICollection<UsuarioResposta> UsuarioRespostas { get; set; } = new List<UsuarioResposta>();

        public void Concluir()
        {
            if (IsConcluido) throw new InvalidOperationException("Esse quiz já foi concluido");

            IsConcluido = true;
            DataConcluido = DateTime.UtcNow;
            TempoDeConclusao = DataConcluido - DataInicio;
        }
    }
}
