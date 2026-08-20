using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Dtos
{
    public class UsuarioPerfilDto
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public DateTime? DataDeNascimento { get; set; }
        public DateTime? DataDeCadastro { get; set; }
        public UsuarioNivel Nivel { get; set; }
        public int PontuacaoTotal { get; set; }
        public int TotalAcertos { get; set; }
        public int TotalRespondidos { get; set; }
        public int AtualAcertosConsecutivos { get; set; }
        public int MaxAcertosConsecutivos { get; set; }
        public PerguntaTema TemaMaisAcertado { get; set; } = null!;
        public int TemaMaisAcertadoQuantidade { get; set; }
    }
}
