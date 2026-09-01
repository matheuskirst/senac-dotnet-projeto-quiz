namespace SenacQuizApp.Telas
{
    partial class PaginaConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new AntdUI.Button();
            btnTrocarSenha = new Button();
            txtSenhaAtual = new TextBox();
            txtNovSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(17, 20);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 0;
            button1.Text = "Conta";
            // 
            // btnTrocarSenha
            // 
            btnTrocarSenha.BackColor = Color.Tomato;
            btnTrocarSenha.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrocarSenha.Location = new Point(315, 244);
            btnTrocarSenha.Name = "btnTrocarSenha";
            btnTrocarSenha.Size = new Size(283, 52);
            btnTrocarSenha.TabIndex = 1;
            btnTrocarSenha.Text = "Trocar Senha";
            btnTrocarSenha.UseVisualStyleBackColor = false;
            btnTrocarSenha.Click += btnTrocarSenha_Click;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Location = new Point(285, 50);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.PlaceholderText = "Senha Atual";
            txtSenhaAtual.Size = new Size(375, 31);
            txtSenhaAtual.TabIndex = 2;
            // 
            // txtNovSenha
            // 
            txtNovSenha.Location = new Point(285, 106);
            txtNovSenha.Name = "txtNovSenha";
            txtNovSenha.PlaceholderText = "Nova Senha";
            txtNovSenha.Size = new Size(379, 31);
            txtNovSenha.TabIndex = 3;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(288, 169);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Confirmar senha";
            txtConfirmarSenha.Size = new Size(376, 31);
            txtConfirmarSenha.TabIndex = 4;
            // 
            // PaginaConfig
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 935);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtNovSenha);
            Controls.Add(txtSenhaAtual);
            Controls.Add(btnTrocarSenha);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PaginaConfig";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button button1;
        private Button btnTrocarSenha;
        private TextBox txtSenhaAtual;
        private TextBox txtNovSenha;
        private TextBox txtConfirmarSenha;
    }
}