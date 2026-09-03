namespace SenacQuizApp.Telas
{
    partial class PaginaConfig
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void PaginaConfig_Resize(object sender, EventArgs e)
        {
            int x = Math.Max(0, (this.ClientSize.Width - panelCentral.Width) / 2);
            int y = Math.Max(0, (this.ClientSize.Height - panelCentral.Height) / 2);

            panelCentral.Location = new Point(x, y);
        }

        private void InitializeComponent()
        {
            panelCentral = new AntdUI.Panel();
            lblTituloMain = new AntdUI.Label();
            lblSecaoDados = new AntdUI.Label();
            lblNickname = new AntdUI.Label();
            txtNickname = new AntdUI.Input();
            btnMudarNickname = new AntdUI.Button();
            lblSenhaAtual = new AntdUI.Label();
            txtSenhaAtual = new AntdUI.Input();
            lblNovSenha = new AntdUI.Label();
            txtNovSenha = new AntdUI.Input();
            lblConfirmarSenha = new AntdUI.Label();
            txtConfirmarSenha = new AntdUI.Input();
            btnTrocarSenha = new AntdUI.Button();
            PageHeader = new AntdUI.PageHeader();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.Back = Color.FromArgb(33, 33, 33);
            panelCentral.BorderColor = Color.FromArgb(42, 42, 42);
            panelCentral.Controls.Add(lblTituloMain);
            panelCentral.Controls.Add(lblSecaoDados);
            panelCentral.Controls.Add(lblNickname);
            panelCentral.Controls.Add(txtNickname);
            panelCentral.Controls.Add(btnMudarNickname);
            panelCentral.Controls.Add(lblSenhaAtual);
            panelCentral.Controls.Add(txtSenhaAtual);
            panelCentral.Controls.Add(lblNovSenha);
            panelCentral.Controls.Add(txtNovSenha);
            panelCentral.Controls.Add(lblConfirmarSenha);
            panelCentral.Controls.Add(txtConfirmarSenha);
            panelCentral.Controls.Add(btnTrocarSenha);
            panelCentral.Location = new Point(182, 76);
            panelCentral.Margin = new Padding(2);
            panelCentral.Name = "panelCentral";
            panelCentral.Radius = 4;
            panelCentral.Size = new Size(420, 408);
            panelCentral.TabIndex = 0;
            // 
            // lblTituloMain
            // 
            lblTituloMain.BackColor = Color.Transparent;
            lblTituloMain.Font = new Font("Segoe UI", 18F);
            lblTituloMain.ForeColor = Color.White;
            lblTituloMain.Location = new Point(28, 15);
            lblTituloMain.Margin = new Padding(2);
            lblTituloMain.Name = "lblTituloMain";
            lblTituloMain.Size = new Size(364, 24);
            lblTituloMain.TabIndex = 0;
            lblTituloMain.Text = "Gerenciamento de Conta";
            // 
            // lblSecaoDados
            // 
            lblSecaoDados.BackColor = Color.Transparent;
            lblSecaoDados.Font = new Font("Segoe UI", 12F);
            lblSecaoDados.ForeColor = Color.FromArgb(74, 222, 128);
            lblSecaoDados.Location = new Point(28, 51);
            lblSecaoDados.Margin = new Padding(2);
            lblSecaoDados.Name = "lblSecaoDados";
            lblSecaoDados.Size = new Size(364, 18);
            lblSecaoDados.TabIndex = 1;
            // 
            // lblNickname
            // 
            lblNickname.BackColor = Color.Transparent;
            lblNickname.Font = new Font("Segoe UI", 9.5F);
            lblNickname.ForeColor = Color.White;
            lblNickname.Location = new Point(28, 72);
            lblNickname.Margin = new Padding(2);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(224, 13);
            lblNickname.TabIndex = 2;
            lblNickname.Text = "Novo Nickname";
            // 
            // txtNickname
            // 
            txtNickname.BackColor = Color.FromArgb(45, 45, 45);
            txtNickname.BorderActive = Color.FromArgb(75, 150, 75);
            txtNickname.BorderColor = Color.Transparent;
            txtNickname.BorderHover = Color.FromArgb(75, 150, 75);
            txtNickname.Font = new Font("Segoe UI", 9F);
            txtNickname.ForeColor = Color.White;
            txtNickname.Location = new Point(28, 87);
            txtNickname.Margin = new Padding(2);
            txtNickname.Name = "txtNickname";
            txtNickname.Radius = 2;
            txtNickname.Size = new Size(224, 27);
            txtNickname.TabIndex = 3;
            // 
            // btnMudarNickname
            // 
            btnMudarNickname.DefaultBack = Color.FromArgb(75, 150, 75);
            btnMudarNickname.Font = new Font("Segoe UI", 10F);
            btnMudarNickname.ForeColor = Color.White;
            btnMudarNickname.Location = new Point(284, 87);
            btnMudarNickname.Margin = new Padding(2);
            btnMudarNickname.Name = "btnMudarNickname";
            btnMudarNickname.Radius = 2;
            btnMudarNickname.Size = new Size(108, 27);
            btnMudarNickname.TabIndex = 2;
            btnMudarNickname.Text = "Redefinir";
            btnMudarNickname.Click += btnMudarNickname_Click;
            // 
            // lblSenhaAtual
            // 
            lblSenhaAtual.BackColor = Color.Transparent;
            lblSenhaAtual.Font = new Font("Segoe UI", 9.5F);
            lblSenhaAtual.ForeColor = Color.White;
            lblSenhaAtual.Location = new Point(28, 144);
            lblSenhaAtual.Margin = new Padding(2);
            lblSenhaAtual.Name = "lblSenhaAtual";
            lblSenhaAtual.Size = new Size(364, 13);
            lblSenhaAtual.TabIndex = 4;
            lblSenhaAtual.Text = "Senha Atual";
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.BackColor = Color.FromArgb(45, 45, 45);
            txtSenhaAtual.BorderActive = Color.FromArgb(75, 150, 75);
            txtSenhaAtual.BorderColor = Color.Transparent;
            txtSenhaAtual.BorderHover = Color.FromArgb(75, 150, 75);
            txtSenhaAtual.Font = new Font("Segoe UI", 9F);
            txtSenhaAtual.ForeColor = Color.White;
            txtSenhaAtual.Location = new Point(28, 159);
            txtSenhaAtual.Margin = new Padding(2);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.Radius = 2;
            txtSenhaAtual.Size = new Size(364, 27);
            txtSenhaAtual.SuffixSvg = "EyeOutlined";
            txtSenhaAtual.TabIndex = 3;
            txtSenhaAtual.UseSystemPasswordChar = true;
            txtSenhaAtual.SuffixClick += AlternarVisibilidadeSenha;
            // 
            // lblNovSenha
            // 
            lblNovSenha.BackColor = Color.Transparent;
            lblNovSenha.Font = new Font("Segoe UI", 9.5F);
            lblNovSenha.ForeColor = Color.White;
            lblNovSenha.Location = new Point(28, 189);
            lblNovSenha.Margin = new Padding(2);
            lblNovSenha.Name = "lblNovSenha";
            lblNovSenha.Size = new Size(364, 13);
            lblNovSenha.TabIndex = 5;
            lblNovSenha.Text = "Nova Senha";
            // 
            // txtNovSenha
            // 
            txtNovSenha.BackColor = Color.FromArgb(45, 45, 45);
            txtNovSenha.BorderActive = Color.FromArgb(75, 150, 75);
            txtNovSenha.BorderColor = Color.Transparent;
            txtNovSenha.BorderHover = Color.FromArgb(75, 150, 75);
            txtNovSenha.Font = new Font("Segoe UI", 9F);
            txtNovSenha.ForeColor = Color.White;
            txtNovSenha.Location = new Point(28, 204);
            txtNovSenha.Margin = new Padding(2);
            txtNovSenha.Name = "txtNovSenha";
            txtNovSenha.Radius = 2;
            txtNovSenha.Size = new Size(364, 27);
            txtNovSenha.SuffixSvg = "EyeOutlined";
            txtNovSenha.TabIndex = 4;
            txtNovSenha.UseSystemPasswordChar = true;
            txtNovSenha.SuffixClick += AlternarVisibilidadeSenha;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.BackColor = Color.Transparent;
            lblConfirmarSenha.Font = new Font("Segoe UI", 9.5F);
            lblConfirmarSenha.ForeColor = Color.White;
            lblConfirmarSenha.Location = new Point(28, 234);
            lblConfirmarSenha.Margin = new Padding(2);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(364, 13);
            lblConfirmarSenha.TabIndex = 6;
            lblConfirmarSenha.Text = "Confirmar Nova Senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.BackColor = Color.FromArgb(45, 45, 45);
            txtConfirmarSenha.BorderActive = Color.FromArgb(75, 150, 75);
            txtConfirmarSenha.BorderColor = Color.Transparent;
            txtConfirmarSenha.BorderHover = Color.FromArgb(75, 150, 75);
            txtConfirmarSenha.Font = new Font("Segoe UI", 9F);
            txtConfirmarSenha.ForeColor = Color.White;
            txtConfirmarSenha.Location = new Point(28, 249);
            txtConfirmarSenha.Margin = new Padding(2);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Radius = 2;
            txtConfirmarSenha.Size = new Size(364, 27);
            txtConfirmarSenha.SuffixSvg = "EyeOutlined";
            txtConfirmarSenha.TabIndex = 5;
            txtConfirmarSenha.UseSystemPasswordChar = true;
            txtConfirmarSenha.SuffixClick += AlternarVisibilidadeSenha;
            // 
            // btnTrocarSenha
            // 
            btnTrocarSenha.DefaultBack = Color.FromArgb(75, 150, 75);
            btnTrocarSenha.Font = new Font("Segoe UI", 11F);
            btnTrocarSenha.ForeColor = Color.White;
            btnTrocarSenha.Location = new Point(28, 288);
            btnTrocarSenha.Margin = new Padding(2);
            btnTrocarSenha.Name = "btnTrocarSenha";
            btnTrocarSenha.Radius = 2;
            btnTrocarSenha.Size = new Size(364, 27);
            btnTrocarSenha.TabIndex = 6;
            btnTrocarSenha.Text = "Trocar Senha";
            btnTrocarSenha.Click += btnTrocarSenha_Click;
            // 
            // PageHeader
            // 
            PageHeader.BackColor = Color.FromArgb(18, 18, 18);
            PageHeader.ColorScheme = AntdUI.TAMode.Dark;
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(0, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(800, 35);
            PageHeader.TabIndex = 6;
            PageHeader.Text = "Configurações";
            // 
            // PaginaConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(800, 600);
            Controls.Add(PageHeader);
            Controls.Add(panelCentral);
            Margin = new Padding(2);
            MinimumSize = new Size(800, 600);
            Name = "PaginaConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Conta";
            Resize += PaginaConfig_Resize;
            panelCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panelCentral;
        private AntdUI.Label lblTituloMain;
        private AntdUI.Label lblSecaoDados;
        private AntdUI.Label lblNickname;
        private AntdUI.Input txtNickname;
        private AntdUI.Button btnMudarNickname;
        private AntdUI.Label lblSenhaAtual;
        private AntdUI.Input txtSenhaAtual;
        private AntdUI.Label lblNovSenha;
        private AntdUI.Input txtNovSenha;
        private AntdUI.Label lblConfirmarSenha;
        private AntdUI.Input txtConfirmarSenha;
        private AntdUI.Button btnTrocarSenha;
        private AntdUI.PageHeader PageHeader;
    }
}