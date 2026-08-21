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
            PanelPerguntaCentral = new TableLayoutPanel();
            InputPergunta = new AntdUI.Input();
            PanelAlternativas = new TableLayoutPanel();
            PanelQuiz.SuspendLayout();
            panelPergunta.SuspendLayout();
            PanelPerguntaCentral.SuspendLayout();
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
            panelPergunta.Controls.Add(PanelPerguntaCentral);
            panelPergunta.Dock = DockStyle.Fill;
            panelPergunta.Location = new Point(23, 123);
            panelPergunta.Name = "panelPergunta";
            panelPergunta.Size = new Size(978, 524);
            panelPergunta.TabIndex = 0;
            // 
            // PanelPerguntaCentral
            // 
            PanelPerguntaCentral.ColumnCount = 3;
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelPerguntaCentral.Controls.Add(InputPergunta, 1, 0);
            PanelPerguntaCentral.Controls.Add(PanelAlternativas, 1, 1);
            PanelPerguntaCentral.Dock = DockStyle.Fill;
            PanelPerguntaCentral.Location = new Point(0, 0);
            PanelPerguntaCentral.Margin = new Padding(3, 2, 3, 2);
            PanelPerguntaCentral.Name = "PanelPerguntaCentral";
            PanelPerguntaCentral.RowCount = 2;
            PanelPerguntaCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelPerguntaCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            PanelPerguntaCentral.Size = new Size(978, 524);
            PanelPerguntaCentral.TabIndex = 2;
            // 
            // InputPergunta
            // 
            InputPergunta.AutoScroll = true;
            InputPergunta.Dock = DockStyle.Fill;
            InputPergunta.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputPergunta.Location = new Point(51, 2);
            InputPergunta.Margin = new Padding(3, 2, 3, 2);
            InputPergunta.MinimumSize = new Size(460, 100);
            InputPergunta.Multiline = true;
            InputPergunta.Name = "InputPergunta";
            InputPergunta.PrefixText = "Pergunta: ";
            InputPergunta.ReadOnly = true;
            InputPergunta.Size = new Size(874, 127);
            InputPergunta.TabIndex = 0;
            // 
            // PanelAlternativas
            // 
            PanelAlternativas.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            PanelAlternativas.ColumnCount = 2;
            PanelAlternativas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelAlternativas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelAlternativas.Dock = DockStyle.Fill;
            PanelAlternativas.Location = new Point(51, 133);
            PanelAlternativas.Margin = new Padding(3, 2, 3, 2);
            PanelAlternativas.Name = "PanelAlternativas";
            PanelAlternativas.RowCount = 2;
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelAlternativas.Size = new Size(874, 389);
            PanelAlternativas.TabIndex = 1;
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
            panelPergunta.ResumeLayout(false);
            PanelPerguntaCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel PanelQuiz;
        private Panel panelPergunta;
        private TableLayoutPanel PanelPerguntaCentral;
        private AntdUI.Input InputPergunta;
        private TableLayoutPanel PanelAlternativas;
    }
}
