using System.ComponentModel;
using System.Windows.Forms;
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

            TableUsuariosRank.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(UsuarioRankDto.Nickname), "Usuário") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRankDto.PontuacaoTotal), "Pontuação") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRankDto.Nivel), "Nível") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRankDto.TotalAcertos), "Acertos") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRankDto.TotalRespondidos), "Respondidos") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRankDto.MaxAcertosConsecutivos), "Máx. Sequência") { SortOrder = true },
            };
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
                foreach (UsuarioRankDto usuario in usuarios)
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

        private void MostrarMenuUsuario(UsuarioRankDto usuario)
        {
            var menuItems = new AntdUI.IContextMenuStripItem[]
            {
                new AntdUI.ContextMenuStripItem("Abrir perfil"),
                new AntdUI.ContextMenuStripItemDivider(),
                new AntdUI.ContextMenuStripItem("Copiar nickname")
            };

            AntdUI.ContextMenuStrip.open(
                TableUsuariosRank,
                item =>
                {
                    switch (item.Text)
                    {
                        case "Abrir perfil":
                            AbrirPerfil?.Invoke(usuario.Id);
                            break;
                        case "Copiar nickname":
                            Clipboard.SetText(usuario.Nickname);
                            break;
                    }
                },
                menuItems
            );
        }

        private void TableUsuariosRank_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.Record is not UsuarioRankDto usuario) return;

            MostrarMenuUsuario(usuario);
        }

        private void TableUsuariosRank_CellDoubleClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Record is not UsuarioRankDto usuario) return;

            AbrirPerfil?.Invoke(usuario.Id);
        }
    }
}
