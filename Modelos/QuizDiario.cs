using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos.Usuarios;
using SenacQuizApp.Modelos.Questoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class QuizDiario
    {
        public int Id { get; set; }

        public int UsuarioId {  get; set; }
        public Usuario Usuario { get; set; } = null!;

        public DateTimeOffset DataInicio { get; set; } = DateTimeOffset.UtcNow;
        public DateOnly DataExibido { get; set; } = DateOnly.FromDateTime(ObterHora.ObterHoraBrasilia());
        public bool FoiConcluido { get; set; } = false;
        public DateTimeOffset? DataConcluido { get; set; }
        public TimeSpan? TempoDeConclusao { get; set; }
        public int PontuacaoTotal { get; set; } = 0;

        public ICollection<Questao> Questoes { get; set; } = new List<Questao>();
        public ICollection<UsuarioResposta> UsuarioRespostas { get; set; } = new List<UsuarioResposta>();

        public void Concluir()
        {
            if (FoiConcluido) throw new InvalidOperationException("Esse quiz já foi concluido");

            FoiConcluido = true;
            DataConcluido = DateTimeOffset.UtcNow;
            TempoDeConclusao = DataConcluido - DataInicio;
        }
    }
}
