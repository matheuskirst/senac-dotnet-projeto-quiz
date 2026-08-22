using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class UsuarioStatus
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public UsuarioNivel Nivel { get; set; } = UsuarioNivel.Iniciante;
        public int PontuacaoTotal { get; set; } = 0;
        public int TotalAcertos { get; set; } = 0;
        public int TotalRespondidos { get; set; } = 0;
        public int AtualAcertosConsecutivos { get; set; } = 0;
        public int MaxAcertosConsecutivos { get; set; } = 0;

        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

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
