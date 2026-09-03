using AntdUI;
using System.ComponentModel;
using SenacQuizApp.Services;
using SenacQuizApp.Enums;
using SenacQuizApp.Dtos.Ranking;

namespace SenacQuizApp.Telas
{
    public partial class PaginaRanking : UserControl
    {
        private readonly RankingService _rankingService;

        public event EventHandler<int>? AbrirPerfil;

        private RankTipo _rankAtual;

        public PaginaRanking(RankingService rankingService)
        {
            _rankingService = rankingService;

            InitializeComponent();
        }

        private async void PaginaRanking_Load(object sender, EventArgs e)
        {
            SelectRankTipo.Items.Add(new AntdUI.SelectItem("Geral", RankTipo.Geral));
            SelectRankTipo.Items.Add(new AntdUI.SelectItem("Diário", RankTipo.Diario));
            SelectRankTipo.Items.Add(new AntdUI.SelectItem("Rush", RankTipo.Rush));

            SelectRankTipo.SelectedValue = RankTipo.Geral;
            _rankAtual = RankTipo.Geral;

            await AtualizarTabelaRanks();
        }

        private async Task AtualizarTabelaRanks(string? nickname = null)
        {
            switch (_rankAtual)
            {
                case RankTipo.Geral:
                    TableUsuariosRank.Columns = new AntdUI.ColumnCollection
                    {
                        new AntdUI.Column(nameof(UsuarioRankGeral.Nickname), "Usuário") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankGeral.PontuacaoTotal), "Pontuação") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankGeral.Nivel), "Nível") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankGeral.TotalAcertos), "Acertos") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankGeral.TotalRespondidos), "Respondidos") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankGeral.TemaMaisAcertadoNome), "Tema Mestre") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankGeral.TemaMaisAcertadoAcertos), "Mestre Acertos") { SortOrder = true },
                    };

                    TableUsuariosRank.DataSource = await _rankingService.ObterRankingGeral();
                    break;

                case RankTipo.Diario:
                    TableUsuariosRank.Columns = new AntdUI.ColumnCollection
                    {
                        new AntdUI.Column(nameof(UsuarioRankDiario.Nickname), "Usuário") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankDiario.TotalAcertosDiarios), "Acertos") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankDiario.MaxAcertosConsecutivos), "Máx. Sequência") { SortOrder = true },
                    };

                    TableUsuariosRank.DataSource = await _rankingService.ObterRankingDiario();
                    break;

                case RankTipo.Rush:
                    TableUsuariosRank.Columns = new AntdUI.ColumnCollection
                    {
                        new AntdUI.Column(nameof(UsuarioRankRush.Nickname), "Usuário") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankRush.Recorde), "Recorde") { SortOrder = true },
                        new AntdUI.Column(nameof(UsuarioRankRush.Tempo), "Tempo") { SortOrder = true, DisplayFormat = @"hh\:mm\:ss\.fff"  },
                    };

                    TableUsuariosRank.DataSource = await _rankingService.ObterRankingRush();
                    break;
            }
        }

        private void MostrarMenuUsuario(UsuarioRankGeral usuario)
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
            if (e.Button != MouseButtons.Right || e.Record is not UsuarioRankGeral usuario) return;

            MostrarMenuUsuario(usuario);
        }

        private void TableUsuariosRank_CellDoubleClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right || e.Record is not UsuarioRankGeral usuario) return;

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

        private async void SelectRankTipo_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not RankTipo rank) return;

            _rankAtual = rank;
            await AtualizarTabelaRanks();
        }
    }
}
