using AntdUI;
using SenacQuizApp.Enums;
using SenacQuizApp.Dtos;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Utils;

namespace SenacQuizApp.Telas
{
    public partial class PaginaLogin : UserControl
    {
        private readonly AutenticacaoService _usuarioService;
        private Color? _corBordas;
        public event EventHandler? EscolheuVoltar;
        public event EventHandler? ConcluiuLogin;

        public PaginaLogin(AutenticacaoService usuarioService)
        {
            _usuarioService = usuarioService;

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

        private void ButtonLoginEntrar_Click(object sender, EventArgs e)
        {
            ValidarLogin();
        }

        public async void ValidarLogin()
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
                PintarErros.ErroNoCampo(InputLoginUsername, mensagem:"Por favor preencha o campo.");
            }
            else if (username.Length < 3 || username.Length > 32)
            {
                PintarErros.ErroNoCampo(InputLoginUsername, mensagem:"O Nome de Usuário deve ter entre 3 e 32 caracteres.");
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
                PintarErros.ErroNoCampo(InputLoginSenha, mensagem:"Por favor preencha o campo.");
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

        public void ErroNoLogin()
        {
            ButtonLoginEntrar.Enabled = true;
            ButtonLoginEntrar.Loading = false;
            StackPanelLoginErro.Visible = true;
            PintarErros.ErroNoCampo(InputLoginUsername);
            PintarErros.ErroNoCampo(InputLoginSenha);
        }

        public void ErroDeConexao(string? erro)
        {
            MessageBox.Show(
                $"Ocorreu um erro{erro}.",
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
                LoginRequest login = new(Username: username, Senha: senha);

                LoginResponse resultado = await _usuarioService.RealizarLogin(login);

                if (resultado.IsSucesso == true)
                {
                    ConcluiuLogin?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    if (resultado.MensagemErro == Mensagem.LoginInvalido)
                    {
                        ErroNoLogin();
                    }
                }
            }
            catch (Exception ex)
            {
                ErroDeConexao(ex.ToString());
            }
        }
    }
}
