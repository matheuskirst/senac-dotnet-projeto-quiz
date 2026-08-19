namespace SenacQuizApp.Telas
{
    partial class PaginaSignup
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
            TableLayoutPanelSignup = new TableLayoutPanel();
            StackPanelSignup = new AntdUI.StackPanel();
            ButtonSignupRegistrar = new AntdUI.Button();
            InputSignupConfirmarSenha = new AntdUI.Input();
            LabelSignupConfirmarSenha = new AntdUI.Label();
            InputSignupSenha = new AntdUI.Input();
            LabelSignupSenha = new AntdUI.Label();
            DatePickerSignupDataNascimento = new AntdUI.DatePicker();
            LabelSignupDataNascimento = new AntdUI.Label();
            InputSignupNick = new AntdUI.Input();
            LabelSignupNick = new AntdUI.Label();
            InputSignupUsername = new AntdUI.Input();
            LabelSignupUsername = new AntdUI.Label();
            LabelSignupTitulo = new AntdUI.Label();
            ButtonSignupVoltar = new AntdUI.Button();
            TableLayoutPanelSignup.SuspendLayout();
            StackPanelSignup.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelSignup
            // 
            TableLayoutPanelSignup.BackColor = Color.Transparent;
            TableLayoutPanelSignup.ColumnCount = 3;
            TableLayoutPanelSignup.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSignup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelSignup.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSignup.Controls.Add(StackPanelSignup, 1, 1);
            TableLayoutPanelSignup.Controls.Add(ButtonSignupVoltar, 1, 2);
            TableLayoutPanelSignup.Dock = DockStyle.Fill;
            TableLayoutPanelSignup.Location = new Point(0, 0);
            TableLayoutPanelSignup.Name = "TableLayoutPanelSignup";
            TableLayoutPanelSignup.RowCount = 4;
            TableLayoutPanelSignup.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSignup.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelSignup.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TableLayoutPanelSignup.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSignup.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSignup.Size = new Size(1024, 720);
            TableLayoutPanelSignup.TabIndex = 0;
            // 
            // StackPanelSignup
            // 
            StackPanelSignup.Anchor = AnchorStyles.None;
            StackPanelSignup.AutoScroll = true;
            StackPanelSignup.Controls.Add(ButtonSignupRegistrar);
            StackPanelSignup.Controls.Add(InputSignupConfirmarSenha);
            StackPanelSignup.Controls.Add(LabelSignupConfirmarSenha);
            StackPanelSignup.Controls.Add(InputSignupSenha);
            StackPanelSignup.Controls.Add(LabelSignupSenha);
            StackPanelSignup.Controls.Add(DatePickerSignupDataNascimento);
            StackPanelSignup.Controls.Add(LabelSignupDataNascimento);
            StackPanelSignup.Controls.Add(InputSignupNick);
            StackPanelSignup.Controls.Add(LabelSignupNick);
            StackPanelSignup.Controls.Add(InputSignupUsername);
            StackPanelSignup.Controls.Add(LabelSignupUsername);
            StackPanelSignup.Controls.Add(LabelSignupTitulo);
            StackPanelSignup.Location = new Point(292, 32);
            StackPanelSignup.Name = "StackPanelSignup";
            StackPanelSignup.Size = new Size(440, 605);
            StackPanelSignup.TabIndex = 3;
            StackPanelSignup.Text = "stackPanel1";
            StackPanelSignup.Vertical = true;
            // 
            // ButtonSignupRegistrar
            // 
            ButtonSignupRegistrar.DefaultBack = Color.Wheat;
            ButtonSignupRegistrar.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSignupRegistrar.Location = new Point(3, 538);
            ButtonSignupRegistrar.Margin = new Padding(3, 50, 3, 3);
            ButtonSignupRegistrar.Name = "ButtonSignupRegistrar";
            ButtonSignupRegistrar.Size = new Size(434, 60);
            ButtonSignupRegistrar.TabIndex = 5;
            ButtonSignupRegistrar.Text = "Registrar";
            ButtonSignupRegistrar.Click += ButtonSignupRegistrar_Click;
            // 
            // InputSignupConfirmarSenha
            // 
            InputSignupConfirmarSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupConfirmarSenha.Location = new Point(0, 438);
            InputSignupConfirmarSenha.Margin = new Padding(0);
            InputSignupConfirmarSenha.MaxLength = 50;
            InputSignupConfirmarSenha.Name = "InputSignupConfirmarSenha";
            InputSignupConfirmarSenha.Radius = 4;
            InputSignupConfirmarSenha.Size = new Size(440, 50);
            InputSignupConfirmarSenha.SuffixText = "Mostrar";
            InputSignupConfirmarSenha.TabIndex = 4;
            InputSignupConfirmarSenha.UseSystemPasswordChar = true;
            InputSignupConfirmarSenha.SuffixClick += InputSignupConfirmarSenha_SuffixClick;
            InputSignupConfirmarSenha.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelSignupConfirmarSenha
            // 
            LabelSignupConfirmarSenha.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupConfirmarSenha.Location = new Point(3, 412);
            LabelSignupConfirmarSenha.Name = "LabelSignupConfirmarSenha";
            LabelSignupConfirmarSenha.Size = new Size(434, 23);
            LabelSignupConfirmarSenha.Suffix = "*";
            LabelSignupConfirmarSenha.SuffixColor = Color.Red;
            LabelSignupConfirmarSenha.TabIndex = 21;
            LabelSignupConfirmarSenha.TabStop = false;
            LabelSignupConfirmarSenha.Text = "Confirmar Senha";
            // 
            // InputSignupSenha
            // 
            InputSignupSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupSenha.Location = new Point(0, 359);
            InputSignupSenha.Margin = new Padding(0);
            InputSignupSenha.MaxLength = 50;
            InputSignupSenha.Name = "InputSignupSenha";
            InputSignupSenha.Radius = 4;
            InputSignupSenha.Size = new Size(440, 50);
            InputSignupSenha.SuffixSvg = "";
            InputSignupSenha.SuffixText = "Mostrar";
            InputSignupSenha.TabIndex = 3;
            InputSignupSenha.UseSystemPasswordChar = true;
            InputSignupSenha.SuffixClick += InputSignupSenha_SuffixClick;
            InputSignupSenha.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelSignupSenha
            // 
            LabelSignupSenha.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupSenha.Location = new Point(3, 333);
            LabelSignupSenha.Name = "LabelSignupSenha";
            LabelSignupSenha.Size = new Size(434, 23);
            LabelSignupSenha.Suffix = "*";
            LabelSignupSenha.SuffixColor = Color.Red;
            LabelSignupSenha.TabIndex = 19;
            LabelSignupSenha.TabStop = false;
            LabelSignupSenha.Text = "Senha";
            // 
            // DatePickerSignupDataNascimento
            // 
            DatePickerSignupDataNascimento.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatePickerSignupDataNascimento.Format = "dd/MM/yyyy";
            DatePickerSignupDataNascimento.Location = new Point(0, 280);
            DatePickerSignupDataNascimento.Margin = new Padding(0);
            DatePickerSignupDataNascimento.Name = "DatePickerSignupDataNascimento";
            DatePickerSignupDataNascimento.PlaceholderText = "DD/MM/AAAA";
            DatePickerSignupDataNascimento.Radius = 4;
            DatePickerSignupDataNascimento.Size = new Size(440, 50);
            DatePickerSignupDataNascimento.TabIndex = 2;
            DatePickerSignupDataNascimento.TextChanged += LimparBorda_TextChanged;
            DatePickerSignupDataNascimento.KeyDown += DatePickerSignupDataNascimento_KeyDown;
            // 
            // LabelSignupDataNascimento
            // 
            LabelSignupDataNascimento.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupDataNascimento.Location = new Point(3, 254);
            LabelSignupDataNascimento.Name = "LabelSignupDataNascimento";
            LabelSignupDataNascimento.Size = new Size(434, 23);
            LabelSignupDataNascimento.Suffix = "*";
            LabelSignupDataNascimento.SuffixColor = Color.Red;
            LabelSignupDataNascimento.TabIndex = 17;
            LabelSignupDataNascimento.TabStop = false;
            LabelSignupDataNascimento.Text = "Data de Nascimento";
            // 
            // InputSignupNick
            // 
            InputSignupNick.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupNick.Location = new Point(0, 201);
            InputSignupNick.Margin = new Padding(0);
            InputSignupNick.Name = "InputSignupNick";
            InputSignupNick.Radius = 4;
            InputSignupNick.Size = new Size(440, 50);
            InputSignupNick.TabIndex = 1;
            InputSignupNick.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelSignupNick
            // 
            LabelSignupNick.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupNick.Location = new Point(3, 175);
            LabelSignupNick.Name = "LabelSignupNick";
            LabelSignupNick.Size = new Size(434, 23);
            LabelSignupNick.TabIndex = 4;
            LabelSignupNick.TabStop = false;
            LabelSignupNick.Text = "Nickname";
            // 
            // InputSignupUsername
            // 
            InputSignupUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupUsername.Location = new Point(0, 122);
            InputSignupUsername.Margin = new Padding(0);
            InputSignupUsername.Name = "InputSignupUsername";
            InputSignupUsername.Radius = 4;
            InputSignupUsername.Size = new Size(440, 50);
            InputSignupUsername.TabIndex = 0;
            InputSignupUsername.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelSignupUsername
            // 
            LabelSignupUsername.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupUsername.Location = new Point(3, 96);
            LabelSignupUsername.Name = "LabelSignupUsername";
            LabelSignupUsername.Prefix = "";
            LabelSignupUsername.Size = new Size(434, 23);
            LabelSignupUsername.Suffix = "*";
            LabelSignupUsername.SuffixColor = Color.Red;
            LabelSignupUsername.TabIndex = 2;
            LabelSignupUsername.TabStop = false;
            LabelSignupUsername.Text = "Nome de Usuário";
            // 
            // LabelSignupTitulo
            // 
            LabelSignupTitulo.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelSignupTitulo.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupTitulo.Location = new Point(3, 3);
            LabelSignupTitulo.Margin = new Padding(3, 3, 3, 50);
            LabelSignupTitulo.MinimumSize = new Size(0, 40);
            LabelSignupTitulo.Name = "LabelSignupTitulo";
            LabelSignupTitulo.Size = new Size(434, 40);
            LabelSignupTitulo.TabIndex = 1;
            LabelSignupTitulo.TabStop = false;
            LabelSignupTitulo.Text = "Criar Conta";
            LabelSignupTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // ButtonSignupVoltar
            // 
            ButtonSignupVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSignupVoltar.Location = new Point(23, 653);
            ButtonSignupVoltar.Name = "ButtonSignupVoltar";
            ButtonSignupVoltar.Radius = 4;
            ButtonSignupVoltar.Size = new Size(137, 44);
            ButtonSignupVoltar.TabIndex = 6;
            ButtonSignupVoltar.Text = "Voltar para Tela Inicial";
            ButtonSignupVoltar.Click += ButtonSignupVoltar_Click;
            // 
            // PaginaSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanelSignup);
            Name = "PaginaSignup";
            Size = new Size(1024, 720);
            Load += PaginaSignup_Load;
            TableLayoutPanelSignup.ResumeLayout(false);
            StackPanelSignup.ResumeLayout(false);
            StackPanelSignup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelSignup;
        private AntdUI.Button ButtonSignupVoltar;
        private AntdUI.Input input4;
        private AntdUI.Input input3;
        private AntdUI.Input input2;
        private AntdUI.StackPanel StackPanelSignup;
        private AntdUI.Label LabelSignupUsername;
        private AntdUI.Label LabelSignupTitulo;
        private AntdUI.Button ButtonSignupRegistrar;
        private AntdUI.Input InputSignupConfirmarSenha;
        private AntdUI.Label LabelSignupConfirmarSenha;
        private AntdUI.Input InputSignupSenha;
        private AntdUI.Label LabelSignupSenha;
        private AntdUI.DatePicker DatePickerSignupDataNascimento;
        private AntdUI.Label LabelSignupDataNascimento;
        private AntdUI.Input InputSignupNick;
        private AntdUI.Label LabelSignupNick;
        private AntdUI.Input InputSignupUsername;
    }
}
