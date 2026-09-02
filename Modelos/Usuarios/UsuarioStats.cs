using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class UsuarioStats
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public UsuarioNivelId NivelId { get; set; } = UsuarioNivelId.Iniciante;
        public UsuarioNivel Nivel { get; set; } = null!;

        public int PontuacaoTotal { get; set; } = 0;
        public int TotalRespondidos { get; set; } = 0;
        public int TotalAcertos { get; set; } = 0;
        public int AtualAcertosSeguidos { get; set; } = 0;
        public int MaxAcertosSeguidos { get; set; } = 0;

        public void AdicionarPontos(int pontos)
        {
            PontuacaoTotal += pontos;

            if (PontuacaoTotal <= 500)
            {
                NivelId = UsuarioNivelId.Iniciante;
            }
            else if (PontuacaoTotal <= 2000)
            {
                NivelId = UsuarioNivelId.Aprendiz;
            }
            else if (PontuacaoTotal <= 10000)
            {
                NivelId = UsuarioNivelId.Intermediario;
            }
            else
            {
                NivelId = UsuarioNivelId.Avancado;
            }
        }

        public void AtualizarAcertos(int acertos)
        {
            TotalRespondidos += acertos;

            TotalAcertos += acertos;

            AtualAcertosSeguidos += acertos;
            if (AtualAcertosSeguidos > MaxAcertosSeguidos) { MaxAcertosSeguidos = AtualAcertosSeguidos; }
        }

        public void LimparAcertosSeguidos()
        {
            TotalRespondidos++;

            if (AtualAcertosSeguidos > MaxAcertosSeguidos) { MaxAcertosSeguidos = AtualAcertosSeguidos; }

            AtualAcertosSeguidos = 0;
        }
    }
}
