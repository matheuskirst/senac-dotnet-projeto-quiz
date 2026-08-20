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
            PanelDropdownUsuario = new Panel();
            LabelDropdownUsuario = new AntdUI.Label();
            DropdownUsuario = new AntdUI.Dropdown();
            PanelAppCentral = new TableLayoutPanel();
            PanelAppHeader = new AntdUI.StackPanel();
            ButtonHeaderPerfil = new AntdUI.Button();
            ButtonHeaderRanking = new AntdUI.Button();
            ButtonHeaderMenu = new AntdUI.Button();
            PanelAppBody = new Panel();
            PageHeader.SuspendLayout();
            PanelDropdownUsuario.SuspendLayout();
            PanelAppCentral.SuspendLayout();
            PanelAppHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PageHeader
            // 
            PageHeader.BackColor = SystemColors.ControlLight;
            PageHeader.Controls.Add(PanelDropdownUsuario);
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(0, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(1024, 40);
            PageHeader.TabIndex = 5;
            PageHeader.Text = "Quiz";
            // 
            // PanelDropdownUsuario
            // 
            PanelDropdownUsuario.AutoSize = true;
            PanelDropdownUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelDropdownUsuario.Controls.Add(LabelDropdownUsuario);
            PanelDropdownUsuario.Controls.Add(DropdownUsuario);
            PanelDropdownUsuario.Dock = DockStyle.Right;
            PanelDropdownUsuario.Location = new Point(713, 0);
            PanelDropdownUsuario.Name = "PanelDropdownUsuario";
            PanelDropdownUsuario.Size = new Size(167, 40);
            PanelDropdownUsuario.TabIndex = 2;
            // 
            // LabelDropdownUsuario
            // 
            LabelDropdownUsuario.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDropdownUsuario.Location = new Point(3, 3);
            LabelDropdownUsuario.Name = "LabelDropdownUsuario";
            LabelDropdownUsuario.Size = new Size(62, 34);
            LabelDropdownUsuario.TabIndex = 0;
            LabelDropdownUsuario.Text = "Usuário:";
            // 
            // DropdownUsuario
            // 
            DropdownUsuario.AutoSizeMode = AntdUI.TAutoSize.Width;
            DropdownUsuario.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DropdownUsuario.Items.AddRange(new object[] { "Ver Perfil", "Configurações", "Sair" });
            DropdownUsuario.Location = new Point(64, 6);
            DropdownUsuario.MaximumSize = new Size(0, 30);
            DropdownUsuario.MinimumSize = new Size(100, 0);
            DropdownUsuario.Name = "DropdownUsuario";
            DropdownUsuario.Radius = 2;
            DropdownUsuario.Size = new Size(100, 30);
            DropdownUsuario.TabIndex = 1;
            // 
            // PanelAppCentral
            // 
            PanelAppCentral.ColumnCount = 1;
            PanelAppCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelAppCentral.Controls.Add(PanelAppHeader, 0, 0);
            PanelAppCentral.Controls.Add(PanelAppBody, 0, 1);
            PanelAppCentral.Dock = DockStyle.Fill;
            PanelAppCentral.Location = new Point(0, 40);
            PanelAppCentral.Name = "PanelAppCentral";
            PanelAppCentral.RowCount = 2;
            PanelAppCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PanelAppCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelAppCentral.Size = new Size(1024, 680);
            PanelAppCentral.TabIndex = 6;
            // 
            // PanelAppHeader
            // 
            PanelAppHeader.Controls.Add(ButtonHeaderPerfil);
            PanelAppHeader.Controls.Add(ButtonHeaderRanking);
            PanelAppHeader.Controls.Add(ButtonHeaderMenu);
            PanelAppHeader.Dock = DockStyle.Fill;
            PanelAppHeader.Gap = 5;
            PanelAppHeader.Location = new Point(3, 3);
            PanelAppHeader.Name = "PanelAppHeader";
            PanelAppHeader.Size = new Size(1018, 54);
            PanelAppHeader.TabIndex = 5;
            // 
            // ButtonHeaderPerfil
            // 
            ButtonHeaderPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderPerfil.Font = new Font("Tahoma", 12F);
            ButtonHeaderPerfil.Location = new Point(265, 3);
            ButtonHeaderPerfil.Name = "ButtonHeaderPerfil";
            ButtonHeaderPerfil.Size = new Size(120, 48);
            ButtonHeaderPerfil.TabIndex = 4;
            ButtonHeaderPerfil.Text = "Perfil";
            ButtonHeaderPerfil.Click += ButtonHeaderPerfil_Click;
            // 
            // ButtonHeaderRanking
            // 
            ButtonHeaderRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderRanking.Font = new Font("Tahoma", 12F);
            ButtonHeaderRanking.Location = new Point(134, 3);
            ButtonHeaderRanking.Name = "ButtonHeaderRanking";
            ButtonHeaderRanking.Size = new Size(120, 48);
            ButtonHeaderRanking.TabIndex = 2;
            ButtonHeaderRanking.Text = "Ranking";
            ButtonHeaderRanking.Click += ButtonHeaderRanking_Click;
            // 
            // ButtonHeaderMenu
            // 
            ButtonHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderMenu.Font = new Font("Tahoma", 12F);
            ButtonHeaderMenu.Location = new Point(3, 3);
            ButtonHeaderMenu.Name = "ButtonHeaderMenu";
            ButtonHeaderMenu.Size = new Size(120, 48);
            ButtonHeaderMenu.TabIndex = 1;
            ButtonHeaderMenu.Text = "Menu";
            ButtonHeaderMenu.Click += ButtonHeaderMenu_Click;
            // 
            // PanelAppBody
            // 
            PanelAppBody.Dock = DockStyle.Fill;
            PanelAppBody.Location = new Point(0, 60);
            PanelAppBody.Margin = new Padding(0);
            PanelAppBody.Name = "PanelAppBody";
            PanelAppBody.Size = new Size(1024, 620);
            PanelAppBody.TabIndex = 4;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 720);
            Controls.Add(PanelAppCentral);
            Controls.Add(PageHeader);
            MinimumSize = new Size(854, 480);
            Name = "FormApp";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto Quiz";
            WindowState = FormWindowState.Maximized;
            Load += FormJanelaPrincipal_Load;
            PageHeader.ResumeLayout(false);
            PageHeader.PerformLayout();
            PanelDropdownUsuario.ResumeLayout(false);
            PanelDropdownUsuario.PerformLayout();
            PanelAppCentral.ResumeLayout(false);
            PanelAppHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.PageHeader PageHeader;
        private TableLayoutPanel PanelAppCentral;
        private Panel PanelAppBody;
        private AntdUI.StackPanel PanelAppHeader;
        private AntdUI.Button ButtonHeaderPerfil;
        private AntdUI.Button ButtonHeaderRanking;
        private AntdUI.Button ButtonHeaderMenu;
        private AntdUI.Label LabelDropdownUsuario;
        private AntdUI.Dropdown DropdownUsuario;
        private Panel PanelDropdownUsuario;
    }
}