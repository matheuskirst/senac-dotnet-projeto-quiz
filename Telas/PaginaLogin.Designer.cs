namespace SenacQuizApp.Features.Login
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
            TableLayoutPanelLogin = new TableLayoutPanel();
            ButtonLoginVoltar = new AntdUI.Button();
            StackPanelLogin = new AntdUI.StackPanel();
            ButtonLoginEntrar = new AntdUI.Button();
            InputSignupSenha = new AntdUI.Input();
            LabelLoginSenha = new AntdUI.Label();
            InputSignupNome = new AntdUI.Input();
            LabelLoginNome = new AntdUI.Label();
            LabelLoginTitulo = new AntdUI.Label();
            TableLayoutPanelLogin.SuspendLayout();
            StackPanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelLogin
            // 
            TableLayoutPanelLogin.BackColor = Color.Transparent;
            TableLayoutPanelLogin.ColumnCount = 3;
            TableLayoutPanelLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelLogin.Controls.Add(ButtonLoginVoltar, 1, 2);
            TableLayoutPanelLogin.Controls.Add(StackPanelLogin, 1, 1);
            TableLayoutPanelLogin.Dock = DockStyle.Fill;
            TableLayoutPanelLogin.Location = new Point(0, 0);
            TableLayoutPanelLogin.Name = "TableLayoutPanelLogin";
            TableLayoutPanelLogin.RowCount = 4;
            TableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelLogin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelLogin.Size = new Size(1024, 720);
            TableLayoutPanelLogin.TabIndex = 5;
            // 
            // ButtonLoginVoltar
            // 
            ButtonLoginVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonLoginVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLoginVoltar.Location = new Point(23, 653);
            ButtonLoginVoltar.Name = "ButtonLoginVoltar";
            ButtonLoginVoltar.Radius = 4;
            ButtonLoginVoltar.Size = new Size(137, 44);
            ButtonLoginVoltar.TabIndex = 0;
            ButtonLoginVoltar.Text = "Voltar para Tela Inicial";
            ButtonLoginVoltar.Click += ButtonLoginVoltar_Click;
            // 
            // StackPanelLogin
            // 
            StackPanelLogin.Anchor = AnchorStyles.None;
            StackPanelLogin.Controls.Add(ButtonLoginEntrar);
            StackPanelLogin.Controls.Add(InputSignupSenha);
            StackPanelLogin.Controls.Add(LabelLoginSenha);
            StackPanelLogin.Controls.Add(InputSignupNome);
            StackPanelLogin.Controls.Add(LabelLoginNome);
            StackPanelLogin.Controls.Add(LabelLoginTitulo);
            StackPanelLogin.Location = new Point(292, 151);
            StackPanelLogin.Name = "StackPanelLogin";
            StackPanelLogin.Size = new Size(440, 367);
            StackPanelLogin.TabIndex = 1;
            StackPanelLogin.Text = "stackPanel1";
            StackPanelLogin.Vertical = true;
            // 
            // ButtonLoginEntrar
            // 
            ButtonLoginEntrar.DefaultBack = Color.PaleGreen;
            ButtonLoginEntrar.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLoginEntrar.Location = new Point(3, 301);
            ButtonLoginEntrar.Margin = new Padding(3, 50, 3, 3);
            ButtonLoginEntrar.Name = "ButtonLoginEntrar";
            ButtonLoginEntrar.Size = new Size(434, 60);
            ButtonLoginEntrar.TabIndex = 23;
            ButtonLoginEntrar.Text = "Entrar";
            // 
            // InputSignupSenha
            // 
            InputSignupSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupSenha.Location = new Point(0, 201);
            InputSignupSenha.Margin = new Padding(0);
            InputSignupSenha.Name = "InputSignupSenha";
            InputSignupSenha.Radius = 4;
            InputSignupSenha.Size = new Size(440, 50);
            InputSignupSenha.TabIndex = 20;
            // 
            // LabelLoginSenha
            // 
            LabelLoginSenha.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginSenha.Location = new Point(3, 175);
            LabelLoginSenha.Name = "LabelLoginSenha";
            LabelLoginSenha.Size = new Size(434, 23);
            LabelLoginSenha.TabIndex = 19;
            LabelLoginSenha.Text = "Senha";
            // 
            // InputSignupNome
            // 
            InputSignupNome.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupNome.Location = new Point(0, 122);
            InputSignupNome.Margin = new Padding(0);
            InputSignupNome.Name = "InputSignupNome";
            InputSignupNome.Radius = 4;
            InputSignupNome.Size = new Size(440, 50);
            InputSignupNome.TabIndex = 3;
            // 
            // LabelLoginNome
            // 
            LabelLoginNome.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginNome.Location = new Point(3, 96);
            LabelLoginNome.Name = "LabelLoginNome";
            LabelLoginNome.Size = new Size(434, 23);
            LabelLoginNome.TabIndex = 2;
            LabelLoginNome.Text = "Nome de Usuário";
            // 
            // LabelLoginTitulo
            // 
            LabelLoginTitulo.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelLoginTitulo.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginTitulo.Location = new Point(3, 3);
            LabelLoginTitulo.Margin = new Padding(3, 3, 3, 50);
            LabelLoginTitulo.MinimumSize = new Size(0, 40);
            LabelLoginTitulo.Name = "LabelLoginTitulo";
            LabelLoginTitulo.Size = new Size(434, 40);
            LabelLoginTitulo.TabIndex = 1;
            LabelLoginTitulo.Text = "Realizar Login";
            LabelLoginTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(TableLayoutPanelLogin);
            Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(11, 13, 11, 13);
            Name = "PaginaLogin";
            Size = new Size(1024, 720);
            Load += PaginaLogin_Load;
            TableLayoutPanelLogin.ResumeLayout(false);
            StackPanelLogin.ResumeLayout(false);
            StackPanelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelLogin;
        private AntdUI.Button ButtonLoginVoltar;
        private AntdUI.StackPanel StackPanelLogin;
        private AntdUI.Button ButtonLoginEntrar;
        private AntdUI.Input InputSignupSenha;
        private AntdUI.Label LabelLoginSenha;
        private AntdUI.Input InputSignupNome;
        private AntdUI.Label LabelLoginNome;
        private AntdUI.Label LabelLoginTitulo;
    }
}
