using SenacQuizApp.banco.repositories;
using SenacQuizApp.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Services
{
    public class MensagemErroEventArgs : EventArgs
    {
        public bool OcorreuErro { get; set; } = false;
        public string? NomeErro { get; set; } = null;
        public string? NicknameErro { get; set; } = null;
        public string? DataNascimentoErro { get; set; } = null;
        public string? SenhaNulaErro { get; set; } = null;
        public string? SenhaTamanhoErro { get; set; } = null;
        public string? SenhaRequisitosErro { get; set; } = null;
        public string? SenhaConfirmarErro { get; set; } = null;
    }

    public class UsuarioService
    {
        public event EventHandler? UsuarioCadastrado;
        public event EventHandler<MensagemErroEventArgs>? MensagemErro;

        public static void ValidarSenha(string senha, string confirmarSenha, MensagemErroEventArgs mensagemErro)
        {
            if (!string.IsNullOrEmpty(senha) && !string.IsNullOrEmpty(confirmarSenha))
            {
                int tamanhoSenha = senha.Length;

                if (tamanhoSenha < 6 || tamanhoSenha > 30)
                {
                    mensagemErro.SenhaTamanhoErro = "A senha deve ter entre 6 e 30 caracteres!";
                }

                if (!SenhaAtendeRequisitos(senha))
                {
                    mensagemErro.SenhaRequisitosErro = "A senha deve ter pelo menos 1 letra maiúscula, 1 letra minúscula, 1 caractere especial e 1 número!";
                }

                if (senha != confirmarSenha)
                {
                    mensagemErro.SenhaConfirmarErro = "As senhas não são as mesmas!";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(senha))
                {
                    mensagemErro.SenhaNulaErro = "Digite uma senha.";
                }

                if (string.IsNullOrEmpty(confirmarSenha))
                {
                    mensagemErro.SenhaNulaErro = "Confirme a senha.";
                }
            }
        }

        public static bool SenhaAtendeRequisitos(string senha)
        {
            return senha.Any(char.IsUpper)
                && senha.Any(char.IsLower)
                && senha.Any(char.IsNumber)
                && senha.Any(ch => !char.IsLetterOrDigit(ch));

        }

        public async Task TentarSignup(
            string nome,
            string nickname,
            DateTime dataDeNascimento,
            string senha,
            string confirmarSenha
            )
        {
            var mensagemErro = new MensagemErroEventArgs();

            ValidarSenha(senha, confirmarSenha, mensagemErro);

            string senhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(senha);

            var usuario = new Usuario
            {
                Nome = nome,
                Nickname = nickname,
                DataDeNascimento = dataDeNascimento,
                Senha = senhaHash
            };

            if (mensagemErro.OcorreuErro)
            {
                MensagemErro?.Invoke(this, mensagemErro);
            }
            else
            {
                try
                {
                    await UsuarioRepository.RegistrarUsuario(usuario);
                    UsuarioCadastrado?.Invoke(this, EventArgs.Empty);
                }
                catch
                {

                }
            }
        }
    }
}
