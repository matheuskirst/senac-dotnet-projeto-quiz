using SenacQuizApp.banco.repositories;
using SenacQuizApp.Banco.Entidades;
using SenacQuizApp.Modelos;
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
    public class ResultadoAuth(bool ehSucesso, UsuarioDto? usuario=null, MensagemErro? mensagemErro=null)
    {
        public bool EhSucesso { get; set; } = ehSucesso;
        public UsuarioDto? Usuario { get; set; } = usuario;
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
                    UsuarioDto? usuarioAtual = new UsuarioDto
                    {
                        Id = usuario.Id,
                        Nome = usuario.Nome,
                        Nickname = usuario.Nickname,
                        DataDeNascimento = usuario.DataDeNascimento,
                        DataDeCadastro = usuario.DataDeCadastro,
                        Nivel = usuario.Nivel,
                        PontuacaoTotal = usuario.PontuacaoTotal,
                        TotalAcertos = usuario.TotalAcertos,
                        TotalRespondidos = usuario.TotalRespondidos,
                        AcertosConsecutivos = usuario.AcertosConsecutivos,
                        MaxAcertosConsecutivos = usuario.MaxAcertosConsecutivos
                    };
                    ResultadoAuth resultado = new ResultadoAuth(ehSucesso:true, usuario:usuarioAtual);
                    return resultado;
                }
                else
                {
                    ResultadoAuth resultado = new ResultadoAuth(ehSucesso: false, mensagemErro: MensagemErro.LoginInvalido);
                    return resultado;
                }
            }
            catch
            {
                ResultadoAuth resultado = new ResultadoAuth(ehSucesso: false, mensagemErro: MensagemErro.LoginInvalido);
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
