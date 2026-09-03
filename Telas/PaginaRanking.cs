using AntdUI;
using System.ComponentModel;
using SenacQuizApp.Services;
using SenacQuizApp.Enums;
using SenacQuizApp.Dtos.Usuario;

namespace SenacQuizApp.Telas
{
    public partial class PaginaRanking : UserControl
    {
        private readonly RankingService _rankingService;

        public event EventHandler<int>? AbrirPerfil;

        public PaginaRanking(RankingService rankingService)
        {
            _rankingService = rankingService;

            InitializeComponent();

            TableUsuariosRank.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(UsuarioRank.Nickname), "Usuário") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRank.PontuacaoTotal), "Pontuação") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRank.Nivel), "Nível") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRank.TotalAcertos), "Acertos") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRank.TotalRespondidos), "Respondidos") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRank.MaxAcertosConsecutivos), "Máx. Sequência") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRank.TemaMaisAcertadoNome), "Tema Mestre") { SortOrder = true },
                new AntdUI.Column(nameof(UsuarioRank.TemaMaisAcertadoAcertos), "Mestre Acertos") { SortOrder = true },
            };
        }

        private async void PaginaRanking_Load(object sender, EventArgs e)
        {
            await AtualizarTabelaRanks();
        }

        private async Task AtualizarTabelaRanks(string? nickname = null)
        {
            TableUsuariosRank.PauseLayout = true;
            try
            {
                TableUsuariosRank.DataSource = false;

                List<UsuarioRank> usuarios = await _rankingService.ObterUsuariosRank(nickname);
                if (usuarios == null) return;

                TableUsuariosRank.DataSource = usuarios;
            }
            finally
            {
                TableUsuariosRank.PauseLayout = false;
            }
        }

        private void MostrarMenuUsuario(UsuarioRank usuario)
        {
            var menuItems = new AntdUI.IContextMenuStripItem[]
            {
                new AntdUI.ContextMenuStripItem("Abrir perfil"),
                new AntdUI.ContextMenuStripItemDivider(),
                new AntdUI.ContextMenuStripItem("Copiar nickname")
            };

            var menuStrip = new AntdUI.ContextMenuStrip.Config(TableUsuariosRank, item =>
                {
                    switch (item.Text)
                    {
                        case "Abrir perfil":
                            AbrirPerfil?.Invoke(this, usuario.Id);
                            break;
                        case "Copiar nickname":
                            Clipboard.SetText(usuario.Nickname);
                            break;
                    }
                },
                menuItems)
            {
                ColorScheme = TAMode.Dark
            };

            menuStrip.open();
        }

        private void TableUsuariosRank_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right || e.Record is not UsuarioRank usuario) return;

            MostrarMenuUsuario(usuario);
        }

        private void TableUsuariosRank_CellDoubleClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Record is not UsuarioRank usuario) return;

            AbrirPerfil?.Invoke(this, usuario.Id);
        }

        private async Task BuscarUsuario()
        {
            string? nickname = InputBuscarUsuario.Text;

            if (string.IsNullOrWhiteSpace(nickname))
            {
                nickname = null;
            }

            await AtualizarTabelaRanks(nickname);
        }

        private async void ButtonBuscarUsuario_Click(object sender, EventArgs e)
        {
            await BuscarUsuario();
        }

        private async void InputBuscarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await BuscarUsuario();
            }
        }

        private void InputBuscarUsuario_SuffixClick(object sender, MouseEventArgs e)
        {
            InputBuscarUsuario.Text = "";
        }
    }
}
