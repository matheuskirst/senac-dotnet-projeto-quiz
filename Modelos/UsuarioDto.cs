using SenacQuizApp.Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Modelos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nickname { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public DateTime? DataDeCadastro { get; set; } = DateTime.UtcNow;
        public NivelUsuario Nivel { get; set; }
        public int PontuacaoTotal { get; set; }
        public int TotalAcertos { get; set; }
        public int TotalRespondidos { get; set; }
        public int AcertosConsecutivos { get; set; }
        public int MaxAcertosConsecutivos { get; set; }
    }
}
