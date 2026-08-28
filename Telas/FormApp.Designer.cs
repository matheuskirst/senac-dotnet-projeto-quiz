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
            PanelAppBody = new Panel();
            ButtonHeaderMenu = new AntdUI.Button();
            ButtonHeaderRanking = new AntdUI.Button();
            PanelAppHeader = new AntdUI.Panel();
            ButtonHeaderPerfil = new AntdUI.Button();
            PanelAppFooter = new AntdUI.Panel();
            PanelHeaderDivider = new AntdUI.Panel();
            PanelFooterDivider = new AntdUI.Panel();
            PanelAppHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PageHeader
            // 
            PageHeader.BackColor = Color.FromArgb(30, 41, 50);
            PageHeader.ColorScheme = AntdUI.TAMode.Dark;
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(0, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(1024, 35);
            PageHeader.TabIndex = 5;
            PageHeader.Text = "Quiz TI";
            // 
            // PanelAppBody
            // 
            PanelAppBody.AutoScroll = true;
            PanelAppBody.BackColor = Color.FromArgb(58, 64, 70);
            PanelAppBody.Dock = DockStyle.Fill;
            PanelAppBody.Location = new Point(0, 116);
            PanelAppBody.Margin = new Padding(0);
            PanelAppBody.Name = "PanelAppBody";
            PanelAppBody.Size = new Size(1024, 563);
            PanelAppBody.TabIndex = 4;
            // 
            // ButtonHeaderMenu
            // 
            ButtonHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderMenu.BorderWidth = 1F;
            ButtonHeaderMenu.DefaultBack = Color.White;
            ButtonHeaderMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonHeaderMenu.Location = new Point(12, 34);
            ButtonHeaderMenu.Name = "ButtonHeaderMenu";
            ButtonHeaderMenu.Size = new Size(120, 43);
            ButtonHeaderMenu.TabIndex = 1;
            ButtonHeaderMenu.Text = "Menu";
            ButtonHeaderMenu.Click += ButtonHeaderMenu_Click;
            // 
            // ButtonHeaderRanking
            // 
            ButtonHeaderRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderRanking.BorderWidth = 1F;
            ButtonHeaderRanking.DefaultBack = Color.White;
            ButtonHeaderRanking.Font = new Font("Segoe UI", 14.25F);
            ButtonHeaderRanking.Location = new Point(138, 34);
            ButtonHeaderRanking.Name = "ButtonHeaderRanking";
            ButtonHeaderRanking.Size = new Size(120, 43);
            ButtonHeaderRanking.TabIndex = 7;
            ButtonHeaderRanking.Text = "Ranking";
            ButtonHeaderRanking.Click += ButtonHeaderRanking_Click;
            // 
            // PanelAppHeader
            // 
            PanelAppHeader.Back = Color.FromArgb(30, 41, 50);
            PanelAppHeader.Controls.Add(ButtonHeaderMenu);
            PanelAppHeader.Controls.Add(ButtonHeaderRanking);
            PanelAppHeader.Controls.Add(ButtonHeaderPerfil);
            PanelAppHeader.Dock = DockStyle.Top;
            PanelAppHeader.Location = new Point(0, 35);
            PanelAppHeader.Name = "PanelAppHeader";
            PanelAppHeader.Radius = 0;
            PanelAppHeader.Size = new Size(1024, 80);
            PanelAppHeader.TabIndex = 9;
            PanelAppHeader.Text = "panel1";
            // 
            // ButtonHeaderPerfil
            // 
            ButtonHeaderPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderPerfil.BorderWidth = 1F;
            ButtonHeaderPerfil.DefaultBack = Color.White;
            ButtonHeaderPerfil.Font = new Font("Segoe UI", 14.25F);
            ButtonHeaderPerfil.Location = new Point(264, 34);
            ButtonHeaderPerfil.Name = "ButtonHeaderPerfil";
            ButtonHeaderPerfil.Size = new Size(120, 43);
            ButtonHeaderPerfil.TabIndex = 9;
            ButtonHeaderPerfil.Text = "Perfil";
            ButtonHeaderPerfil.Click += ButtonHeaderPerfil_Click;
            // 
            // PanelAppFooter
            // 
            PanelAppFooter.Back = Color.FromArgb(30, 41, 50);
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
            PanelHeaderDivider.Back = SystemColors.ControlDarkDark;
            PanelHeaderDivider.BackColor = SystemColors.ControlDarkDark;
            PanelHeaderDivider.Dock = DockStyle.Top;
            PanelHeaderDivider.Location = new Point(0, 115);
            PanelHeaderDivider.Name = "PanelHeaderDivider";
            PanelHeaderDivider.Size = new Size(1024, 1);
            PanelHeaderDivider.TabIndex = 0;
            PanelHeaderDivider.Text = "panel1";
            // 
            // PanelFooterDivider
            // 
            PanelFooterDivider.Back = SystemColors.ControlDarkDark;
            PanelFooterDivider.BackColor = SystemColors.ControlDarkDark;
            PanelFooterDivider.Dock = DockStyle.Bottom;
            PanelFooterDivider.Location = new Point(0, 679);
            PanelFooterDivider.Name = "PanelFooterDivider";
            PanelFooterDivider.Size = new Size(1024, 1);
            PanelFooterDivider.TabIndex = 1;
            PanelFooterDivider.Text = "panel1";
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
            PanelAppHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.PageHeader PageHeader;
        private Panel PanelAppBody;
        private AntdUI.Button ButtonHeaderMenu;
        private AntdUI.Button ButtonHeaderRanking;
        private AntdUI.Panel PanelAppHeader;
        private AntdUI.Panel PanelAppFooter;
        private AntdUI.Panel PanelHeaderDivider;
        private AntdUI.Panel PanelFooterDivider;
        private AntdUI.Button ButtonHeaderPerfil;
    }
}