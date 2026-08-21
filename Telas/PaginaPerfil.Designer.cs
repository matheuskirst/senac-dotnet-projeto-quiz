namespace SenacQuizApp.Telas
{
    partial class PaginaPerfil
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PanelPerfilCentro = new TableLayoutPanel();
            PanelPerfilFooter = new TableLayoutPanel();
            PanelPerfilFooterEsquerda = new AntdUI.StackPanel();
            PanelPerfilFooterDireita = new AntdUI.StackPanel();
            PanelPerfilHeader = new TableLayoutPanel();
            PanelPerfilHeaderEsquerda = new AntdUI.StackPanel();
            PanelPerfilHeaderDireita = new AntdUI.StackPanel();
            PanelPerfilCentro.SuspendLayout();
            PanelPerfilFooter.SuspendLayout();
            PanelPerfilHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPerfilCentro
            // 
            PanelPerfilCentro.ColumnCount = 1;
            PanelPerfilCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelPerfilCentro.Controls.Add(PanelPerfilFooter, 0, 2);
            PanelPerfilCentro.Controls.Add(PanelPerfilHeader, 0, 0);
            PanelPerfilCentro.Dock = DockStyle.Fill;
            PanelPerfilCentro.Location = new Point(0, 0);
            PanelPerfilCentro.Name = "PanelPerfilCentro";
            PanelPerfilCentro.RowCount = 3;
            PanelPerfilCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PanelPerfilCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelPerfilCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PanelPerfilCentro.Size = new Size(1024, 720);
            PanelPerfilCentro.TabIndex = 1;
            // 
            // PanelPerfilFooter
            // 
            PanelPerfilFooter.ColumnCount = 2;
            PanelPerfilFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPerfilFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPerfilFooter.Controls.Add(PanelPerfilFooterEsquerda, 0, 0);
            PanelPerfilFooter.Controls.Add(PanelPerfilFooterDireita, 1, 0);
            PanelPerfilFooter.Dock = DockStyle.Fill;
            PanelPerfilFooter.Location = new Point(3, 663);
            PanelPerfilFooter.Name = "PanelPerfilFooter";
            PanelPerfilFooter.RowCount = 1;
            PanelPerfilFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelPerfilFooter.Size = new Size(1018, 54);
            PanelPerfilFooter.TabIndex = 2;
            // 
            // PanelPerfilFooterEsquerda
            // 
            PanelPerfilFooterEsquerda.Dock = DockStyle.Fill;
            PanelPerfilFooterEsquerda.Location = new Point(0, 0);
            PanelPerfilFooterEsquerda.Margin = new Padding(0);
            PanelPerfilFooterEsquerda.Name = "PanelPerfilFooterEsquerda";
            PanelPerfilFooterEsquerda.Size = new Size(509, 54);
            PanelPerfilFooterEsquerda.TabIndex = 2;
            PanelPerfilFooterEsquerda.Text = "stackPanel1";
            // 
            // PanelPerfilFooterDireita
            // 
            PanelPerfilFooterDireita.Dock = DockStyle.Fill;
            PanelPerfilFooterDireita.Location = new Point(509, 0);
            PanelPerfilFooterDireita.Margin = new Padding(0);
            PanelPerfilFooterDireita.Name = "PanelPerfilFooterDireita";
            PanelPerfilFooterDireita.RightToLeft = RightToLeft.Yes;
            PanelPerfilFooterDireita.Size = new Size(509, 54);
            PanelPerfilFooterDireita.TabIndex = 3;
            PanelPerfilFooterDireita.Text = "stackPanel1";
            // 
            // PanelPerfilHeader
            // 
            PanelPerfilHeader.ColumnCount = 2;
            PanelPerfilHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPerfilHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPerfilHeader.Controls.Add(PanelPerfilHeaderEsquerda, 0, 0);
            PanelPerfilHeader.Controls.Add(PanelPerfilHeaderDireita, 1, 0);
            PanelPerfilHeader.Dock = DockStyle.Fill;
            PanelPerfilHeader.Location = new Point(3, 3);
            PanelPerfilHeader.Name = "PanelPerfilHeader";
            PanelPerfilHeader.RowCount = 1;
            PanelPerfilHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelPerfilHeader.Size = new Size(1018, 54);
            PanelPerfilHeader.TabIndex = 1;
            // 
            // PanelPerfilHeaderEsquerda
            // 
            PanelPerfilHeaderEsquerda.Dock = DockStyle.Fill;
            PanelPerfilHeaderEsquerda.Location = new Point(0, 0);
            PanelPerfilHeaderEsquerda.Margin = new Padding(0);
            PanelPerfilHeaderEsquerda.Name = "PanelPerfilHeaderEsquerda";
            PanelPerfilHeaderEsquerda.Size = new Size(509, 54);
            PanelPerfilHeaderEsquerda.TabIndex = 2;
            PanelPerfilHeaderEsquerda.Text = "stackPanel1";
            // 
            // PanelPerfilHeaderDireita
            // 
            PanelPerfilHeaderDireita.Dock = DockStyle.Fill;
            PanelPerfilHeaderDireita.Location = new Point(509, 0);
            PanelPerfilHeaderDireita.Margin = new Padding(0);
            PanelPerfilHeaderDireita.Name = "PanelPerfilHeaderDireita";
            PanelPerfilHeaderDireita.RightToLeft = RightToLeft.Yes;
            PanelPerfilHeaderDireita.Size = new Size(509, 54);
            PanelPerfilHeaderDireita.TabIndex = 3;
            PanelPerfilHeaderDireita.Text = "stackPanel1";
            // 
            // PaginaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPerfilCentro);
            Name = "PaginaPerfil";
            Size = new Size(1024, 720);
            Load += PaginaPerfil_Load;
            PanelPerfilCentro.ResumeLayout(false);
            PanelPerfilFooter.ResumeLayout(false);
            PanelPerfilHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelPerfilCentro;
        private TableLayoutPanel PanelPerfilFooter;
        private AntdUI.StackPanel PanelPerfilFooterEsquerda;
        private AntdUI.StackPanel PanelPerfilFooterDireita;
        private TableLayoutPanel PanelPerfilHeader;
        private AntdUI.StackPanel PanelPerfilHeaderEsquerda;
        private AntdUI.StackPanel PanelPerfilHeaderDireita;
    }
}
