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
    public class UsuarioService
    {
        public event Action<string>? ErroAoCadastrar;
        public event EventHandler? UsuarioCadastrado;

        public static void ValidarNickname(string nickname, List<ValidationResult> listaDeErros)
        {

        }

        public static void ValidarSenha(string senha, List<ValidationResult> listaDeErros)
        {
            if (!string.IsNullOrEmpty(senha))
            {
                int tamanhoSenha = senha.Length;

                if (tamanhoSenha < 6 || tamanhoSenha > 30)
                {
                    listaDeErros.Add(new ValidationResult("A senha deve ter entre 6 e 30 caracteres!"));
                }

                if (!SenhaAtendeRequisitos(senha))
                {
                    listaDeErros.Add(new ValidationResult(
                        "A senha deve ter pelo menos 1 letra maiúscula, 1 letra minúscula, 1 caractere especial e 1 número!"
                    ));
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

        public async Task<bool> TentarSignup(
            string nome,
            string nickname,
            DateTime dataDeNascimento,
            string senha
            )
        {
            var stringBuilder = new StringBuilder();
            var listaDeErros = new List<ValidationResult>();

            ValidarSenha(senha, listaDeErros);

            string senhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(senha);

            var usuario = new Usuario
            {
                Nome = nome,
                Nickname = nickname,
                DataDeNascimento = dataDeNascimento,
                Senha = senhaHash
            };

            if (listaDeErros.Count > 0)
            {
                foreach (var erro in listaDeErros)
                {
                    stringBuilder.Append(erro.ErrorMessage + "\n");
                }
                string mensagemErro = stringBuilder.ToString();
                ErroAoCadastrar?.Invoke(mensagemErro);
                return false;
            }
            else
            {
                try
                {
                    await UsuarioRepository.RegistrarUsuario(usuario);
                    UsuarioCadastrado?.Invoke(this, EventArgs.Empty);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
