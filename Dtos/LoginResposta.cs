using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public class LoginResposta
    {
        public LoginResposta(MensagemErro? mensagemErro = null)
        {
            MensagemErro = mensagemErro;
            if (mensagemErro == null)
            {
                IsSucesso = true;
            }
        }

        public MensagemErro? MensagemErro { get; set; }
        public bool IsSucesso { get; private set; } = false;
    }
}
