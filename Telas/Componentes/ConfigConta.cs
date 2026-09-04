using AntdUI;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Global;
using SenacQuizApp.Modelos;
using SenacQuizApp.Modelos.Usuarios;
using SenacQuizApp.Services;
using SenacQuizApp.Utils;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class ConfigConta : UserControl
    {
        private readonly ContainerControl? _parente;

        private Color? _corInputBorda;

        public ConfigConta(ContainerControl? parente = null)
        {
            _parente = parente;

            InitializeComponent();
        }

        private void ConfigConta_Load(object sender, EventArgs e)
        {
            _corInputBorda = InputSenhaAtual.BorderColor;

            InputNickname.Text = UsuarioAtual.Nickname;
        }

        private void FocarInputNickname()
        {
            InputNickname.ReadOnly = false;
            InputNickname.Enabled = true;
            InputNickname.Focus();
            InputNickname.SelectionStart = InputNickname.Text.Length;
        }

        private void ButtonEditarNickname_Click(object sender, EventArgs e)
        {
            FocarInputNickname();
        }

        private void InputNickname_TextChanged(object sender, EventArgs e)
        {
            if (InputNickname.Text != UsuarioAtual.Nickname)
            {
                ButtonSalvarNickname.Enabled = true;
                ButtonSalvarNickname.Visible = true;
            }
            else
            {
                ButtonSalvarNickname.Enabled = false;
                ButtonSalvarNickname.Visible = false;
            }
        }

        private async void ButtonSalvarNickname_Click(object sender, EventArgs e)
        {
            FocarInputNickname();

            string nickname = InputNickname.Text;

            if (string.IsNullOrEmpty(nickname) || (nickname.Length < 3 || nickname.Length > ModelosConstantes.Usuario.MaxNicknameLength))
            {
                PintarErros.ErroNoCampo(InputNickname, mensagem: $"O Nickname deve ter entre 3 e {ModelosConstantes.Usuario.MaxNicknameLength} caracteres.", alinhamento: AntdUI.TAlign.Bottom);
                return;
            }

            using var contexto = new QuizAppContexto();

            Usuario? usuario = await contexto.Usuarios
                .FirstOrDefaultAsync(u => u.Id == UsuarioAtual.Id);

            if (usuario == null) return;

            usuario.Nickname = nickname;

            await contexto.SaveChangesAsync();
            UsuarioAtual.Nickname = nickname;

            ButtonSalvarNickname.Enabled = false;
            ButtonSalvarNickname.Visible = false;

            InputNickname.ReadOnly = true;
            InputNickname.Enabled = false;

            if (_parente is not PaginaConfiguracoes config) return;

            AntdUI.Modal.open(new AntdUI.Modal.Config(config, "Mudança concluida", "Nickname alterado com sucesso!")
            {
                ColorScheme = AntdUI.TAMode.Dark,
                OkText = "Ok",
                Icon = AntdUI.TType.Success,
                CancelText = null
            });
            return;
        }

        private void InputNickname_Leave(object sender, EventArgs e)
        {
            InputNickname.ReadOnly = true;
            InputNickname.Enabled = false;
        }

        private async void ButtonSalvarSenha_Click(object sender, EventArgs e)
        {
            string senhaAtual = InputSenhaAtual.Text;
            string novaSenha = InputNovaSenha.Text;
            string confirmarSenha = InputConfirmarSenha.Text;

            if (!ValidarSenha(senhaAtual, novaSenha, confirmarSenha))
            {
                return;
            }
            else
            {
                using var contexto = new QuizAppContexto();

                Usuario? usuario = await contexto.Usuarios
                    .FirstOrDefaultAsync(u => u.Id == UsuarioAtual.Id);

                if (usuario == null || !BCrypt.Net.BCrypt.EnhancedVerify(senhaAtual, usuario.Senha))
                {
                    PintarErros.ErroNoCampo(InputSenhaAtual, mensagem: "Senha incorreta.");
                    return;
                }

                string novaSenhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(novaSenha);

                usuario.Senha = novaSenhaHash;

                await contexto.SaveChangesAsync();

                if (_parente is not PaginaConfiguracoes config) return;

                AntdUI.Modal.open(new AntdUI.Modal.Config(config, "Mudança concluida", "Senha alterada com sucesso!")
                {
                    ColorScheme = AntdUI.TAMode.Dark,
                    OkText = "Ok",
                    Icon = AntdUI.TType.Success,
                    CancelText = null
                });

                InputSenhaAtual.BorderColor = _corInputBorda;
                InputNovaSenha.BorderColor = _corInputBorda;
                InputConfirmarSenha.BorderColor = _corInputBorda;

                return;
            }
        }

        private bool ValidarSenha(string senhaAtual, string novaSenha, string confirmarSenha)
        {
            bool validado = false;

            if (string.IsNullOrWhiteSpace(senhaAtual))
            {
                PintarErros.ErroNoCampo(InputSenhaAtual, mensagem: "Por favor preencha o campo.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(confirmarSenha))
            {
                PintarErros.ErroNoCampo(InputConfirmarSenha, mensagem: "Por favor preencha o campo.");
                validado = false;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                PintarErros.ErroNoCampo(InputNovaSenha, mensagem: "Por favor preencha o campo.");
                validado = false;
            }
            else if (novaSenha.Length < 6 || novaSenha.Length > ModelosConstantes.Usuario.MaxSenhaLength)
            {
                PintarErros.ErroNoCampo(InputNovaSenha, mensagem: $"A senha deve ter entre 6 e {ModelosConstantes.Usuario.MaxSenhaLength} caracteres!");

                validado = false;
            }
            else if (!SenhaAtendeRequisitos(novaSenha))
            {
                PintarErros.ErroNoCampo(InputNovaSenha, mensagem: "A senha deve ter pelo menos 1 letra maiúscula,\n 1 letra minúscula, 1 caractere especial e 1 número!");
                validado = false;
            }
            else if (!string.IsNullOrWhiteSpace(confirmarSenha) && novaSenha != confirmarSenha)
            {
                PintarErros.ErroNoCampo(InputConfirmarSenha, mensagem: "As senhas não coincidem!");
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

        private void InputSenha_SuffixClick(object sender, MouseEventArgs e)
        {
            if (sender is AntdUI.Input input)
            {
                if (input.UseSystemPasswordChar == false)
                {
                    input.UseSystemPasswordChar = true;
                    input.SuffixSvg = SvgIcons.EyeCrossedIcon;
                }
                else
                {
                    input.UseSystemPasswordChar = false;
                    input.SuffixSvg = SvgIcons.EyeIcon;
                }
            }
        }
    }
}
