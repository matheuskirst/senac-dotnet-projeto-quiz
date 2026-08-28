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
            StackPanelSignup.SuspendLayout();
            SuspendLayout();
            // 
            // StackPanelSignup
            // 
            StackPanelSignup.Anchor = AnchorStyles.None;
            StackPanelSignup.ColorScheme = AntdUI.TAMode.Dark;
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
            StackPanelSignup.Location = new Point(292, 23);
            StackPanelSignup.Name = "StackPanelSignup";
            StackPanelSignup.Size = new Size(440, 604);
            StackPanelSignup.TabIndex = 3;
            StackPanelSignup.Text = "stackPanel1";
            StackPanelSignup.Vertical = true;
            // 
            // ButtonSignupRegistrar
            // 
            ButtonSignupRegistrar.ColorScheme = AntdUI.TAMode.Dark;
            ButtonSignupRegistrar.DefaultBack = Color.FromArgb(150, 75, 75);
            ButtonSignupRegistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSignupRegistrar.Location = new Point(3, 541);
            ButtonSignupRegistrar.Margin = new Padding(3, 50, 3, 3);
            ButtonSignupRegistrar.Name = "ButtonSignupRegistrar";
            ButtonSignupRegistrar.Size = new Size(434, 60);
            ButtonSignupRegistrar.TabIndex = 5;
            ButtonSignupRegistrar.Text = "Registrar";
            ButtonSignupRegistrar.Click += ButtonSignupRegistrar_Click;
            // 
            // InputSignupConfirmarSenha
            // 
            InputSignupConfirmarSenha.BackColor = Color.FromArgb(77, 84, 92);
            InputSignupConfirmarSenha.BorderColor = Color.FromArgb(77, 84, 92);
            InputSignupConfirmarSenha.ColorScheme = AntdUI.TAMode.Dark;
            InputSignupConfirmarSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupConfirmarSenha.Location = new Point(0, 441);
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
            LabelSignupConfirmarSenha.ColorScheme = AntdUI.TAMode.Dark;
            LabelSignupConfirmarSenha.Font = new Font("Segoe UI", 14.25F);
            LabelSignupConfirmarSenha.Location = new Point(3, 415);
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
            InputSignupSenha.BackColor = Color.FromArgb(77, 84, 92);
            InputSignupSenha.BorderColor = Color.FromArgb(77, 84, 92);
            InputSignupSenha.ColorScheme = AntdUI.TAMode.Dark;
            InputSignupSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupSenha.Location = new Point(0, 362);
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
            LabelSignupSenha.ColorScheme = AntdUI.TAMode.Dark;
            LabelSignupSenha.Font = new Font("Segoe UI", 14.25F);
            LabelSignupSenha.Location = new Point(3, 336);
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
            DatePickerSignupDataNascimento.BackColor = Color.FromArgb(77, 84, 92);
            DatePickerSignupDataNascimento.BorderColor = Color.FromArgb(77, 84, 92);
            DatePickerSignupDataNascimento.ColorScheme = AntdUI.TAMode.Dark;
            DatePickerSignupDataNascimento.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatePickerSignupDataNascimento.Format = "dd/MM/yyyy";
            DatePickerSignupDataNascimento.Location = new Point(0, 283);
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
            LabelSignupDataNascimento.ColorScheme = AntdUI.TAMode.Dark;
            LabelSignupDataNascimento.Font = new Font("Segoe UI", 14.25F);
            LabelSignupDataNascimento.Location = new Point(3, 257);
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
            InputSignupNick.BackColor = Color.FromArgb(77, 84, 92);
            InputSignupNick.BorderColor = Color.FromArgb(77, 84, 92);
            InputSignupNick.ColorScheme = AntdUI.TAMode.Dark;
            InputSignupNick.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupNick.Location = new Point(0, 204);
            InputSignupNick.Margin = new Padding(0);
            InputSignupNick.Name = "InputSignupNick";
            InputSignupNick.Radius = 4;
            InputSignupNick.Size = new Size(440, 50);
            InputSignupNick.TabIndex = 1;
            InputSignupNick.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelSignupNick
            // 
            LabelSignupNick.ColorScheme = AntdUI.TAMode.Dark;
            LabelSignupNick.Font = new Font("Segoe UI", 14.25F);
            LabelSignupNick.Location = new Point(3, 178);
            LabelSignupNick.Name = "LabelSignupNick";
            LabelSignupNick.Size = new Size(434, 23);
            LabelSignupNick.TabIndex = 4;
            LabelSignupNick.TabStop = false;
            LabelSignupNick.Text = "Nickname";
            // 
            // InputSignupUsername
            // 
            InputSignupUsername.BackColor = Color.FromArgb(77, 84, 92);
            InputSignupUsername.BorderColor = Color.FromArgb(77, 84, 92);
            InputSignupUsername.ColorScheme = AntdUI.TAMode.Dark;
            InputSignupUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupUsername.Location = new Point(0, 125);
            InputSignupUsername.Margin = new Padding(0);
            InputSignupUsername.Name = "InputSignupUsername";
            InputSignupUsername.Radius = 4;
            InputSignupUsername.Size = new Size(440, 50);
            InputSignupUsername.TabIndex = 0;
            InputSignupUsername.TextChanged += LimparBorda_TextChanged;
            // 
            // LabelSignupUsername
            // 
            LabelSignupUsername.ColorScheme = AntdUI.TAMode.Dark;
            LabelSignupUsername.Font = new Font("Segoe UI", 14.25F);
            LabelSignupUsername.Location = new Point(3, 99);
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
            LabelSignupTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelSignupTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupTitulo.Location = new Point(3, 3);
            LabelSignupTitulo.Margin = new Padding(3, 3, 3, 50);
            LabelSignupTitulo.MinimumSize = new Size(0, 40);
            LabelSignupTitulo.Name = "LabelSignupTitulo";
            LabelSignupTitulo.Size = new Size(434, 43);
            LabelSignupTitulo.TabIndex = 1;
            LabelSignupTitulo.TabStop = false;
            LabelSignupTitulo.Text = "Criar Conta";
            LabelSignupTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // ButtonSignupVoltar
            // 
            ButtonSignupVoltar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSignupVoltar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSignupVoltar.Location = new Point(23, 633);
            ButtonSignupVoltar.Name = "ButtonSignupVoltar";
            ButtonSignupVoltar.Radius = 4;
            ButtonSignupVoltar.Size = new Size(120, 60);
            ButtonSignupVoltar.TabIndex = 6;
            ButtonSignupVoltar.Text = "Voltar";
            ButtonSignupVoltar.Click += ButtonSignupVoltar_Click;
            // 
            // PaginaSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 64, 70);
            Controls.Add(ButtonSignupVoltar);
            Controls.Add(StackPanelSignup);
            Name = "PaginaSignup";
            Size = new Size(1024, 720);
            Load += PaginaSignup_Load;
            StackPanelSignup.ResumeLayout(false);
            StackPanelSignup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Button ButtonSignupVoltar;
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
