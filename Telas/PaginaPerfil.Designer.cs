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
            TableLayoutPanelPerfil = new TableLayoutPanel();
            SuspendLayout();
            // 
            // TableLayoutPanelPerfil
            // 
            TableLayoutPanelPerfil.BackColor = Color.Transparent;
            TableLayoutPanelPerfil.ColumnCount = 3;
            TableLayoutPanelPerfil.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPerfil.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelPerfil.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPerfil.Dock = DockStyle.Fill;
            TableLayoutPanelPerfil.Location = new Point(0, 0);
            TableLayoutPanelPerfil.Name = "TableLayoutPanelPerfil";
            TableLayoutPanelPerfil.RowCount = 5;
            TableLayoutPanelPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TableLayoutPanelPerfil.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TableLayoutPanelPerfil.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPerfil.Size = new Size(1024, 720);
            TableLayoutPanelPerfil.TabIndex = 7;
            // 
            // PaginaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanelPerfil);
            Name = "PaginaPerfil";
            Size = new Size(1024, 720);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelPerfil;
    }
}
