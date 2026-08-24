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
            PanelQuizBody = new Panel();
            SuspendLayout();
            // 
            // PanelQuizBody
            // 
            PanelQuizBody.Dock = DockStyle.Fill;
            PanelQuizBody.Location = new Point(0, 0);
            PanelQuizBody.Name = "PanelQuizBody";
            PanelQuizBody.Size = new Size(1024, 720);
            PanelQuizBody.TabIndex = 4;
            // 
            // PaginaQuiz
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(PanelQuizBody);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaginaQuiz";
            Size = new Size(1024, 720);
            Load += PaginaQuiz_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelQuizBody;
    }
}
