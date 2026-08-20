using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public DateTime? DataDeNascimento { get; set; }
        public string Senha { get; set; } = null!;
        public DateTime? DataDeCadastro { get; set; } = DateTime.UtcNow;
        public UsuarioNivel Nivel { get; set; } = UsuarioNivel.Iniciante;
        public int PontuacaoTotal { get; set; } = 0;
        public int TotalAcertos { get; set; } = 0;
        public int TotalRespondidos { get; set; } = 0;
        public int AtualAcertosConsecutivos { get; set; } = 0;
        public int MaxAcertosConsecutivos { get; set; } = 0;

        public ICollection<PerguntaRespondida> PerguntasRespondidas { get; set; } = new List<PerguntaRespondida>();
        public ICollection<UsuarioConquista> UsuarioConquistas { get; set; } = new List<UsuarioConquista>();

        public void AdicionarPontos(int pontos)
        {
            PontuacaoTotal += pontos;

            if (PontuacaoTotal <= 500)
            {
                Nivel = UsuarioNivel.Iniciante;
            }
            else if (PontuacaoTotal > 500)
            {
                Nivel = UsuarioNivel.Aprendiz;
            }
            else if (PontuacaoTotal > 2000)
            {
                Nivel = UsuarioNivel.Intermediario;
            }
            else if (PontuacaoTotal > 10000)
            {
                Nivel = UsuarioNivel.Avancado;
            }
        }

        public void AdicionarAcertos(int acertos)
        {
            AtualAcertosConsecutivos += acertos;

            if (AtualAcertosConsecutivos > MaxAcertosConsecutivos)
            {
                MaxAcertosConsecutivos = AtualAcertosConsecutivos;
            }
        }

        public void LimparAcertos()
        {
            if (AtualAcertosConsecutivos > MaxAcertosConsecutivos)
            {
                MaxAcertosConsecutivos = AtualAcertosConsecutivos;
            }

            AtualAcertosConsecutivos = 0;
        }
    }
}
