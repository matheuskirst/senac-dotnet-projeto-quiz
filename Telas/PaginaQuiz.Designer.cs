namespace SenacQuizApp.Telas
{
    partial class PaginaQuiz
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
            PanelQuiz = new TableLayoutPanel();
            panelPergunta = new Panel();
            PanelQuiz.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuiz
            // 
            PanelQuiz.BackColor = Color.Transparent;
            PanelQuiz.ColumnCount = 3;
            PanelQuiz.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelQuiz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelQuiz.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelQuiz.Controls.Add(panelPergunta, 1, 2);
            PanelQuiz.Dock = DockStyle.Fill;
            PanelQuiz.Location = new Point(0, 0);
            PanelQuiz.Name = "PanelQuiz";
            PanelQuiz.RowCount = 5;
            PanelQuiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PanelQuiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            PanelQuiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelQuiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            PanelQuiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PanelQuiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PanelQuiz.Size = new Size(1024, 720);
            PanelQuiz.TabIndex = 7;
            // 
            // panelPergunta
            // 
            panelPergunta.Dock = DockStyle.Fill;
            panelPergunta.Location = new Point(23, 123);
            panelPergunta.Name = "panelPergunta";
            panelPergunta.Size = new Size(978, 524);
            panelPergunta.TabIndex = 0;
            // 
            // PaginaQuiz
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(PanelQuiz);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaginaQuiz";
            Size = new Size(1024, 720);
            Load += PaginaQuiz_Load;
            PanelQuiz.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel PanelQuiz;
        private Panel panelPergunta;
    }
}
