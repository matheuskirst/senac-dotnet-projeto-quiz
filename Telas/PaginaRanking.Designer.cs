namespace SenacQuizApp.Telas
{
    partial class PaginaRanking
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
            TableUsuariosRank = new AntdUI.Table();
            SuspendLayout();
            // 
            // TableUsuariosRank
            // 
            TableUsuariosRank.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableUsuariosRank.Bordered = true;
            TableUsuariosRank.EnableHeaderResizing = true;
            TableUsuariosRank.Gap = 12;
            TableUsuariosRank.Location = new Point(165, 35);
            TableUsuariosRank.LostFocusClearSelection = true;
            TableUsuariosRank.Name = "TableUsuariosRank";
            TableUsuariosRank.Size = new Size(950, 650);
            TableUsuariosRank.TabIndex = 1;
            // 
            // PaginaRanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableUsuariosRank);
            Name = "PaginaRanking";
            Size = new Size(1280, 720);
            Load += PaginaRanking_Load;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table TableUsuariosRank;
    }
}
