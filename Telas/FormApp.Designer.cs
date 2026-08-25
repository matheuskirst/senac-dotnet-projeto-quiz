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
            PanelAppHeader = new AntdUI.StackPanel();
            PanelAppHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PageHeader
            // 
            PageHeader.BackColor = SystemColors.ControlLight;
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(0, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(1024, 40);
            PageHeader.TabIndex = 5;
            PageHeader.Text = "Quiz TI";
            // 
            // PanelAppBody
            // 
            PanelAppBody.Dock = DockStyle.Fill;
            PanelAppBody.Location = new Point(0, 90);
            PanelAppBody.Margin = new Padding(0);
            PanelAppBody.Name = "PanelAppBody";
            PanelAppBody.Size = new Size(1024, 630);
            PanelAppBody.TabIndex = 4;
            // 
            // ButtonHeaderMenu
            // 
            ButtonHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderMenu.Font = new Font("Segoe UI", 12F);
            ButtonHeaderMenu.Location = new Point(3, 3);
            ButtonHeaderMenu.Name = "ButtonHeaderMenu";
            ButtonHeaderMenu.Size = new Size(120, 44);
            ButtonHeaderMenu.TabIndex = 1;
            ButtonHeaderMenu.Text = "Menu";
            ButtonHeaderMenu.Click += ButtonHeaderMenu_Click;
            // 
            // ButtonHeaderRanking
            // 
            ButtonHeaderRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderRanking.Font = new Font("Segoe UI", 12F);
            ButtonHeaderRanking.Location = new Point(134, 3);
            ButtonHeaderRanking.Name = "ButtonHeaderRanking";
            ButtonHeaderRanking.Size = new Size(120, 44);
            ButtonHeaderRanking.TabIndex = 2;
            ButtonHeaderRanking.Text = "Ranking";
            // 
            // ButtonHeaderPerfil
            // 
            ButtonHeaderPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderPerfil.Font = new Font("Segoe UI", 12F);
            ButtonHeaderPerfil.Location = new Point(265, 3);
            ButtonHeaderPerfil.Name = "ButtonHeaderPerfil";
            ButtonHeaderPerfil.Size = new Size(120, 44);
            ButtonHeaderPerfil.TabIndex = 6;
            ButtonHeaderPerfil.Text = "Perfil";
            // 
            // PanelAppHeader
            // 
            PanelAppHeader.BackColor = SystemColors.ControlLight;
            PanelAppHeader.Controls.Add(ButtonHeaderPerfil);
            PanelAppHeader.Controls.Add(ButtonHeaderRanking);
            PanelAppHeader.Controls.Add(ButtonHeaderMenu);
            PanelAppHeader.Dock = DockStyle.Top;
            PanelAppHeader.Gap = 5;
            PanelAppHeader.Location = new Point(0, 40);
            PanelAppHeader.MaximumSize = new Size(0, 50);
            PanelAppHeader.MinimumSize = new Size(0, 50);
            PanelAppHeader.Name = "PanelAppHeader";
            PanelAppHeader.Size = new Size(1024, 50);
            PanelAppHeader.TabIndex = 5;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 720);
            Controls.Add(PanelAppBody);
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
        private AntdUI.Button ButtonHeaderRanking;
        private AntdUI.Button ButtonHeaderPerfil;
        private AntdUI.StackPanel PanelAppHeader;
    }
}