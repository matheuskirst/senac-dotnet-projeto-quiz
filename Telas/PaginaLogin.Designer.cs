using SenacQuizApp.Telas.Componentes;

namespace SenacQuizApp.Telas
{
    partial class PaginaLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaLogin));
            StackPanelLogin = new AntdUI.StackPanel();
            StackPanelLoginErro = new AntdUI.StackPanel();
            LabelLoginErro = new AntdUI.Label();
            ButtonLoginEntrar = new AntdUI.Button();
            InputLoginSenha = new PasswordInput();
            LabelLoginSenha = new AntdUI.Label();
            InputLoginUsername = new AntdUI.Input();
            LabelLoginUsername = new AntdUI.Label();
            LabelLoginTitulo = new AntdUI.Label();
            ButtonLoginVoltar = new AntdUI.Button();
            StackPanelLogin.SuspendLayout();
            StackPanelLoginErro.SuspendLayout();
            SuspendLayout();
            // 
            // StackPanelLogin
            // 
            StackPanelLogin.Anchor = AnchorStyles.Top;
            StackPanelLogin.ColorScheme = AntdUI.TAMode.Dark;
            StackPanelLogin.Controls.Add(StackPanelLoginErro);
            StackPanelLogin.Controls.Add(ButtonLoginEntrar);
            StackPanelLogin.Controls.Add(InputLoginSenha);
            StackPanelLogin.Controls.Add(LabelLoginSenha);
            StackPanelLogin.Controls.Add(InputLoginUsername);
            StackPanelLogin.Controls.Add(LabelLoginUsername);
            StackPanelLogin.Controls.Add(LabelLoginTitulo);
            StackPanelLogin.Location = new Point(292, 100);
            StackPanelLogin.Name = "StackPanelLogin";
            StackPanelLogin.Size = new Size(440, 450);
            StackPanelLogin.TabIndex = 0;
            StackPanelLogin.TabStop = false;
            StackPanelLogin.Text = "stackPanel1";
            StackPanelLogin.Vertical = true;
            // 
            // StackPanelLoginErro
            // 
            StackPanelLoginErro.BackColor = Color.Transparent;
            StackPanelLoginErro.BorderColor = Color.Red;
            StackPanelLoginErro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            StackPanelLoginErro.BorderWidth = 2F;
            StackPanelLoginErro.ColorScheme = AntdUI.TAMode.Dark;
            StackPanelLoginErro.Controls.Add(LabelLoginErro);
            StackPanelLoginErro.Location = new Point(3, 372);
            StackPanelLoginErro.Name = "StackPanelLoginErro";
            StackPanelLoginErro.Radius = 6;
            StackPanelLoginErro.Size = new Size(434, 50);
            StackPanelLoginErro.TabIndex = 24;
            StackPanelLoginErro.Visible = false;
            // 
            // LabelLoginErro
            // 
            LabelLoginErro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginErro.Location = new Point(5, 5);
            LabelLoginErro.Name = "LabelLoginErro";
            LabelLoginErro.Size = new Size(428, 40);
            LabelLoginErro.TabIndex = 0;
            LabelLoginErro.TabStop = false;
            LabelLoginErro.Text = "";
            LabelLoginErro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonLoginEntrar
            // 
            ButtonLoginEntrar.ColorScheme = AntdUI.TAMode.Dark;
            ButtonLoginEntrar.DefaultBack = Color.FromArgb(75, 150, 75);
            ButtonLoginEntrar.Font = new Font("Segoe UI", 14.25F);
            ButtonLoginEntrar.Location = new Point(3, 306);
            ButtonLoginEntrar.Margin = new Padding(3, 50, 3, 3);
            ButtonLoginEntrar.Name = "ButtonLoginEntrar";
            ButtonLoginEntrar.Size = new Size(434, 60);
            ButtonLoginEntrar.TabIndex = 2;
            ButtonLoginEntrar.Text = "Entrar";
            ButtonLoginEntrar.Click += ButtonLoginEntrar_Click;
            // 
            // InputLoginSenha
            // 
            InputLoginSenha.BackColor = Color.FromArgb(66, 66, 66);
            InputLoginSenha.BorderColor = Color.FromArgb(20, 20, 20);
            InputLoginSenha.ColorScheme = AntdUI.TAMode.Dark;
            InputLoginSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputLoginSenha.Location = new Point(0, 204);
            InputLoginSenha.Margin = new Padding(0);
            InputLoginSenha.Name = "InputLoginSenha";
            InputLoginSenha.Radius = 4;
            InputLoginSenha.Size = new Size(440, 52);
            InputLoginSenha.SuffixSvg = resources.GetString("InputLoginSenha.SuffixSvg");
            InputLoginSenha.TabIndex = 1;
            InputLoginSenha.UseSystemPasswordChar = true;
            InputLoginSenha.SuffixClick += InputLoginSenha_SuffixClick;
            InputLoginSenha.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelLoginSenha
            // 
            LabelLoginSenha.ColorScheme = AntdUI.TAMode.Dark;
            LabelLoginSenha.Font = new Font("Segoe UI", 14.25F);
            LabelLoginSenha.Location = new Point(3, 199);
            LabelLoginSenha.Name = "LabelLoginSenha";
            LabelLoginSenha.Size = new Size(434, 23);
            LabelLoginSenha.TabIndex = 19;
            LabelLoginSenha.Text = "Senha";
            // 
            // InputLoginUsername
            // 
            InputLoginUsername.BackColor = Color.FromArgb(66, 66, 66);
            InputLoginUsername.BorderColor = Color.FromArgb(20, 20, 20);
            InputLoginUsername.ColorScheme = AntdUI.TAMode.Dark;
            InputLoginUsername.Font = new Font("Segoe UI", 12F);
            InputLoginUsername.Location = new Point(0, 125);
            InputLoginUsername.Margin = new Padding(0);
            InputLoginUsername.Name = "InputLoginUsername";
            InputLoginUsername.Radius = 4;
            InputLoginUsername.Size = new Size(440, 50);
            InputLoginUsername.TabIndex = 0;
            InputLoginUsername.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelLoginUsername
            // 
            LabelLoginUsername.ColorScheme = AntdUI.TAMode.Dark;
            LabelLoginUsername.Font = new Font("Segoe UI", 14.25F);
            LabelLoginUsername.Location = new Point(3, 120);
            LabelLoginUsername.Name = "LabelLoginUsername";
            LabelLoginUsername.Size = new Size(434, 23);
            LabelLoginUsername.TabIndex = 2;
            LabelLoginUsername.Text = "Nome de Usuário";
            // 
            // LabelLoginTitulo
            // 
            LabelLoginTitulo.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelLoginTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelLoginTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginTitulo.Location = new Point(3, 3);
            LabelLoginTitulo.Margin = new Padding(3, 3, 3, 50);
            LabelLoginTitulo.MinimumSize = new Size(0, 40);
            LabelLoginTitulo.Name = "LabelLoginTitulo";
            LabelLoginTitulo.Size = new Size(434, 43);
            LabelLoginTitulo.TabIndex = 0;
            LabelLoginTitulo.TabStop = false;
            LabelLoginTitulo.Text = "Realizar Login";
            LabelLoginTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // ButtonLoginVoltar
            // 
            ButtonLoginVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonLoginVoltar.BorderWidth = 2F;
            ButtonLoginVoltar.ColorScheme = AntdUI.TAMode.Dark;
            ButtonLoginVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLoginVoltar.Ghost = true;
            ButtonLoginVoltar.Location = new Point(23, 633);
            ButtonLoginVoltar.Name = "ButtonLoginVoltar";
            ButtonLoginVoltar.Radius = 4;
            ButtonLoginVoltar.Size = new Size(120, 40);
            ButtonLoginVoltar.TabIndex = 3;
            ButtonLoginVoltar.Text = "Voltar";
            ButtonLoginVoltar.Click += ButtonLoginVoltar_Click;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(27F, 65F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(StackPanelLogin);
            Controls.Add(ButtonLoginVoltar);
            Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(11, 13, 11, 13);
            Name = "PaginaLogin";
            Size = new Size(1024, 720);
            Load += PaginaLogin_Load;
            Resize += PaginaLogin_Resize;
            StackPanelLogin.ResumeLayout(false);
            StackPanelLogin.PerformLayout();
            StackPanelLoginErro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button ButtonLoginVoltar;
        private AntdUI.StackPanel StackPanelLogin;
        private AntdUI.Label LabelLoginTitulo;
        private AntdUI.Label LabelLoginUsername;
        private AntdUI.Input InputLoginUsername;
        private AntdUI.Label LabelLoginSenha;
        private PasswordInput InputLoginSenha;
        private AntdUI.StackPanel StackPanelLoginErro;
        private AntdUI.Label LabelLoginErro;
        private AntdUI.Button ButtonLoginEntrar;
    }
}
