using SenacQuizApp.banco.repositories;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Eventos;
using SenacQuizApp.Telas.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;

namespace SenacQuizApp.Telas
{
    public partial class PaginaLogin : UserControl
    {
        private Color? _corBordas;
        public event EventHandler? EscolheuVoltar;
        public event EventHandler<LoginEventArgs>? RequesitouLogin;

        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {
            _corBordas = InputLoginNome.BorderColor;
            StackPanelLoginErro.Back = Color.FromArgb(255, 200, 200);
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

            string? nome = InputLoginNome.Text;
            string? senha = InputLoginSenha.Text;

            bool nomeValido = ValidarNome(nome);
            bool senhaValida = ValidarSenha(senha);

            if (nomeValido && senhaValida)
            {
                RequesitouLogin?.Invoke(this, new LoginEventArgs(nome, senha));
                ButtonLoginEntrar.Enabled = false;
                ButtonLoginEntrar.Loading = true;
            }
            else
            {
                ButtonLoginEntrar.Enabled = true;
                ButtonLoginEntrar.Loading = false;
            }
        }

        private bool ValidarNome(string? nome)
        {
            bool validado = false;

            if (string.IsNullOrWhiteSpace(nome))
            {
                PintarErros.ErroNoCampo(InputLoginNome, mensagem:"Por favor preencha o campo.");
            }
            else if (nome.Length < 3 || nome.Length > 32)
            {
                PintarErros.ErroNoCampo(InputLoginNome, mensagem:"O Nome deve ter entre 3 e 32 caracteres.");
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
            InputLoginNome.BorderColor = _corBordas;
            InputLoginSenha.BorderColor = _corBordas;
        }

        public void ErroNoLogin()
        {
            PintarErros.ErroNoCampo(InputLoginNome);
            PintarErros.ErroNoCampo(InputLoginSenha);
            StackPanelLoginErro.Visible = true;
            ButtonLoginEntrar.Enabled = true;
            ButtonLoginEntrar.Loading = false;
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
    }
}
