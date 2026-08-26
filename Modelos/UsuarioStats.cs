using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class UsuarioStats
    {
        public int Id { get; set; }
        public UsuarioNivelId NivelId { get; set; } = UsuarioNivelId.Iniciante;
        public UsuarioNivel Nivel { get; set; } = null!;
        public int PontuacaoTotal { get; set; } = 0;
        public int TotalRespondidos { get; set; } = 0;
        public int TotalAcertos { get; set; } = 0;
        public int AtualAcertosConsecutivos { get; set; } = 0;
        public int MaxAcertosConsecutivos { get; set; } = 0;

        public Usuario Usuario { get; set; } = null!;

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

        public void AtualizarAcertos(bool acertou)
        {
            TotalRespondidos++;

            if (acertou)
            {
                TotalAcertos++;

                AtualAcertosConsecutivos++;
                if (AtualAcertosConsecutivos > MaxAcertosConsecutivos) { MaxAcertosConsecutivos = AtualAcertosConsecutivos; }
            }
            else
            {
                if (AtualAcertosConsecutivos > MaxAcertosConsecutivos) { MaxAcertosConsecutivos = AtualAcertosConsecutivos; }

                AtualAcertosConsecutivos = 0;
            }
        }
    }
}
