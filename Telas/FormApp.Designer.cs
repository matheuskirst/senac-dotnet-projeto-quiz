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
            PanelAppCentral = new TableLayoutPanel();
            PanelAppHeader = new TableLayoutPanel();
            PanelHeaderEsquerda = new AntdUI.StackPanel();
            ButtonHeaderRanking = new AntdUI.Button();
            ButtonHeaderMenu = new AntdUI.Button();
            PanelHeaderDireita = new AntdUI.StackPanel();
            ButtonHeaderPerfil = new AntdUI.Button();
            PanelAppBody = new Panel();
            PanelAppCentral.SuspendLayout();
            PanelAppHeader.SuspendLayout();
            PanelHeaderEsquerda.SuspendLayout();
            PanelHeaderDireita.SuspendLayout();
            SuspendLayout();
            // 
            // PageHeader
            // 
            PageHeader.BackColor = SystemColors.ControlLight;
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(0, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(854, 30);
            PageHeader.TabIndex = 5;
            PageHeader.Text = "Quiz";
            // 
            // PanelAppCentral
            // 
            PanelAppCentral.ColumnCount = 1;
            PanelAppCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelAppCentral.Controls.Add(PanelAppHeader, 0, 0);
            PanelAppCentral.Controls.Add(PanelAppBody, 0, 1);
            PanelAppCentral.Dock = DockStyle.Fill;
            PanelAppCentral.Location = new Point(0, 30);
            PanelAppCentral.Name = "PanelAppCentral";
            PanelAppCentral.RowCount = 2;
            PanelAppCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            PanelAppCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelAppCentral.Size = new Size(854, 450);
            PanelAppCentral.TabIndex = 6;
            // 
            // PanelAppHeader
            // 
            PanelAppHeader.ColumnCount = 4;
            PanelAppHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelAppHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelAppHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelAppHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelAppHeader.Controls.Add(PanelHeaderEsquerda, 1, 0);
            PanelAppHeader.Controls.Add(PanelHeaderDireita, 2, 0);
            PanelAppHeader.Dock = DockStyle.Fill;
            PanelAppHeader.Location = new Point(0, 0);
            PanelAppHeader.Margin = new Padding(0);
            PanelAppHeader.Name = "PanelAppHeader";
            PanelAppHeader.RightToLeft = RightToLeft.No;
            PanelAppHeader.RowCount = 1;
            PanelAppHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelAppHeader.Size = new Size(854, 50);
            PanelAppHeader.TabIndex = 5;
            // 
            // PanelHeaderEsquerda
            // 
            PanelHeaderEsquerda.Controls.Add(ButtonHeaderRanking);
            PanelHeaderEsquerda.Controls.Add(ButtonHeaderMenu);
            PanelHeaderEsquerda.Dock = DockStyle.Fill;
            PanelHeaderEsquerda.Gap = 5;
            PanelHeaderEsquerda.Location = new Point(23, 3);
            PanelHeaderEsquerda.Name = "PanelHeaderEsquerda";
            PanelHeaderEsquerda.Size = new Size(401, 44);
            PanelHeaderEsquerda.TabIndex = 0;
            // 
            // ButtonHeaderRanking
            // 
            ButtonHeaderRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderRanking.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonHeaderRanking.Location = new Point(114, 3);
            ButtonHeaderRanking.Name = "ButtonHeaderRanking";
            ButtonHeaderRanking.Size = new Size(100, 38);
            ButtonHeaderRanking.TabIndex = 2;
            ButtonHeaderRanking.Text = "Ranking";
            // 
            // ButtonHeaderMenu
            // 
            ButtonHeaderMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderMenu.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonHeaderMenu.Location = new Point(3, 3);
            ButtonHeaderMenu.Name = "ButtonHeaderMenu";
            ButtonHeaderMenu.Size = new Size(100, 38);
            ButtonHeaderMenu.TabIndex = 1;
            ButtonHeaderMenu.Text = "Menu";
            // 
            // PanelHeaderDireita
            // 
            PanelHeaderDireita.Controls.Add(ButtonHeaderPerfil);
            PanelHeaderDireita.Dock = DockStyle.Fill;
            PanelHeaderDireita.Gap = 5;
            PanelHeaderDireita.Location = new Point(430, 3);
            PanelHeaderDireita.Name = "PanelHeaderDireita";
            PanelHeaderDireita.RightToLeft = RightToLeft.Yes;
            PanelHeaderDireita.Size = new Size(401, 44);
            PanelHeaderDireita.TabIndex = 1;
            // 
            // ButtonHeaderPerfil
            // 
            ButtonHeaderPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonHeaderPerfil.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonHeaderPerfil.Location = new Point(298, 3);
            ButtonHeaderPerfil.Name = "ButtonHeaderPerfil";
            ButtonHeaderPerfil.Size = new Size(100, 38);
            ButtonHeaderPerfil.TabIndex = 3;
            ButtonHeaderPerfil.Text = "Perfil";
            // 
            // PanelAppBody
            // 
            PanelAppBody.Dock = DockStyle.Fill;
            PanelAppBody.Location = new Point(0, 50);
            PanelAppBody.Margin = new Padding(0);
            PanelAppBody.Name = "PanelAppBody";
            PanelAppBody.Size = new Size(854, 400);
            PanelAppBody.TabIndex = 4;
            // 
            // FormApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 480);
            Controls.Add(PanelAppCentral);
            Controls.Add(PageHeader);
            MinimumSize = new Size(854, 480);
            Name = "FormApp";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto Quiz";
            WindowState = FormWindowState.Maximized;
            Load += FormJanelaPrincipal_Load;
            PanelAppCentral.ResumeLayout(false);
            PanelAppHeader.ResumeLayout(false);
            PanelHeaderEsquerda.ResumeLayout(false);
            PanelHeaderDireita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.PageHeader PageHeader;
        private TableLayoutPanel PanelAppCentral;
        private Panel PanelAppBody;
        private TableLayoutPanel PanelAppHeader;
        private AntdUI.StackPanel PanelHeaderEsquerda;
        private AntdUI.Button ButtonHeaderRanking;
        private AntdUI.Button ButtonHeaderMenu;
        private AntdUI.StackPanel PanelHeaderDireita;
        private AntdUI.Button ButtonHeaderPerfil;
    }
}