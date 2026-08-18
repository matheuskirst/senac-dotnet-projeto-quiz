using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class BuscarQuizResposta
    {
        public BuscarQuizResposta(QuizEncontrado? quiz, MensagemErro? mensagemErro=null)
        {
            Quiz = quiz;
            MensagemErro = mensagemErro;
            if (quiz != null && mensagemErro == null)
            {
                IsSucesso = true;
            }
        }

        public QuizEncontrado? Quiz { get; set; }
        public MensagemErro? MensagemErro { get; set; }
        public bool IsSucesso { get; private set; } = false;
    }
}
