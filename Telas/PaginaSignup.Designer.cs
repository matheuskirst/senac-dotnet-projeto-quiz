namespace SenacQuizApp.Features.Cadastro
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
            ButtonSignupVoltar = new AntdUI.Button();
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
            InputSignupNome = new AntdUI.Input();
            LabelSignupNome = new AntdUI.Label();
            LabelSignupTitulo = new AntdUI.Label();
            TableLayoutPanelSignup.SuspendLayout();
            StackPanelSignup.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelSignup
            // 
            TableLayoutPanelSignup.ColumnCount = 3;
            TableLayoutPanelSignup.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSignup.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelSignup.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelSignup.Controls.Add(ButtonSignupVoltar, 1, 2);
            TableLayoutPanelSignup.Controls.Add(StackPanelSignup, 1, 1);
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
            // ButtonSignupVoltar
            // 
            ButtonSignupVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSignupVoltar.Location = new Point(23, 653);
            ButtonSignupVoltar.Name = "ButtonSignupVoltar";
            ButtonSignupVoltar.Radius = 4;
            ButtonSignupVoltar.Size = new Size(137, 44);
            ButtonSignupVoltar.TabIndex = 0;
            ButtonSignupVoltar.Text = "Voltar para Tela Inicial";
            ButtonSignupVoltar.Click += ButtonSignupVoltar_Click;
            // 
            // StackPanelSignup
            // 
            StackPanelSignup.Anchor = AnchorStyles.None;
            StackPanelSignup.Controls.Add(ButtonSignupRegistrar);
            StackPanelSignup.Controls.Add(InputSignupConfirmarSenha);
            StackPanelSignup.Controls.Add(LabelSignupConfirmarSenha);
            StackPanelSignup.Controls.Add(InputSignupSenha);
            StackPanelSignup.Controls.Add(LabelSignupSenha);
            StackPanelSignup.Controls.Add(DatePickerSignupDataNascimento);
            StackPanelSignup.Controls.Add(LabelSignupDataNascimento);
            StackPanelSignup.Controls.Add(InputSignupNick);
            StackPanelSignup.Controls.Add(LabelSignupNick);
            StackPanelSignup.Controls.Add(InputSignupNome);
            StackPanelSignup.Controls.Add(LabelSignupNome);
            StackPanelSignup.Controls.Add(LabelSignupTitulo);
            StackPanelSignup.Location = new Point(292, 32);
            StackPanelSignup.Name = "StackPanelSignup";
            StackPanelSignup.Size = new Size(440, 605);
            StackPanelSignup.TabIndex = 1;
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
            ButtonSignupRegistrar.TabIndex = 23;
            ButtonSignupRegistrar.Text = "Registrar";
            // 
            // InputSignupConfirmarSenha
            // 
            InputSignupConfirmarSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupConfirmarSenha.Location = new Point(0, 438);
            InputSignupConfirmarSenha.Margin = new Padding(0);
            InputSignupConfirmarSenha.Name = "InputSignupConfirmarSenha";
            InputSignupConfirmarSenha.Radius = 4;
            InputSignupConfirmarSenha.Size = new Size(440, 50);
            InputSignupConfirmarSenha.TabIndex = 22;
            // 
            // LabelSignupConfirmarSenha
            // 
            LabelSignupConfirmarSenha.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupConfirmarSenha.Location = new Point(3, 412);
            LabelSignupConfirmarSenha.Name = "LabelSignupConfirmarSenha";
            LabelSignupConfirmarSenha.Size = new Size(434, 23);
            LabelSignupConfirmarSenha.TabIndex = 21;
            LabelSignupConfirmarSenha.TabStop = false;
            LabelSignupConfirmarSenha.Text = "Confirmar Senha";
            // 
            // InputSignupSenha
            // 
            InputSignupSenha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputSignupSenha.Location = new Point(0, 359);
            InputSignupSenha.Margin = new Padding(0);
            InputSignupSenha.Name = "InputSignupSenha";
            InputSignupSenha.Radius = 4;
            InputSignupSenha.Size = new Size(440, 50);
            InputSignupSenha.TabIndex = 20;
            // 
            // LabelSignupSenha
            // 
            LabelSignupSenha.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupSenha.Location = new Point(3, 333);
            LabelSignupSenha.Name = "LabelSignupSenha";
            LabelSignupSenha.Size = new Size(434, 23);
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
            DatePickerSignupDataNascimento.TabIndex = 18;
            // 
            // LabelSignupDataNascimento
            // 
            LabelSignupDataNascimento.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupDataNascimento.Location = new Point(3, 254);
            LabelSignupDataNascimento.Name = "LabelSignupDataNascimento";
            LabelSignupDataNascimento.Size = new Size(434, 23);
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
            InputSignupNick.TabIndex = 5;
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
            // LabelSignupNome
            // 
            LabelSignupNome.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelSignupNome.Location = new Point(3, 96);
            LabelSignupNome.Name = "LabelSignupNome";
            LabelSignupNome.Size = new Size(434, 23);
            LabelSignupNome.TabIndex = 2;
            LabelSignupNome.TabStop = false;
            LabelSignupNome.Text = "Nome de Usuário";
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
        private AntdUI.StackPanel StackPanelSignup;
        private AntdUI.Label LabelSignupNome;
        private AntdUI.Label LabelSignupTitulo;
        private AntdUI.Input input4;
        private AntdUI.Input input3;
        private AntdUI.Input input2;
        private AntdUI.Label LabelSignupNick;
        private AntdUI.Input InputSignupNome;
        private AntdUI.Button ButtonSignupRegistrar;
        private AntdUI.Input InputSignupConfirmarSenha;
        private AntdUI.Label LabelSignupConfirmarSenha;
        private AntdUI.Input InputSignupSenha;
        private AntdUI.Label LabelSignupSenha;
        private AntdUI.DatePicker DatePickerSignupDataNascimento;
        private AntdUI.Label LabelSignupDataNascimento;
        private AntdUI.Input InputSignupNick;
    }
}
