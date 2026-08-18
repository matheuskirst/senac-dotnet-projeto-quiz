using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class LoginResposta
    {
        public LoginResposta(UsuarioLogado? usuario=null, MensagemErro? mensagemErro = null)
        {
            Usuario = usuario;
            MensagemErro = mensagemErro;
            if (usuario != null && mensagemErro == null)
            {
                IsSucesso = true;
            }
        }

        public UsuarioLogado? Usuario { get; set; }
        public MensagemErro? MensagemErro { get; set; }
        public bool IsSucesso { get; private set; } = false;
    }
}
