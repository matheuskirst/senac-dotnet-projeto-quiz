using AntdUI;
using AntdUI;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Eventos;
using SenacQuizApp.Telas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas
{
    public partial class PaginaSignup : UserControl
    {
        private Color? _corBordas;
        public event EventHandler? EscolheuVoltar;
        public event EventHandler<SignupEventArgs>? RequesitouSignup;
        public PaginaSignup()
        {
            InitializeComponent();
        }

        private void PaginaSignup_Load(object sender, EventArgs e)
        {
            _corBordas = InputSignupNome.BorderColor;

            DatePickerSignupDataNascimento.MaxDate = DateTime.Now;
            DatePickerSignupDataNascimento.MinDate = DateTime.Today.AddYears(-120);
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
            if (sender is AntdUI.Input control)
            {
                control.BorderColor = _corBordas;
            }
        }

        private void ButtonSignupRegistrar_Click(object sender, EventArgs e)
        {
            ValidarRegistro();
        }

        private async void ValidarRegistro()
        {
            LimparBordas();


            string? nome = InputSignupNome.Text;
            string? nick = InputSignupNick.Text;
            DateTime? dataNascimento = DatePickerSignupDataNascimento.Value;
            string senha = InputSignupSenha.Text;
            string confirmarSenha = InputSignupConfirmarSenha.Text;


            bool nomeValido = ValidarNome(nome);
            bool nickValido = false;
            if (!string.IsNullOrWhiteSpace(nome) && string.IsNullOrWhiteSpace(nick))
            {
                nick = nome.ToLower();
                nickValido = true;
            }
            else
            {
                nickValido = ValidarNickname(nick);
            }
            bool dataNascimentoValido = ValidarDataNascimento(dataNascimento);
            bool senhaValida = ValidarSenha(senha, confirmarSenha);

            if (nomeValido && nickValido && dataNascimentoValido && senhaValida)
            {
                RequesitouSignup?.Invoke(this, new SignupEventArgs(nome, nick, dataNascimento, senha));
                ButtonSignupRegistrar.Enabled = false;
                ButtonSignupRegistrar.Loading = true;
            }
            else
            {
                ButtonSignupRegistrar.Enabled = true;
                ButtonSignupRegistrar.Loading = false;
            }
        }

        private bool ValidarNome(string? nome)
        {
            bool validado = false;

            if (string.IsNullOrWhiteSpace(nome))
            {
                PintarErros.ErroNoCampo(InputSignupNome, mensagem: "Por favor preencha o campo.");
            }
            else if (nome.Length < 3 || nome.Length > 32)
            {
                PintarErros.ErroNoCampo(InputSignupNome, mensagem: "O Nome deve ter entre 3 e 32 caracteres.");
            }
            else
            {
                validado = true;
            }
            return validado;
        }

        private bool ValidarNickname(string nickname)
        {
            if (!string.IsNullOrEmpty(nickname) && (nickname.Length < 3 || nickname.Length > 32))
            {
                PintarErros.ErroNoCampo(InputSignupNick, mensagem: "O Nickname deve ter entre 3 e 32 caracteres.");
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
            if (string.IsNullOrWhiteSpace(senha))
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: "Por favor preencha o campo.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(senha) && string.IsNullOrWhiteSpace(confirmarSenha))
            {
                PintarErros.ErroNoCampo(InputSignupConfirmarSenha, mensagem: "Por favor preencha o campo.");
                return false;
            }

            int tamanhoSenha = senha.Length;

            if (tamanhoSenha < 6 || tamanhoSenha > 50)
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: "A senha deve ter entre 6 e 50 caracteres!");
                return false;
            }
            else if (!SenhaAtendeRequisitos(senha))
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: "A senha deve ter pelo menos 1 letra maiúscula,\n 1 letra minúscula, 1 caractere especial e 1 número!");
                return false;
            }
            else if (senha != confirmarSenha)
            {
                PintarErros.ErroNoCampo(InputSignupSenha, mensagem: "As senhas não são as mesmas!");
                PintarErros.ErroNoCampo(InputSignupConfirmarSenha, mensagem: "As senhas não são as mesmas!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool SenhaAtendeRequisitos(string senha)
        {
            return senha.Any(char.IsUpper)
                && senha.Any(char.IsLower)
                && senha.Any(char.IsNumber)
                && senha.Any(ch => !char.IsLetterOrDigit(ch));
        }

        public void NomeIndisponivel()
        {
            PintarErros.ErroNoCampo(InputSignupNome, mensagem: "Esse nome não está disponível!");
            ButtonSignupRegistrar.Enabled = true;
            ButtonSignupRegistrar.Loading = false;
        }

        private void LimparBordas()
        {
            InputSignupNome.BorderColor = _corBordas;
            InputSignupNick.BorderColor = _corBordas;
            DatePickerSignupDataNascimento.BorderColor = _corBordas;
            InputSignupSenha.BorderColor = _corBordas;
            InputSignupConfirmarSenha.BorderColor = _corBordas;
        }

        public void ErroDeConexao(string? erro)
        {
            MessageBox.Show(
                $"Ocorreu um erro{erro}.",
                "Erro de Conexão",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            ButtonSignupRegistrar.Enabled = true;
            ButtonSignupRegistrar.Loading = false;
        }
    }
}
