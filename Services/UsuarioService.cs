using SenacQuizApp.banco.repositories;
using SenacQuizApp.Entidades;
using SenacQuizApp.Services.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Services
{
    public class ResultadoAuth(bool ehSucesso, Usuario? usuario, MensagemErro? mensagemErro)
    {
        public bool EhSucesso { get; set; } = ehSucesso;
        public Usuario? Usuario { get; set; } = usuario;
        public MensagemErro? MensagemErro { get; set; } = mensagemErro;
    }

    public class UsuarioService
    {
        // Determina se o nome já está sendo usado
        public async Task<bool> VerificarNome(string nome)
        {
            var usuario = await UsuarioRepository.ObterPorNome(nome);
            return usuario != null;
        }

        // Login
        public async Task<ResultadoAuth> RealizarLogin(string nome, string senha)
        {
            try
            {
                Usuario? usuario = await UsuarioRepository.ObterPorNome(nome);
                string senhaSalva = usuario.Senha;
                bool ehSenhaValida = BCrypt.Net.BCrypt.EnhancedVerify(senha, senhaSalva);

                if (ehSenhaValida)
                {

                    ResultadoAuth resultado = new ResultadoAuth(ehSucesso:true, usuario:usuario, mensagemErro:null);
                    return resultado;
                }
                else
                {
                    ResultadoAuth resultado = new ResultadoAuth(ehSucesso: false, usuario: null, mensagemErro: MensagemErro.LoginInvalido);
                    return resultado;
                }
            }
            catch
            {
                ResultadoAuth resultado = new ResultadoAuth(ehSucesso: false, usuario: null, mensagemErro: MensagemErro.LoginInvalido);
                return resultado;
            }
        }

        // Signup
        public async Task<ResultadoAuth> RealizarSignup(
            string nome,
            string nickname,
            DateTime? dataDeNascimento,
            string senha
            )
        {
            bool nomeIndisponivel = await VerificarNome(nome);

            if (nomeIndisponivel)
            {
                ResultadoAuth resultado = new ResultadoAuth(ehSucesso: false, usuario: null, mensagemErro: MensagemErro.NomeIndisponivel);
                return resultado;
            }
            else
            {
                string senhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(senha);

                var usuario = new Usuario
                {
                    Nome = nome,
                    Nickname = nickname,
                    DataDeNascimento = dataDeNascimento,
                    Senha = senhaHash
                };

                await UsuarioRepository.RegistrarUsuario(usuario);
                ResultadoAuth resultado = await RealizarLogin(nome, senha);
                return resultado;
            }
        }
    }
}
