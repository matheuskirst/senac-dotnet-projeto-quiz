namespace SenacQuizApp.Telas
{
    partial class PaginaHistorico
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelResumoPreview = new AntdUI.Panel();
            TableQuizHistorico = new AntdUI.Table();
            LabelQuizzesPartidas = new AntdUI.Label();
            PanelResumoPreview.SuspendLayout();
            SuspendLayout();
            // 
            // PanelResumoPreview
            // 
            PanelResumoPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelResumoPreview.AutoScroll = true;
            PanelResumoPreview.Controls.Add(TableQuizHistorico);
            PanelResumoPreview.Controls.Add(LabelQuizzesPartidas);
            PanelResumoPreview.Location = new Point(112, 80);
            PanelResumoPreview.Name = "PanelResumoPreview";
            PanelResumoPreview.Size = new Size(800, 560);
            PanelResumoPreview.TabIndex = 2;
            PanelResumoPreview.Text = "panel2";
            // 
            // TableQuizHistorico
            // 
            TableQuizHistorico.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableQuizHistorico.BackColor = Color.White;
            TableQuizHistorico.Dock = DockStyle.Fill;
            TableQuizHistorico.EmptyText = "Nenhum Quiz Encontrado";
            TableQuizHistorico.EnableHeaderResizing = true;
            TableQuizHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableQuizHistorico.Gap = 12;
            TableQuizHistorico.Location = new Point(0, 39);
            TableQuizHistorico.LostFocusClearSelection = true;
            TableQuizHistorico.Name = "TableQuizHistorico";
            TableQuizHistorico.Size = new Size(800, 521);
            TableQuizHistorico.TabIndex = 2;
            // 
            // LabelQuizzesPartidas
            // 
            LabelQuizzesPartidas.BackColor = Color.Transparent;
            LabelQuizzesPartidas.Dock = DockStyle.Top;
            LabelQuizzesPartidas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizzesPartidas.Location = new Point(0, 0);
            LabelQuizzesPartidas.Name = "LabelQuizzesPartidas";
            LabelQuizzesPartidas.Prefix = "Histórico";
            LabelQuizzesPartidas.Size = new Size(800, 39);
            LabelQuizzesPartidas.TabIndex = 0;
            LabelQuizzesPartidas.Text = "";
            LabelQuizzesPartidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelResumoPreview);
            Name = "PaginaHistorico";
            Size = new Size(1024, 720);
            Load += PaginaHistorico_Load;
            PanelResumoPreview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelResumoPreview;
        private AntdUI.Table TableQuizHistorico;
        private AntdUI.Label LabelQuizzesPartidas;
    }
}
