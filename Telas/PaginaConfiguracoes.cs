using AntdUI;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    public partial class PaginaConfiguracoes : Window
    {
        private readonly ContainerControl? _parente;

        private ConfigMenuOpcoes _telaAtual;

        public PaginaConfiguracoes(ContainerControl? parente=null)
        {
            _parente = parente;

            InitializeComponent();

            MenuOpcoes.Items.Add(new AntdUI.MenuItem("Conta") 
            {
                IconSvg = SvgIcons.AccountIcon,
                Tag = ConfigMenuOpcoes.Conta,
                Select = true
            });
            _telaAtual = ConfigMenuOpcoes.Conta;
            AtualizarTela();
        }

        private void PaginaConfiguracoes_Load(object sender, EventArgs e)
        {

        }

        private void AtualizarTela()
        {
            switch (_telaAtual)
            {
                case ConfigMenuOpcoes.Conta:
                    var telaConta = new ConfigConta(parente: this);
                    telaConta.Dock = DockStyle.Fill;
                    PanelTelas.Controls.Add(telaConta);
                    break;
            }
        }
    }
}
