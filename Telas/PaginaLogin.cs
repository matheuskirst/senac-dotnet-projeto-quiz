using AntdUI;
using SenacQuizApp.Enums;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Utils;
using SenacQuizApp.Dtos.Usuario;

namespace SenacQuizApp.Telas
{
    public partial class PaginaLogin : UserControl
    {
        private readonly AutenticacaoService _autenticacaoService;
        private Color? _corBordas;
        public event EventHandler? EscolheuVoltar;
        public event EventHandler? ConcluiuLogin;

        public PaginaLogin(AutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;

            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {
            _corBordas = InputLoginUsername.BorderColor;
            StackPanelLoginErro.Back = Color.FromArgb(255, 200, 200);

            InputLoginUsername.Focus();
        }

        private void ButtonLoginVoltar_Click(object sender, EventArgs e)
        {
            EscolheuVoltar?.Invoke(this, EventArgs.Empty);
        }

        private void InputLoginSenha_SuffixClick(object sender, MouseEventArgs e)
        {
            if (InputLoginSenha.UseSystemPasswordChar == false)
            {
                InputLoginSenha.UseSystemPasswordChar = true;
                InputLoginSenha.SuffixText = "Mostrar";
            }
            else
            {
                InputLoginSenha.UseSystemPasswordChar = false;
                InputLoginSenha.SuffixText = "Esconder";
            }
        }

        private void LimparBorda_TextChanged(object sender, EventArgs e)
        {
            if (sender is Input control)
            {
                control.BorderColor = _corBordas;
            }
        }

        private async void ButtonLoginEntrar_Click(object sender, EventArgs e)
        {
            LimparBordas();
            StackPanelLoginErro.Visible = false;

            string? username = InputLoginUsername.Text;
            string? senha = InputLoginSenha.Text;

            bool nomeValido = ValidarUsername(username);
            bool senhaValida = ValidarSenha(senha);

            if (nomeValido && senhaValida)
            {
                ButtonLoginEntrar.Enabled = false;
                ButtonLoginEntrar.Loading = true;
                await RequisitarLogin(username, senha);
            }
            else
            {
                ButtonLoginEntrar.Enabled = true;
                ButtonLoginEntrar.Loading = false;
            }
        }

        private bool ValidarUsername(string? username)
        {
            bool validado = false;

            if (string.IsNullOrWhiteSpace(username))
            {
                PintarErros.ErroNoCampo(InputLoginUsername, mensagem: "Por favor preencha o campo.");
            }
            else if (username.Length < 3 || username.Length > 32)
            {
                PintarErros.ErroNoCampo(InputLoginUsername, mensagem: "O Nome de Usuário deve ter entre 3 e 32 caracteres.");
            }
            else
            {
                validado = true;
            }
            return validado;
        }

        private bool ValidarSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                PintarErros.ErroNoCampo(InputLoginSenha, mensagem: "Por favor preencha o campo.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LimparBordas()
        {
            InputLoginUsername.BorderColor = _corBordas;
            InputLoginSenha.BorderColor = _corBordas;
        }

        private void ErroNoLogin(string erro)
        {
            LabelLoginErro.Text = erro;
            ButtonLoginEntrar.Enabled = true;
            ButtonLoginEntrar.Loading = false;
            StackPanelLoginErro.Visible = true;
            PintarErros.ErroNoCampo(InputLoginUsername);
            PintarErros.ErroNoCampo(InputLoginSenha);
        }

        private void ErroDeConexao()
        {
            MessageBox.Show(
                "Ocorreu um erro ao se conectar com o servidor.",
                "Erro de Conexão",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            ButtonLoginEntrar.Enabled = true;
            ButtonLoginEntrar.Loading = false;
        }

        private async Task RequisitarLogin(string username, string senha)
        {
            try
            {
                bool loginSucesso = await _autenticacaoService.RealizarLogin(username, senha);

                if (loginSucesso)
                {
                    ConcluiuLogin?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    ErroDeConexao();
                }
            }
            catch (LoginException ex)
            {
                ErroNoLogin(ex.Message);
            }
            catch
            {
                ErroDeConexao();
            }
        }

        private void PaginaLogin_Resize(object sender, EventArgs e)
        {
            int x = Math.Max(0, (this.ClientSize.Width - StackPanelLogin.Width) / 2);
            int y = Math.Max(0, (this.ClientSize.Height - StackPanelLogin.Height) / 2);

            StackPanelLogin.Location = new Point(x, y);
        }
    }
}
