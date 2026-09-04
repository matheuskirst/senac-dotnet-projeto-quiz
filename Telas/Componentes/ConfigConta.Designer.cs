namespace SenacQuizApp.Telas.Componentes
{
    partial class ConfigConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigConta));
            LabelConfiguracoes = new AntdUI.Label();
            PanelNickname = new AntdUI.Panel();
            ButtonSalvarNickname = new AntdUI.Button();
            LabelInfo = new AntdUI.Label();
            InputNickname = new AntdUI.Input();
            ButtonEditarNickname = new AntdUI.Button();
            LabelNickname = new AntdUI.Label();
            PanelCentral = new AntdUI.Panel();
            PanelSenha = new AntdUI.Panel();
            ButtonSalvarSenha = new AntdUI.Button();
            InputConfirmarSenha = new PasswordInput();
            LabelConfirmarSenha = new AntdUI.Label();
            InputNovaSenha = new PasswordInput();
            LabelNovaSenha = new AntdUI.Label();
            InputSenhaAtual = new PasswordInput();
            LabelSenhaAtual = new AntdUI.Label();
            LabelSenha = new AntdUI.Label();
            PanelNickname.SuspendLayout();
            PanelCentral.SuspendLayout();
            PanelSenha.SuspendLayout();
            SuspendLayout();
            // 
            // LabelConfiguracoes
            // 
            LabelConfiguracoes.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelConfiguracoes.BackColor = Color.Transparent;
            LabelConfiguracoes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelConfiguracoes.ForeColor = Color.White;
            LabelConfiguracoes.Location = new Point(13, 12);
            LabelConfiguracoes.Margin = new Padding(2);
            LabelConfiguracoes.Name = "LabelConfiguracoes";
            LabelConfiguracoes.Size = new Size(67, 35);
            LabelConfiguracoes.TabIndex = 9;
            LabelConfiguracoes.Text = "Conta";
            // 
            // PanelNickname
            // 
            PanelNickname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelNickname.Back = Color.FromArgb(33, 33, 33);
            PanelNickname.Controls.Add(ButtonSalvarNickname);
            PanelNickname.Controls.Add(LabelInfo);
            PanelNickname.Controls.Add(InputNickname);
            PanelNickname.Controls.Add(ButtonEditarNickname);
            PanelNickname.Controls.Add(LabelNickname);
            PanelNickname.Location = new Point(13, 76);
            PanelNickname.Name = "PanelNickname";
            PanelNickname.Padding = new Padding(10);
            PanelNickname.Radius = 0;
            PanelNickname.Size = new Size(574, 200);
            PanelNickname.TabIndex = 10;
            // 
            // ButtonSalvarNickname
            // 
            ButtonSalvarNickname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSalvarNickname.BorderWidth = 2F;
            ButtonSalvarNickname.ColorScheme = AntdUI.TAMode.Dark;
            ButtonSalvarNickname.Enabled = false;
            ButtonSalvarNickname.Font = new Font("Segoe UI", 12F);
            ButtonSalvarNickname.Location = new Point(445, 50);
            ButtonSalvarNickname.Name = "ButtonSalvarNickname";
            ButtonSalvarNickname.Size = new Size(116, 40);
            ButtonSalvarNickname.TabIndex = 8;
            ButtonSalvarNickname.Text = "Salvar";
            ButtonSalvarNickname.Type = AntdUI.TTypeMini.Primary;
            ButtonSalvarNickname.Visible = false;
            ButtonSalvarNickname.Click += ButtonSalvarNickname_Click;
            // 
            // LabelInfo
            // 
            LabelInfo.AutoSizeMode = AntdUI.TAutoSize.Auto;
            LabelInfo.BackColor = Color.Transparent;
            LabelInfo.ColorScheme = AntdUI.TAMode.Dark;
            LabelInfo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelInfo.Location = new Point(13, 11);
            LabelInfo.Name = "LabelInfo";
            LabelInfo.Size = new Size(112, 26);
            LabelInfo.TabIndex = 3;
            LabelInfo.Text = "Informações:";
            // 
            // InputNickname
            // 
            InputNickname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InputNickname.BackColor = Color.FromArgb(31, 31, 31);
            InputNickname.ColorScheme = AntdUI.TAMode.Dark;
            InputNickname.Enabled = false;
            InputNickname.Font = new Font("Microsoft Sans Serif", 12F);
            InputNickname.Location = new Point(159, 50);
            InputNickname.Name = "InputNickname";
            InputNickname.PlaceholderText = "nickname";
            InputNickname.ReadOnly = true;
            InputNickname.Size = new Size(190, 40);
            InputNickname.TabIndex = 1;
            InputNickname.TextAlign = HorizontalAlignment.Right;
            InputNickname.TextChanged += InputNickname_TextChanged;
            InputNickname.Leave += InputNickname_Leave;
            // 
            // ButtonEditarNickname
            // 
            ButtonEditarNickname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonEditarNickname.BorderWidth = 2F;
            ButtonEditarNickname.ColorScheme = AntdUI.TAMode.Dark;
            ButtonEditarNickname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonEditarNickname.Ghost = true;
            ButtonEditarNickname.Location = new Point(349, 50);
            ButtonEditarNickname.Name = "ButtonEditarNickname";
            ButtonEditarNickname.Size = new Size(90, 40);
            ButtonEditarNickname.TabIndex = 2;
            ButtonEditarNickname.Text = "Editar";
            ButtonEditarNickname.Click += ButtonEditarNickname_Click;
            // 
            // LabelNickname
            // 
            LabelNickname.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelNickname.BackColor = Color.Transparent;
            LabelNickname.ColorScheme = AntdUI.TAMode.Dark;
            LabelNickname.Font = new Font("Microsoft Sans Serif", 12F);
            LabelNickname.Location = new Point(13, 50);
            LabelNickname.Name = "LabelNickname";
            LabelNickname.Size = new Size(76, 40);
            LabelNickname.TabIndex = 0;
            LabelNickname.Text = "Nickname:";
            // 
            // PanelCentral
            // 
            PanelCentral.AutoScroll = true;
            PanelCentral.Back = Color.FromArgb(45, 45, 45);
            PanelCentral.Controls.Add(PanelSenha);
            PanelCentral.Controls.Add(LabelConfiguracoes);
            PanelCentral.Controls.Add(PanelNickname);
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Font = new Font("Segoe UI", 12F);
            PanelCentral.Location = new Point(0, 0);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Padding = new Padding(10);
            PanelCentral.Size = new Size(600, 600);
            PanelCentral.TabIndex = 12;
            PanelCentral.Text = "panel1";
            // 
            // PanelSenha
            // 
            PanelSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelSenha.Back = Color.FromArgb(33, 33, 33);
            PanelSenha.Controls.Add(ButtonSalvarSenha);
            PanelSenha.Controls.Add(InputConfirmarSenha);
            PanelSenha.Controls.Add(LabelConfirmarSenha);
            PanelSenha.Controls.Add(InputNovaSenha);
            PanelSenha.Controls.Add(LabelNovaSenha);
            PanelSenha.Controls.Add(InputSenhaAtual);
            PanelSenha.Controls.Add(LabelSenhaAtual);
            PanelSenha.Controls.Add(LabelSenha);
            PanelSenha.Location = new Point(13, 296);
            PanelSenha.Name = "PanelSenha";
            PanelSenha.Padding = new Padding(10);
            PanelSenha.Radius = 0;
            PanelSenha.Size = new Size(574, 290);
            PanelSenha.TabIndex = 12;
            // 
            // ButtonSalvarSenha
            // 
            ButtonSalvarSenha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSalvarSenha.BorderWidth = 2F;
            ButtonSalvarSenha.ColorScheme = AntdUI.TAMode.Dark;
            ButtonSalvarSenha.Font = new Font("Segoe UI", 12F);
            ButtonSalvarSenha.Location = new Point(219, 198);
            ButtonSalvarSenha.Name = "ButtonSalvarSenha";
            ButtonSalvarSenha.Size = new Size(160, 40);
            ButtonSalvarSenha.TabIndex = 7;
            ButtonSalvarSenha.Text = "Salvar";
            ButtonSalvarSenha.Type = AntdUI.TTypeMini.Primary;
            ButtonSalvarSenha.Click += ButtonSalvarSenha_Click;
            // 
            // InputConfirmarSenha
            // 
            InputConfirmarSenha.AcceptsEscape = true;
            InputConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InputConfirmarSenha.BackColor = Color.FromArgb(31, 31, 31);
            InputConfirmarSenha.ColorScheme = AntdUI.TAMode.Dark;
            InputConfirmarSenha.Font = new Font("Segoe UI", 12F);
            InputConfirmarSenha.Location = new Point(159, 152);
            InputConfirmarSenha.Name = "InputConfirmarSenha";
            InputConfirmarSenha.PlaceholderText = "";
            InputConfirmarSenha.RightToLeft = RightToLeft.No;
            InputConfirmarSenha.Size = new Size(280, 40);
            InputConfirmarSenha.SuffixSvg = resources.GetString("InputConfirmarSenha.SuffixSvg");
            InputConfirmarSenha.TabIndex = 6;
            InputConfirmarSenha.UseSystemPasswordChar = true;
            InputConfirmarSenha.SuffixClick += InputSenha_SuffixClick;
            // 
            // LabelConfirmarSenha
            // 
            LabelConfirmarSenha.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelConfirmarSenha.BackColor = Color.Transparent;
            LabelConfirmarSenha.ColorScheme = AntdUI.TAMode.Dark;
            LabelConfirmarSenha.Font = new Font("Segoe UI", 12F);
            LabelConfirmarSenha.Location = new Point(13, 152);
            LabelConfirmarSenha.Name = "LabelConfirmarSenha";
            LabelConfirmarSenha.Size = new Size(143, 40);
            LabelConfirmarSenha.Suffix = " ";
            LabelConfirmarSenha.TabIndex = 5;
            LabelConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // InputNovaSenha
            // 
            InputNovaSenha.AcceptsEscape = true;
            InputNovaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InputNovaSenha.BackColor = Color.FromArgb(31, 31, 31);
            InputNovaSenha.ColorScheme = AntdUI.TAMode.Dark;
            InputNovaSenha.Font = new Font("Segoe UI", 12F);
            InputNovaSenha.Location = new Point(159, 106);
            InputNovaSenha.Name = "InputNovaSenha";
            InputNovaSenha.PlaceholderText = "";
            InputNovaSenha.RightToLeft = RightToLeft.No;
            InputNovaSenha.Size = new Size(280, 40);
            InputNovaSenha.SuffixSvg = resources.GetString("InputNovaSenha.SuffixSvg");
            InputNovaSenha.TabIndex = 4;
            InputNovaSenha.UseSystemPasswordChar = true;
            InputNovaSenha.SuffixClick += InputSenha_SuffixClick;
            // 
            // LabelNovaSenha
            // 
            LabelNovaSenha.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelNovaSenha.BackColor = Color.Transparent;
            LabelNovaSenha.ColorScheme = AntdUI.TAMode.Dark;
            LabelNovaSenha.Font = new Font("Segoe UI", 12F);
            LabelNovaSenha.Location = new Point(13, 106);
            LabelNovaSenha.Name = "LabelNovaSenha";
            LabelNovaSenha.Size = new Size(106, 40);
            LabelNovaSenha.Suffix = " ";
            LabelNovaSenha.TabIndex = 3;
            LabelNovaSenha.Text = "Nova Senha:";
            // 
            // InputSenhaAtual
            // 
            InputSenhaAtual.AcceptsEscape = true;
            InputSenhaAtual.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InputSenhaAtual.BackColor = Color.FromArgb(31, 31, 31);
            InputSenhaAtual.ColorScheme = AntdUI.TAMode.Dark;
            InputSenhaAtual.Font = new Font("Segoe UI", 12F);
            InputSenhaAtual.Location = new Point(159, 60);
            InputSenhaAtual.Name = "InputSenhaAtual";
            InputSenhaAtual.PlaceholderText = "";
            InputSenhaAtual.RightToLeft = RightToLeft.No;
            InputSenhaAtual.Size = new Size(280, 40);
            InputSenhaAtual.SuffixSvg = resources.GetString("InputSenhaAtual.SuffixSvg");
            InputSenhaAtual.TabIndex = 2;
            InputSenhaAtual.UseSystemPasswordChar = true;
            InputSenhaAtual.SuffixClick += InputSenha_SuffixClick;
            // 
            // LabelSenhaAtual
            // 
            LabelSenhaAtual.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelSenhaAtual.BackColor = Color.Transparent;
            LabelSenhaAtual.ColorScheme = AntdUI.TAMode.Dark;
            LabelSenhaAtual.Font = new Font("Segoe UI", 12F);
            LabelSenhaAtual.Location = new Point(13, 60);
            LabelSenhaAtual.Name = "LabelSenhaAtual";
            LabelSenhaAtual.Size = new Size(105, 40);
            LabelSenhaAtual.Suffix = " ";
            LabelSenhaAtual.TabIndex = 1;
            LabelSenhaAtual.Text = "Senha Atual:";
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSizeMode = AntdUI.TAutoSize.Auto;
            LabelSenha.BackColor = Color.Transparent;
            LabelSenha.ColorScheme = AntdUI.TAMode.Dark;
            LabelSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSenha.Location = new Point(13, 13);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(118, 26);
            LabelSenha.TabIndex = 0;
            LabelSenha.Text = "Trocar Senha:";
            // 
            // ConfigConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            Controls.Add(PanelCentral);
            MinimumSize = new Size(600, 400);
            Name = "ConfigConta";
            Size = new Size(600, 600);
            Load += ConfigConta_Load;
            PanelNickname.ResumeLayout(false);
            PanelNickname.PerformLayout();
            PanelCentral.ResumeLayout(false);
            PanelCentral.PerformLayout();
            PanelSenha.ResumeLayout(false);
            PanelSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelConfiguracoes;
        private AntdUI.Panel PanelNickname;
        private AntdUI.Label LabelNickname;
        private AntdUI.Input InputNickname;
        private AntdUI.Button ButtonEditarNickname;
        private AntdUI.Panel panel1;
        private PasswordInput InputSenhaAtual;
        private AntdUI.Button ButtonSalvarSenha;
        private AntdUI.Panel PanelCentral;
        private AntdUI.Panel PanelSenha;
        private AntdUI.Label LabelSenha;
        private AntdUI.Label LabelSenhaAtual;
        private PasswordInput InputConfirmarSenha;
        private AntdUI.Label LabelConfirmarSenha;
        private PasswordInput InputNovaSenha;
        private AntdUI.Label LabelNovaSenha;
        private AntdUI.Label LabelInfo;
        private AntdUI.Button ButtonSalvarNickname;
    }
}
