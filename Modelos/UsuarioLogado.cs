using SenacQuizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class UsuarioLogado
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        public DateTime? DataDeNascimento { get; set; }
        public DateTime? DataDeCadastro { get; set; }
        public NivelUsuario Nivel { get; set; } = null!;
        public int PontuacaoTotal { get; set; }
        public int TotalAcertos { get; set; }
        public int TotalRespondidos { get; set; }
        public int AcertosConsecutivos { get; set; }
        public int MaxAcertosConsecutivos { get; set; }
    }
}
