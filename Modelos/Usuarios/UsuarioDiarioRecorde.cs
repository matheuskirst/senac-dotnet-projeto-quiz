using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos.Usuarios
{
    public class UsuarioDiarioRecorde
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public int TotalAcertosDiarios { get; set; } = 0;
        public int AtualAcertosSeguidos { get; set; } = 0;
        public int MaxAcertosSeguidos { get; set; } = 0;

        public int PontosDiarios { get; set; } = 0;

        public void AtualizarAcertos(int acertos, int pontosGanhos)
        {
            TotalAcertosDiarios += acertos;

            PontosDiarios += pontosGanhos;

            AtualAcertosSeguidos += acertos;
            if (AtualAcertosSeguidos > MaxAcertosSeguidos) { MaxAcertosSeguidos = AtualAcertosSeguidos; }
        }

        public void LimparAcertosSeguidos()
        {
            if (AtualAcertosSeguidos > MaxAcertosSeguidos) { MaxAcertosSeguidos = AtualAcertosSeguidos; }

            AtualAcertosSeguidos = 0;
        }
    }
}
