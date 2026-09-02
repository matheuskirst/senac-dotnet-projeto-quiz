namespace SenacQuizApp.Telas
{
    partial class FormApp
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
            PageHeader = new AntdUI.PageHeader();
            DropdownUsuarioMenu = new AntdUI.Dropdown();
            ButtonHeaderMenu = new AntdUI.Button();
            ButtonHeaderRanking = new AntdUI.Button();
            PanelAppHeader = new AntdUI.Panel();
            ButtonHeaderPerfil = new AntdUI.Button();
            ButtonHeaderConquista = new AntdUI.Button();
            PanelAppFooter = new AntdUI.Panel();
            PanelHeaderDivider = new AntdUI.Panel();
            PanelFooterDivider = new AntdUI.Panel();
            PanelAppBody = new AntdUI.Panel();
            PageHeader.SuspendLayout();
            PanelAppHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PageHeader
            // 
            PageHeader.BackColor = Color.FromArgb(18, 18, 18);
            PageHeader.ColorScheme = AntdUI.TAMode.Dark;
            PageHeader.Controls.Add(DropdownUsuarioMenu);
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(0, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(1024, 35);
            PageHeader.TabIndex = 5;
            PageHeader.Text = "Quiz TI";
            // 
            // DropdownUsuarioMenu
            // 
            DropdownUsuarioMenu.AutoSizeMode = AntdUI.TAutoSize.Width;
            DropdownUsuarioMenu.BorderWidth = 1F;
            DropdownUsuarioMenu.ColorScheme = AntdUI.TAMode.Dark;
            DropdownUsuarioMenu.DefaultBack = Color.FromArgb(66, 66, 66);
            DropdownUsuarioMenu.DefaultBorderColor = Color.FromArgb(20, 20, 20);
            DropdownUsuarioMenu.Dock = DockStyle.Right;
            DropdownUsuarioMenu.IsLink = true;
            DropdownUsuarioMenu.Location = new Point(800, 0);
            DropdownUsuarioMenu.Name = "DropdownUsuarioMenu";
            DropdownUsuarioMenu.Radius = 2;
            DropdownUsuarioMenu.RightToLeft = RightToLeft.Yes;
            DropdownUsuarioMenu.ShowArrow = true;
            DropdownUsuarioMenu.Size = new Size(80, 35);
            DropdownUsuarioMenu.TabIndex = 1;
            DropdownUsuarioMenu.Text = "Usuário";
            DropdownUsuarioMenu.ToggleText = "";
            DropdownUsuarioMenu.ItemClick += DropdownUsuarioMenu_ItemClick;
            // 
            // ButtonHeaderMenu
            // 
            ButtonHeaderMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderMenu.BorderWidth = 1F;
            ButtonHeaderMenu.ColorScheme = AntdUI.TAMode.Dark;
            ButtonHeaderMenu.DefaultBorderColor = Color.FromArgb(40, 40, 40);
            ButtonHeaderMenu.Font = new Font("Microsoft Sans Serif", 12F);
            ButtonHeaderMenu.ForeHover = Color.White;
            ButtonHeaderMenu.Ghost = true;
            ButtonHeaderMenu.Location = new Point(12, 4);
            ButtonHeaderMenu.Name = "ButtonHeaderMenu";
            ButtonHeaderMenu.Size = new Size(120, 45);
            ButtonHeaderMenu.TabIndex = 1;
            ButtonHeaderMenu.Text = "Menu";
            ButtonHeaderMenu.ToggleFore = Color.FromArgb(66, 160, 245);
            ButtonHeaderMenu.Click += ButtonHeaderMenu_Click;
            // 
            // ButtonHeaderRanking
            // 
            ButtonHeaderRanking.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderRanking.BorderWidth = 1F;
            ButtonHeaderRanking.ColorScheme = AntdUI.TAMode.Dark;
            ButtonHeaderRanking.DefaultBorderColor = Color.FromArgb(40, 40, 40);
            ButtonHeaderRanking.Font = new Font("Microsoft Sans Serif", 12F);
            ButtonHeaderRanking.ForeHover = Color.White;
            ButtonHeaderRanking.Ghost = true;
            ButtonHeaderRanking.Location = new Point(138, 4);
            ButtonHeaderRanking.Name = "ButtonHeaderRanking";
            ButtonHeaderRanking.Size = new Size(120, 45);
            ButtonHeaderRanking.TabIndex = 7;
            ButtonHeaderRanking.Text = "Ranking";
            ButtonHeaderRanking.ToggleFore = Color.FromArgb(66, 160, 245);
            ButtonHeaderRanking.Click += ButtonHeaderRanking_Click;
            // 
            // PanelAppHeader
            // 
            PanelAppHeader.Back = Color.FromArgb(18, 18, 18);
            PanelAppHeader.Controls.Add(ButtonHeaderPerfil);
            PanelAppHeader.Controls.Add(ButtonHeaderMenu);
            PanelAppHeader.Controls.Add(ButtonHeaderRanking);
            PanelAppHeader.Controls.Add(ButtonHeaderConquista);
            PanelAppHeader.Dock = DockStyle.Top;
            PanelAppHeader.Location = new Point(0, 35);
            PanelAppHeader.Name = "PanelAppHeader";
            PanelAppHeader.Radius = 0;
            PanelAppHeader.Size = new Size(1024, 50);
            PanelAppHeader.TabIndex = 9;
            PanelAppHeader.Text = "panel1";
            // 
            // ButtonHeaderPerfil
            // 
            ButtonHeaderPerfil.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderPerfil.BorderWidth = 1F;
            ButtonHeaderPerfil.ColorScheme = AntdUI.TAMode.Dark;
            ButtonHeaderPerfil.DefaultBorderColor = Color.FromArgb(40, 40, 40);
            ButtonHeaderPerfil.Font = new Font("Microsoft Sans Serif", 12F);
            ButtonHeaderPerfil.ForeHover = Color.White;
            ButtonHeaderPerfil.Ghost = true;
            ButtonHeaderPerfil.Location = new Point(390, 4);
            ButtonHeaderPerfil.Name = "ButtonHeaderPerfil";
            ButtonHeaderPerfil.Size = new Size(120, 45);
            ButtonHeaderPerfil.TabIndex = 10;
            ButtonHeaderPerfil.Text = "Perfil";
            ButtonHeaderPerfil.ToggleFore = Color.FromArgb(66, 160, 245);
            ButtonHeaderPerfil.Click += ButtonHeaderPerfil_Click;
            // 
            // ButtonHeaderConquista
            // 
            ButtonHeaderConquista.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderConquista.BorderWidth = 1F;
            ButtonHeaderConquista.ColorScheme = AntdUI.TAMode.Dark;
            ButtonHeaderConquista.DefaultBorderColor = Color.FromArgb(40, 40, 40);
            ButtonHeaderConquista.Font = new Font("Microsoft Sans Serif", 12F);
            ButtonHeaderConquista.ForeHover = Color.White;
            ButtonHeaderConquista.Ghost = true;
            ButtonHeaderConquista.Location = new Point(264, 4);
            ButtonHeaderConquista.Name = "ButtonHeaderConquista";
            ButtonHeaderConquista.Size = new Size(120, 45);
            ButtonHeaderConquista.TabIndex = 9;
            ButtonHeaderConquista.Text = "Conquistas";
            ButtonHeaderConquista.ToggleFore = Color.FromArgb(66, 160, 245);
            ButtonHeaderConquista.Click += ButtonHeaderConquista_Click;
            // 
            // PanelAppFooter
            // 
            PanelAppFooter.Back = Color.FromArgb(18, 18, 18);
            PanelAppFooter.Dock = DockStyle.Bottom;
            PanelAppFooter.Location = new Point(0, 680);
            PanelAppFooter.Name = "PanelAppFooter";
            PanelAppFooter.Radius = 0;
            PanelAppFooter.Size = new Size(1024, 40);
            PanelAppFooter.TabIndex = 10;
            PanelAppFooter.Text = "panel1";
            // 
            // PanelHeaderDivider
            // 
            PanelHeaderDivider.Back = Color.Black;
            PanelHeaderDivider.BackColor = SystemColors.ControlDarkDark;
            PanelHeaderDivider.Dock = DockStyle.Top;
            PanelHeaderDivider.Location = new Point(0, 85);
            PanelHeaderDivider.Name = "PanelHeaderDivider";
            PanelHeaderDivider.Size = new Size(1024, 1);
            PanelHeaderDivider.TabIndex = 0;
            PanelHeaderDivider.Text = "panel1";
            // 
            // PanelFooterDivider
            // 
            PanelFooterDivider.Back = Color.Black;
            PanelFooterDivider.BackColor = SystemColors.ControlDarkDark;
            PanelFooterDivider.Dock = DockStyle.Bottom;
            PanelFooterDivider.Location = new Point(0, 679);
            PanelFooterDivider.Name = "PanelFooterDivider";
            PanelFooterDivider.Size = new Size(1024, 1);
            PanelFooterDivider.TabIndex = 1;
            PanelFooterDivider.Text = "panel1";
            // 
            // PanelAppBody
            // 
            PanelAppBody.Back = Color.FromArgb(50, 50, 50);
            PanelAppBody.Dock = DockStyle.Fill;
            PanelAppBody.Location = new Point(0, 86);
            PanelAppBody.Name = "PanelAppBody";
            PanelAppBody.Radius = 0;
            PanelAppBody.Size = new Size(1024, 593);
            PanelAppBody.TabIndex = 11;
            PanelAppBody.Text = " ";
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 720);
            Controls.Add(PanelAppBody);
            Controls.Add(PanelFooterDivider);
            Controls.Add(PanelAppFooter);
            Controls.Add(PanelHeaderDivider);
            Controls.Add(PanelAppHeader);
            Controls.Add(PageHeader);
            MinimumSize = new Size(1024, 720);
            Name = "FormApp";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz TI";
            WindowState = FormWindowState.Maximized;
            Load += FormJanelaPrincipal_Load;
            PageHeader.ResumeLayout(false);
            PageHeader.PerformLayout();
            PanelAppHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.PageHeader PageHeader;
        private AntdUI.Button ButtonHeaderMenu;
        private AntdUI.Button ButtonHeaderRanking;
        private AntdUI.Panel PanelAppHeader;
        private AntdUI.Panel PanelAppFooter;
        private AntdUI.Panel PanelHeaderDivider;
        private AntdUI.Panel PanelFooterDivider;
        private AntdUI.Button ButtonHeaderConquista;
        private AntdUI.Dropdown DropdownUsuarioMenu;
        private AntdUI.Panel PanelAppBody;
        private AntdUI.Button ButtonHeaderPerfil;
    }
}