namespace SenacQuizApp.Telas.Componentes.Quiz
{
    partial class HistoricoQuizDiario
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
            TableQuizHistorico = new AntdUI.Table();
            SuspendLayout();
            // 
            // TableQuizHistorico
            // 
            TableQuizHistorico.Dock = DockStyle.Fill;
            TableQuizHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableQuizHistorico.Gap = 12;
            TableQuizHistorico.Location = new Point(0, 0);
            TableQuizHistorico.Name = "TableQuizHistorico";
            TableQuizHistorico.Size = new Size(950, 700);
            TableQuizHistorico.TabIndex = 0;
            // 
            // HistoricoQuizDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableQuizHistorico);
            Name = "HistoricoQuizDiario";
            Size = new Size(950, 700);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table TableQuizHistorico;
    }
}
