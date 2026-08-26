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
            label1 = new AntdUI.Label();
            PanelRanking.SuspendLayout();
            SuspendLayout();
            // 
            // PanelRanking
            // 
            PanelRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelRanking.BorderColor = Color.Black;
            PanelRanking.BorderWidth = 1F;
            PanelRanking.Controls.Add(TableUsuariosRank);
            PanelRanking.Location = new Point(375, 90);
            PanelRanking.Name = "PanelRanking";
            PanelRanking.Size = new Size(530, 664);
            PanelRanking.TabIndex = 0;
            // 
            // TableUsuariosRank
            // 
            TableUsuariosRank.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableUsuariosRank.BackColor = Color.Transparent;
            TableUsuariosRank.Bordered = true;
            TableUsuariosRank.Dock = DockStyle.Fill;
            TableUsuariosRank.EnableHeaderResizing = true;
            TableUsuariosRank.Gap = 12;
            TableUsuariosRank.Location = new Point(1, 1);
            TableUsuariosRank.LostFocusClearSelection = true;
            TableUsuariosRank.Name = "TableUsuariosRank";
            TableUsuariosRank.Size = new Size(528, 662);
            TableUsuariosRank.TabIndex = 3;
            TableUsuariosRank.CellClick += TableUsuariosRank_CellClick;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1280, 85);
            label1.TabIndex = 1;
            label1.Text = "Ranking";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaRanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
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
        private AntdUI.Label label1;
    }
}
