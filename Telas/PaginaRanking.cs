using System.ComponentModel;
using SenacQuizApp.Modelos;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Services;

namespace SenacQuizApp.Telas
{
    public partial class PaginaRanking : UserControl
    {
        private readonly RankingService _rankingService;
        private BindingList<UsuarioRankDto> _rankingList = [];

        public event Action<int>? AbrirPerfil;

        public PaginaRanking(RankingService rankingService)
        {
            _rankingService = rankingService;

            InitializeComponent();
        }

        private async void PaginaRanking_Load(object sender, EventArgs e)
        {
            TableUsuariosRank.DataSource = _rankingList;

            await AtualizarTabelaRanks();
        }

        private async Task AtualizarTabelaRanks()
        {
            TableUsuariosRank.PauseLayout = true;
            try
            {
                _rankingList.Clear();

                List<UsuarioRankDto> usuarios = await _rankingService.ObterUsuariosRank();
                foreach(UsuarioRankDto usuario in usuarios)
                {
                    _rankingList.Add(usuario);
                }

            }
            finally
            {
                TableUsuariosRank.PauseLayout = false;
                TableUsuariosRank.Refresh();
            }
        }
    }
}
