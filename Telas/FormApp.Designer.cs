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
            ButtonHeaderPerfil = new AntdUI.Button();
            PanelAppHeader = new AntdUI.Panel();
            PanelAppFooter = new AntdUI.Panel();
            PanelHeaderDivider = new AntdUI.Panel();
            PanelAppHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PageHeader
            // 
            PageHeader.BackColor = SystemColors.ControlDark;
            PageHeader.ColorScheme = AntdUI.TAMode.Light;
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
            PanelAppBody.Dock = DockStyle.Fill;
            PanelAppBody.Location = new Point(0, 116);
            PanelAppBody.Margin = new Padding(0);
            PanelAppBody.Name = "PanelAppBody";
            PanelAppBody.Size = new Size(1024, 564);
            PanelAppBody.TabIndex = 4;
            // 
            // ButtonHeaderMenu
            // 
            ButtonHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderMenu.BorderWidth = 1F;
            ButtonHeaderMenu.DefaultBack = Color.White;
            ButtonHeaderMenu.Font = new Font("Segoe UI", 12F);
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
            ButtonHeaderRanking.Font = new Font("Segoe UI", 12F);
            ButtonHeaderRanking.Location = new Point(138, 34);
            ButtonHeaderRanking.Name = "ButtonHeaderRanking";
            ButtonHeaderRanking.Size = new Size(120, 43);
            ButtonHeaderRanking.TabIndex = 7;
            ButtonHeaderRanking.Text = "Ranking";
            ButtonHeaderRanking.Click += ButtonHeaderRanking_Click;
            // 
            // ButtonHeaderPerfil
            // 
            ButtonHeaderPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderPerfil.BorderWidth = 1F;
            ButtonHeaderPerfil.DefaultBack = Color.White;
            ButtonHeaderPerfil.Font = new Font("Segoe UI", 12F);
            ButtonHeaderPerfil.Location = new Point(264, 34);
            ButtonHeaderPerfil.Name = "ButtonHeaderPerfil";
            ButtonHeaderPerfil.Size = new Size(120, 43);
            ButtonHeaderPerfil.TabIndex = 8;
            ButtonHeaderPerfil.Text = "Perfil";
            ButtonHeaderPerfil.Click += ButtonHeaderPerfil_Click;
            // 
            // PanelAppHeader
            // 
            PanelAppHeader.Back = Color.Transparent;
            PanelAppHeader.BackColor = SystemColors.ControlDark;
            PanelAppHeader.Controls.Add(ButtonHeaderMenu);
            PanelAppHeader.Controls.Add(ButtonHeaderPerfil);
            PanelAppHeader.Controls.Add(ButtonHeaderRanking);
            PanelAppHeader.Dock = DockStyle.Top;
            PanelAppHeader.Location = new Point(0, 35);
            PanelAppHeader.Name = "PanelAppHeader";
            PanelAppHeader.Size = new Size(1024, 80);
            PanelAppHeader.TabIndex = 9;
            PanelAppHeader.Text = "panel1";
            // 
            // PanelAppFooter
            // 
            PanelAppFooter.Back = Color.Transparent;
            PanelAppFooter.BackColor = SystemColors.ControlLight;
            PanelAppFooter.Dock = DockStyle.Bottom;
            PanelAppFooter.Location = new Point(0, 680);
            PanelAppFooter.Name = "PanelAppFooter";
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
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 720);
            Controls.Add(PanelAppBody);
            Controls.Add(PanelAppFooter);
            Controls.Add(PanelHeaderDivider);
            Controls.Add(PanelAppHeader);
            Controls.Add(PageHeader);
            MinimumSize = new Size(854, 480);
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
        private AntdUI.Button ButtonHeaderPerfil;
        private AntdUI.Button ButtonHeaderRanking;
        private AntdUI.Panel PanelAppHeader;
        private AntdUI.Panel PanelAppFooter;
        private AntdUI.Panel PanelHeaderDivider;
    }
}