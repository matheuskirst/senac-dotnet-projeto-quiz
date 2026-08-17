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
            StackPanelLogin = new AntdUI.StackPanel();
            StackPanelLoginErro = new AntdUI.StackPanel();
            LabelLoginErro = new AntdUI.Label();
            ButtonLoginEntrar = new AntdUI.Button();
            InputLoginSenha = new AntdUI.Input();
            LabelLoginSenha = new AntdUI.Label();
            InputLoginNome = new AntdUI.Input();
            LabelLoginNome = new AntdUI.Label();
            LabelLoginTitulo = new AntdUI.Label();
            ButtonLoginVoltar = new AntdUI.Button();
            TableLayoutPanelLogin = new TableLayoutPanel();
            StackPanelLogin.SuspendLayout();
            StackPanelLoginErro.SuspendLayout();
            TableLayoutPanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // StackPanelLogin
            // 
            StackPanelLogin.Anchor = AnchorStyles.None;
            StackPanelLogin.Controls.Add(StackPanelLoginErro);
            StackPanelLogin.Controls.Add(ButtonLoginEntrar);
            StackPanelLogin.Controls.Add(InputLoginSenha);
            StackPanelLogin.Controls.Add(LabelLoginSenha);
            StackPanelLogin.Controls.Add(InputLoginNome);
            StackPanelLogin.Controls.Add(LabelLoginNome);
            StackPanelLogin.Controls.Add(LabelLoginTitulo);
            StackPanelLogin.Location = new Point(292, 110);
            StackPanelLogin.Name = "StackPanelLogin";
            StackPanelLogin.Size = new Size(440, 450);
            StackPanelLogin.TabIndex = 1;
            StackPanelLogin.Text = "stackPanel1";
            StackPanelLogin.Vertical = true;
            // 
            // StackPanelLoginErro
            // 
            StackPanelLoginErro.BackColor = Color.Transparent;
            StackPanelLoginErro.BorderColor = Color.Red;
            StackPanelLoginErro.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            StackPanelLoginErro.BorderWidth = 2F;
            StackPanelLoginErro.Controls.Add(LabelLoginErro);
            StackPanelLoginErro.Location = new Point(3, 367);
            StackPanelLoginErro.Name = "StackPanelLoginErro";
            StackPanelLoginErro.Radius = 6;
            StackPanelLoginErro.Size = new Size(434, 50);
            StackPanelLoginErro.TabIndex = 24;
            StackPanelLoginErro.Visible = false;
            // 
            // LabelLoginErro
            // 
            LabelLoginErro.BackColor = Color.Transparent;
            LabelLoginErro.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelLoginErro.Location = new Point(5, 5);
            LabelLoginErro.Name = "LabelLoginErro";
            LabelLoginErro.Size = new Size(428, 40);
            LabelLoginErro.TabIndex = 1;
            LabelLoginErro.Text = "O Nome ou a Senha são inválidos!";
            LabelLoginErro.TextAlign = ContentAlignment.MiddleCenter;
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
            ButtonLoginEntrar.Click += ButtonLoginEntrar_Click;
            // 
            // InputLoginSenha
            // 
            InputLoginSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputLoginSenha.Location = new Point(0, 201);
            InputLoginSenha.Margin = new Padding(0);
            InputLoginSenha.MaxLength = 50;
            InputLoginSenha.Name = "InputLoginSenha";
            InputLoginSenha.Radius = 4;
            InputLoginSenha.Size = new Size(440, 50);
            InputLoginSenha.SuffixText = "Mostrar";
            InputLoginSenha.TabIndex = 20;
            InputLoginSenha.UseSystemPasswordChar = true;
            InputLoginSenha.SuffixClick += InputLoginSenha_SuffixClick;
            InputLoginSenha.TextChanged += LimparBorda_TextChanged;
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
            // InputLoginNome
            // 
            InputLoginNome.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputLoginNome.Location = new Point(0, 122);
            InputLoginNome.Margin = new Padding(0);
            InputLoginNome.Name = "InputLoginNome";
            InputLoginNome.Radius = 4;
            InputLoginNome.Size = new Size(440, 50);
            InputLoginNome.TabIndex = 3;
            InputLoginNome.TextChanged += LimparBorda_TextChanged;
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
            StackPanelLogin.ResumeLayout(false);
            StackPanelLogin.PerformLayout();
            StackPanelLoginErro.ResumeLayout(false);
            TableLayoutPanelLogin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.StackPanel StackPanelLogin;
        private AntdUI.Button ButtonLoginEntrar;
        private AntdUI.Input InputLoginSenha;
        private AntdUI.Label LabelLoginSenha;
        private AntdUI.Input InputLoginNome;
        private AntdUI.Label LabelLoginNome;
        private AntdUI.Label LabelLoginTitulo;
        private AntdUI.Button ButtonLoginVoltar;
        private TableLayoutPanel TableLayoutPanelLogin;
        private AntdUI.StackPanel StackPanelLoginErro;
        private AntdUI.Label LabelLoginErro;
    }
}
