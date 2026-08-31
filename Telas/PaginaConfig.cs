using Microsoft.EntityFrameworkCore;
using SenacQuizApp.Data;
using SenacQuizApp.Global;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Utils;
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
    public partial class PaginaConfig : Form
    {
        public PaginaConfig()
        {
            InitializeComponent();
        }

        private void menu1_SelectChanged(object sender, AntdUI.MenuSelectEventArgs e)
        {

        }

        private async void btnTrocarSenha_Click(object sender, EventArgs e)
        {

            // pegar senha do campo txtsenha atual 

            string? senha = txtSenhaAtual.Text;

            int id = UsuarioAtual.Id;




            // buscar usuario logado

            using var contexto = new QuizAppContexto();

            var usuario = await contexto.Usuarios
                .FirstOrDefaultAsync(u => u.Id == id);


            // comparar a senha atual digitada com a senha atual do banco de dados 

            bool isSenhaValida = BCrypt.Net.BCrypt.EnhancedVerify(senha, usuario.Senha);
            if (isSenhaValida)
            {
                if (isSenhaValida)
                {
                    if (string.IsNullOrWhiteSpace(txtNovSenha.Text))
                    {
                        PintarErros.ErroNoCampo(
                            txtNovSenha,
                            mensagem: "A senha deve ter pelo menos 1 letra maiúscula, 1 letra minúscula, 1 número e 1 caractere especial."
                        );
                        return;
                    }

                    if (txtNovSenha.Text != txtConfirmarSenha.Text)
                    {
                        PintarErros.ErroNoCampo(
                            txtConfirmarSenha,
                            mensagem: "As senhas não são as mesmas!"
                        );
                        return;
                    }

                    // Nova senha válida
                    string Senha = BCrypt.Net.BCrypt.HashPassword(txtSenhaAtual.Text);

                    usuario.Senha = Senha;

                    contexto.Usuarios.Update(usuario);
                    await contexto.SaveChangesAsync();

                    MessageBox.Show("Senha alterada com sucesso!");
                }
                else
                {
                    MessageBox.Show("A senha atual está incorreta!");
                }
                // se a nova senha for valida deve atualizar a senha do usuario no banco, se não for valida deve exibir mensagem de erro

                string novaSenha = txtNovSenha.Text;

                if (string.IsNullOrWhiteSpace(novaSenha))
                {
                    MessageBox.Show("Digite uma nova senha!");
                    return;
                }

                if (novaSenha != txtConfirmarSenha.Text)
                {
                    MessageBox.Show("As senhas não são iguais!");
                    return;
                }

              
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(novaSenha);

             
                contexto.Usuarios.Update(usuario);
                await contexto.SaveChangesAsync();

                MessageBox.Show("Senha atualizada com sucesso!");

                // se a senha atual não for valida deve exibir mensagem de erro 
                bool senhaAtualValida = BCrypt.Net.BCrypt.Verify(
                  txtSenhaAtual.Text,
                  usuario.Senha
);

                if (!senhaAtualValida)
                {
                    MessageBox.Show("A senha atual está incorreta!");
                    return;
                }
            }

        }
    }
}


