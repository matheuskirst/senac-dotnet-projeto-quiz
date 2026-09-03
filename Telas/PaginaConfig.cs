using AntdUI;
using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using SenacQuizApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas
{
    public partial class PaginaConfig : Window
    {
        public PaginaConfig()
        {
            InitializeComponent();
        }

        private void AlternarVisibilidadeSenha(object sender, MouseEventArgs e)
        {
            if (sender is AntdUI.Input input)
            {
                // Alterna entre mostrar os caracteres reais ou a máscara
                input.UseSystemPasswordChar = !input.UseSystemPasswordChar;

                // Opcional: altera o ícone de olho aberto/fechado
                input.SuffixSvg = input.UseSystemPasswordChar ? "EyeOutlined" : "EyeInvisibleOutlined";
            }
        }
        private async void btnMudarNickname_Click(object sender, EventArgs e)
        {
            string novoNickname = txtNickname.Text.Trim();

            if (string.IsNullOrWhiteSpace(novoNickname))
            {
                PintarErros.ErroNoCampo(txtNickname, mensagem: "O nickname não pode ser vazio.");
                return;
            }

            try
            {
                int idUsuario = UsuarioAtual.Id;

                using var contexto = new QuizAppContexto();

                var usuario = await contexto.Usuarios
                    .FirstOrDefaultAsync(u => u.Id == idUsuario);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Atualiza no banco de dados
                usuario.Nickname = novoNickname;
                await contexto.SaveChangesAsync();

                // Atualiza a sessão local em memória
                //UsuarioAtual.Nickname = novoNickname;

                MessageBox.Show("Nickname atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickname.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar nickname: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            string senhaAtual = txtSenhaAtual.Text;
            string novaSenha = txtNovSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            // Validações de campos vazios
            if (string.IsNullOrWhiteSpace(senhaAtual))
            {
                PintarErros.ErroNoCampo(txtSenhaAtual, mensagem: "Informe a senha atual!");
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                PintarErros.ErroNoCampo(txtNovSenha, mensagem: "A nova senha não pode ser vazia!");
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmarSenha))
            {
                PintarErros.ErroNoCampo(txtConfirmarSenha, mensagem: "Confirme a nova senha!");
                return;
            }

            // Validação de correspondência de senhas
            if (novaSenha != confirmarSenha)
            {
                PintarErros.ErroNoCampo(txtConfirmarSenha, mensagem: "As senhas não coincidem!");
                return;
            }

            try
            {
                int idUsuario = UsuarioAtual.Id;

                using var contexto = new QuizAppContexto();

                var usuario = await contexto.Usuarios
                    .FirstOrDefaultAsync(u => u.Id == idUsuario);

                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica se a senha atual digitada é a correta
                if (!BCrypt.Net.BCrypt.EnhancedVerify(senhaAtual, usuario.Senha))
                {
                    PintarErros.ErroNoCampo(txtSenhaAtual, mensagem: "Senha atual incorreta!");
                    return;
                }

                // Atualiza a nova senha
                usuario.Senha = BCrypt.Net.BCrypt.EnhancedHashPassword(novaSenha);

                await contexto.SaveChangesAsync();

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos de texto após o sucesso
                txtSenhaAtual.Clear();
                txtNovSenha.Clear();
                txtConfirmarSenha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar a senha: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

