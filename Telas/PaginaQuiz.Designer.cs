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
            PanelQuizCentral = new TableLayoutPanel();
            InputPergunta = new AntdUI.Input();
            PanelRespostas = new TableLayoutPanel();
            PanelQuiz.SuspendLayout();
            PanelQuizCentral.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuiz
            // 
            PanelQuiz.BackColor = Color.Transparent;
            PanelQuiz.ColumnCount = 3;
            PanelQuiz.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelQuiz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelQuiz.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelQuiz.Controls.Add(PanelQuizCentral, 1, 2);
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
            // PanelQuizCentral
            // 
            PanelQuizCentral.ColumnCount = 3;
            PanelQuizCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelQuizCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            PanelQuizCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelQuizCentral.Controls.Add(InputPergunta, 1, 0);
            PanelQuizCentral.Controls.Add(PanelRespostas, 1, 1);
            PanelQuizCentral.Dock = DockStyle.Fill;
            PanelQuizCentral.Location = new Point(23, 123);
            PanelQuizCentral.Name = "PanelQuizCentral";
            PanelQuizCentral.RowCount = 2;
            PanelQuizCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelQuizCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            PanelQuizCentral.Size = new Size(978, 524);
            PanelQuizCentral.TabIndex = 0;
            // 
            // InputPergunta
            // 
            InputPergunta.Anchor = AnchorStyles.None;
            InputPergunta.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputPergunta.Location = new Point(88, 15);
            InputPergunta.Multiline = true;
            InputPergunta.Name = "InputPergunta";
            InputPergunta.PrefixText = "Pergunta: ";
            InputPergunta.Size = new Size(800, 100);
            InputPergunta.TabIndex = 0;
            // 
            // PanelRespostas
            // 
            PanelRespostas.ColumnCount = 2;
            PanelRespostas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelRespostas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelRespostas.Dock = DockStyle.Fill;
            PanelRespostas.Location = new Point(51, 134);
            PanelRespostas.Name = "PanelRespostas";
            PanelRespostas.RowCount = 2;
            PanelRespostas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelRespostas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelRespostas.Size = new Size(874, 387);
            PanelRespostas.TabIndex = 1;
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
            PanelQuizCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel PanelQuiz;
        private TableLayoutPanel PanelQuizCentral;
        private AntdUI.Input InputPergunta;
        private TableLayoutPanel PanelRespostas;
    }
}
