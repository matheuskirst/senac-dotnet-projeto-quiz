using AntdUI;
using SenacQuizApp.Dtos.Usuario;
using SenacQuizApp.Enums;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Utils;

namespace SenacQuizApp.Telas
{
    public partial class PaginaSignup : UserControl
    {
        private readonly AutenticacaoService _autenticacaoService;
        private Color? _corBordas;
        public event EventHandler? EscolheuVoltar;
        public event EventHandler? ConcluiuSignup;
        public PaginaSignup(AutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
            InitializeComponent();
        }

        private void PaginaSignup_Load(object sender, EventArgs e)
        {
            _corBordas = InputSignupUsername.BorderColor;

            DatePickerSignupDataNascimento.MaxDate = DateTime.Now;
            DatePickerSignupDataNascimento.MinDate = DateTime.Today.AddYears(-120);

            InputSignupUsername.Focus();
        }

        private void ButtonSignupVoltar_Click(object sender, EventArgs e)
        {
            EscolheuVoltar?.Invoke(this, EventArgs.Empty);
        }

        private void DatePickerSignupDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete ||
                e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                return;
            }

            bool numeroSuperior = (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && !e.Modifiers.HasFlag(Keys.Shift);
            bool numeroLateral = (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9);

            if (!numeroSuperior  && !numeroLateral)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void InputSignupSenha_SuffixClick(object sender, MouseEventArgs e)
        {
            if (InputSignupSenha.UseSystemPasswordChar == false)
            {
                InputSignupSenha.UseSystemPasswordChar = true;
                InputSignupSenha.SuffixText = "Mostrar";
            }
            else
            {
                InputSignupSenha.UseSystemPasswordChar = false;
                InputSignupSenha.SuffixText = "Esconder";
            }
        }

        private void InputSignupConfirmarSenha_SuffixClick(object sender, MouseEventArgs e)
        {
            if (InputSignupConfirmarSenha.UseSystemPasswordChar == false)
            {
                InputSignupConfirmarSenha.UseSystemPasswordChar = true;
                InputSignupConfirmarSenha.SuffixText = "Mostrar";
            }
            else
            {
                InputSignupConfirmarSenha.UseSystemPasswordChar = false;
                InputSignupConfirmarSenha.SuffixText = "Esconder";
            }
        }

        private void LimparBorda_TextChanged(object sender, EventArgs e)
        {
            if (sender is Input control)
            {
                control.BorderColor = _corBordas;
            }
        }

        private void ButtonSignupRegistrar_Click(object sender, EventArgs e)
        {
            ValidarRegistro();
        }

        private void NomeIndisponivel()
        {
            PintarErros.ErroNoCampo(InputSignupUsername, mensagem: "Esse nome não está disponível!");
            ButtonSignupRegistrar.Enabled = true;
            ButtonSignupRegistrar.Loading = false;
        }

        private void LimparBordas()
        {
            InputSignupUsername.BorderColor = _corBordas;
            InputSignupNick.BorderColor = _corBordas;
            DatePickerSignupDataNascimento.BorderColor = _corBordas;
            InputSignupSenha.BorderColor = _corBordas;
            InputSignupConfirmarSenha.BorderColor = _corBordas;
        }

        private void ErroDeConexao(string erro)
        {
            MessageBox.Show(
                $"Ocorreu um erro ao se conectar com o servidor {erro}.",
                "Erro de Conexão",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            ButtonSignupRegistrar.Enabled = true;
            ButtonSignupRegistrar.Loading = false;
        }

        private void ValidarRegistro()
        {
            LimparBordas();

            string? username = InputSignupUsername.Text;
            string? nick = InputSignupNick.Text;
            DateTime? dataNascimento = DatePickerSignupDataNascimento.Value;
            string senha = InputSignupSenha.Text;
            string confirmarSenha = InputSignupConfirmarSenha.Text;


            bool usernameValido = ValidarUsername(username);
            bool nickValido = false;
            if (!string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(nick))
            {
                nick = username.ToLower();
                InputSignupNick.Text = nick;
                nickValido = true;
            }
            else
            {
                nickValido = ValidarNickname(nick);
            }
            bool dataNascimentoValido = ValidarDataNascimento(dataNascimento);
            bool senhaValida = ValidarSenha(senha, confirmarSenha);

            if (usernameValido && nickValido && dataNascimentoValido && senhaValida)
            {

                RequisitarSignup(username, nick, dataNascimento, senha);
                ButtonSignupRegistrar.Enabled = false;
                ButtonSignupRegistrar.Loading = true;
            }
            else
            {
                ButtonSignupRegistrar.Enabled = true;
                ButtonSignupRegistrar.Loading = false;
            }
        }

        private bool ValidarUsername(string? username)
        {
            bool validado = false;

            if (string.IsNullOrWhiteSpace(username))
            {
                PintarErros.ErroNoCampo(InputSignupUsername, mensagem: "Por favor preencha o campo.");
            }
            else if (username.Length < 3 || username.Length > ModelosConstantes.Usuario.MaxUsernameLength)
            {
                PintarErros.ErroNoCampo(InputSignupUsername, mensagem: $"O Nome de Usuário deve ter entre 3 e {ModelosConstantes.Usuario.MaxUsernameLength} caracteres.");
            }
            else
            {
                validado = true;
            }
            return validado;
        }

        private bool ValidarNickname(string nickname)
        {
            if (!string.IsNullOrEmpty(nickname) && (nickname.Length < 3 || nickname.Length > ModelosConstantes.Usuario.MaxNicknameLength))
            {
                PintarErros.ErroNoCampo(InputSignupNick, mensagem: $"O Nickname deve ter entre 3 e {ModelosConstantes.Usuario.MaxNicknameLength} caracteres.");
                return false;
            }
            return true;
        }

        private bool ValidarDataNascimento(DateTime? dataNascimento)
        {
            if (dataNascimento == null)
            {
                PintarErros.ErroNoCampo(DatePickerSignupDataNascimento, mensagem: "Por favor preencha o campo.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarSenha(string senha, string confirmarSenha)
        {
            bool validado = false;

            if (string.IsNullOrWhiteSpace(confirmarSenha))
            {
                PintarErros.ErroNoCampo(InputSignupConfirmarSenha, mensagem: "Por favor preencha o campo.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: "Por favor preencha o campo.");
                validado = false;
            }
            else if (senha.Length < 6 || senha.Length > ModelosConstantes.Usuario.MaxSenhaLength)
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: $"A senha deve ter entre 6 e {ModelosConstantes.Usuario.MaxSenhaLength} caracteres!");

                validado = false;
            }
            else if (!SenhaAtendeRequisitos(senha))
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: "A senha deve ter pelo menos 1 letra maiúscula,\n 1 letra minúscula, 1 caractere especial e 1 número!");
                validado = false;
            }
            else if (!string.IsNullOrWhiteSpace(confirmarSenha) && senha != confirmarSenha)
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: "As senhas não são as mesmas!");
                PintarErros.ErroNoCampo(InputSignupConfirmarSenha, mensagem: "As senhas não são as mesmas!");
                validado = false;
            }
            else
            {
                validado = true;
            }
            return validado;
        }

        private static bool SenhaAtendeRequisitos(string senha)
        {
            return senha.Any(char.IsUpper)
                && senha.Any(char.IsLower)
                && senha.Any(char.IsNumber)
                && senha.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private async void RequisitarSignup(string username, string nickname, DateTime? dataNascimento, string senha)
        {
            try
            {
                AutenticacaoResponse resultado = await _autenticacaoService.RealizarSignup(username, nickname, dataNascimento, senha);

                if (resultado.IsSucesso == true)
                {
                    ConcluiuSignup?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    if (resultado.Erro == ErroAutenticacao.NomeIndisponivel)
                    {
                        NomeIndisponivel();
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
