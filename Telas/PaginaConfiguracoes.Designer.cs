namespace SenacQuizApp.Telas
{
    partial class PaginaConfiguracoes
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

        private void InitializeComponent()
        {
            MenuOpcoes = new AntdUI.Menu();
            PanelConfiguracoes = new AntdUI.Panel();
            LabelConfiguracoes = new AntdUI.Label();
            PanelTelas = new AntdUI.Panel();
            PageHeader = new AntdUI.PageHeader();
            PanelConfiguracoes.SuspendLayout();
            SuspendLayout();
            // 
            // MenuOpcoes
            // 
            MenuOpcoes.BackActive = Color.FromArgb(65, 65, 65);
            MenuOpcoes.BackColor = Color.Transparent;
            MenuOpcoes.BackHover = Color.FromArgb(85, 85, 85);
            MenuOpcoes.ColorScheme = AntdUI.TAMode.Dark;
            MenuOpcoes.Dock = DockStyle.Fill;
            MenuOpcoes.FocusModeColor = SystemColors.ActiveBorder;
            MenuOpcoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuOpcoes.IconRatio = 1F;
            MenuOpcoes.Location = new Point(0, 45);
            MenuOpcoes.Name = "MenuOpcoes";
            MenuOpcoes.Radius = 0;
            MenuOpcoes.Size = new Size(177, 595);
            MenuOpcoes.TabIndex = 7;
            // 
            // PanelConfiguracoes
            // 
            PanelConfiguracoes.Back = Color.FromArgb(33, 33, 33);
            PanelConfiguracoes.Controls.Add(MenuOpcoes);
            PanelConfiguracoes.Controls.Add(LabelConfiguracoes);
            PanelConfiguracoes.Dock = DockStyle.Left;
            PanelConfiguracoes.Location = new Point(0, 0);
            PanelConfiguracoes.Name = "PanelConfiguracoes";
            PanelConfiguracoes.Radius = 0;
            PanelConfiguracoes.Size = new Size(177, 640);
            PanelConfiguracoes.TabIndex = 8;
            PanelConfiguracoes.Text = "panel1";
            // 
            // LabelConfiguracoes
            // 
            LabelConfiguracoes.BackColor = Color.Transparent;
            LabelConfiguracoes.Dock = DockStyle.Top;
            LabelConfiguracoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelConfiguracoes.ForeColor = Color.White;
            LabelConfiguracoes.Location = new Point(0, 0);
            LabelConfiguracoes.Margin = new Padding(2);
            LabelConfiguracoes.Name = "LabelConfiguracoes";
            LabelConfiguracoes.Size = new Size(177, 45);
            LabelConfiguracoes.TabIndex = 8;
            LabelConfiguracoes.Text = "Configurações";
            LabelConfiguracoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelTelas
            // 
            PanelTelas.Back = Color.FromArgb(45, 45, 45);
            PanelTelas.Dock = DockStyle.Fill;
            PanelTelas.Location = new Point(177, 35);
            PanelTelas.Name = "PanelTelas";
            PanelTelas.Size = new Size(683, 605);
            PanelTelas.TabIndex = 9;
            // 
            // PageHeader
            // 
            PageHeader.ColorScheme = AntdUI.TAMode.Dark;
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(177, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(683, 35);
            PageHeader.TabIndex = 6;
            PageHeader.Text = " ";
            // 
            // PaginaConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(860, 640);
            Controls.Add(PanelTelas);
            Controls.Add(PageHeader);
            Controls.Add(PanelConfiguracoes);
            Margin = new Padding(2);
            MinimumSize = new Size(860, 640);
            Name = "PaginaConfiguracoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Conta";
            Load += PaginaConfiguracoes_Load;
            PanelConfiguracoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Menu MenuOpcoes;
        private AntdUI.Panel PanelConfiguracoes;
        private AntdUI.Label LabelConfiguracoes;
        private AntdUI.Panel PanelTelas;
        private AntdUI.PageHeader PageHeader;
    }
}