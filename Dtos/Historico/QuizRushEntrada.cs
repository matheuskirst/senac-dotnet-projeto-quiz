using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos.Historico
{
    // Objeto para exibir partidas de quizzes rush
    public class QuizRushEntrada : QuizGenerico
    {
        public RushMotivoEncerrado MotivoEncerrado { get; set; }
        public int Streak { get; set; }
        public string MotivoEncerradoDisplay => MotivoEncerrado == RushMotivoEncerrado.RespostaErrada ? "Resposta Errada" : "Tempo Esgotado";
    }
}
