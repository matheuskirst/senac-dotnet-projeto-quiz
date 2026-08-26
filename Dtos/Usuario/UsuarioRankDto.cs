namespace SenacQuizApp.Dtos.Usuario
{
    public class UsuarioRankDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = null!;
        public int PontuacaoTotal { get; set; }
        public string Nivel { get; set; } = null!;
        public int TotalAcertos { get; set; }
        public int TotalRespondidos { get; set; }
        public int MaxAcertosConsecutivos { get; set; }
    }
}
