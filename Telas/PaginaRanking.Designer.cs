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
            PanelRanking = new AntdUI.Panel();
            TableUsuariosRank = new AntdUI.Table();
            LabelTitulo = new AntdUI.Label();
            PanelRanking.SuspendLayout();
            SuspendLayout();
            // 
            // PanelRanking
            // 
            PanelRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelRanking.BorderColor = Color.Black;
            PanelRanking.BorderWidth = 1F;
            PanelRanking.Controls.Add(TableUsuariosRank);
            PanelRanking.Location = new Point(240, 91);
            PanelRanking.Name = "PanelRanking";
            PanelRanking.Size = new Size(800, 620);
            PanelRanking.TabIndex = 0;
            // 
            // TableUsuariosRank
            // 
            TableUsuariosRank.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableUsuariosRank.BackColor = Color.Transparent;
            TableUsuariosRank.Bordered = true;
            TableUsuariosRank.Dock = DockStyle.Fill;
            TableUsuariosRank.EnableHeaderResizing = true;
            TableUsuariosRank.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableUsuariosRank.Gap = 12;
            TableUsuariosRank.Location = new Point(1, 1);
            TableUsuariosRank.LostFocusClearSelection = true;
            TableUsuariosRank.Name = "TableUsuariosRank";
            TableUsuariosRank.Size = new Size(798, 618);
            TableUsuariosRank.TabIndex = 3;
            TableUsuariosRank.CellClick += TableUsuariosRank_CellClick;
            TableUsuariosRank.CellDoubleClick += TableUsuariosRank_CellDoubleClick;
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = Color.Transparent;
            LabelTitulo.Dock = DockStyle.Top;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(0, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(1280, 85);
            LabelTitulo.TabIndex = 1;
            LabelTitulo.Text = "Ranking";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaRanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelTitulo);
            Controls.Add(PanelRanking);
            Name = "PaginaRanking";
            Size = new Size(1280, 720);
            Load += PaginaRanking_Load;
            PanelRanking.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelRanking;
        private AntdUI.Table TableUsuariosRank;
        private AntdUI.Label LabelTitulo;
    }
}
