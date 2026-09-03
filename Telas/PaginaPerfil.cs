using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Services;

namespace SenacQuizApp.Telas
{
    public partial class PaginaPerfil : UserControl
    {
        private readonly int _usuarioId;
        private readonly UsuarioService _usuarioPerfilService;

        public event Action<int>? AbrirConquistas;

        public PaginaPerfil(int usuarioId, UsuarioService usuarioPerfilService)
        {
            _usuarioId = usuarioId;
            _usuarioPerfilService = usuarioPerfilService;

            InitializeComponent();
        }

        private async void PaginaPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioPerfil? perfil = await _usuarioPerfilService.ObterPerfilPorId(_usuarioId);

                if (perfil == null) return;

                AtualizarPerfil(perfil);
            }
            catch
            {

            }
        }

        private void AtualizarPerfil(UsuarioPerfil perfil)
        {
            LabelUsuario.Text = perfil.Nickname;
            LabelNivel.Text = perfil.Nivel;

            int pontosAtuais = perfil.PontuacaoTotal;
            int pontosMaximosProximoNivel = 0;

            switch (perfil.NivelId)
            {
                case UsuarioNivelId.Iniciante:
                    pontosMaximosProximoNivel = 500;
                    break;
                case UsuarioNivelId.Aprendiz:
                    pontosMaximosProximoNivel = 2000;
                    break;
                case UsuarioNivelId.Intermediario:
                    pontosMaximosProximoNivel = 10000;
                    break;
                case UsuarioNivelId.Avancado:
                    ProgressUsuarioNivel.Value = 1F;
                    ProgressUsuarioNivel.Text = "Nível Máximo";
                    return;
            }

            ProgressUsuarioNivel.Value = (float)pontosAtuais / pontosMaximosProximoNivel;

            LabelProgressoPontos.Text = $"{pontosAtuais} / {pontosMaximosProximoNivel} Pontos";
            LabelPontosProximoNivel.Text = $"{pontosMaximosProximoNivel - pontosAtuais} pontos para o próximo nível";

            LabelInsertPontuacaoTotal.Text = perfil.PontuacaoTotal.ToString();
            LabelInsertAcertos.Text = perfil.TotalAcertos.ToString();
            LabelInsertTotalRespostas.Text = perfil.TotalRespondidos.ToString();
            if (perfil.TotalAcertos == 0 || perfil.TotalRespondidos == 0) { LabelInsertTaxaAcertos.Text = "0%"; }
            else
            {
                LabelInsertTaxaAcertos.Text = $"{(double)perfil.TotalAcertos / perfil.TotalRespondidos:P0}";
            }

            foreach(var conquista in perfil.Conquistas)
            {
                var card = new CardConquista(conquista, mostrarData: true);
                card.Dock = DockStyle.Top;
                PanelDesbloqueadas.Controls.Add(card);
            }
        }
    }
}
