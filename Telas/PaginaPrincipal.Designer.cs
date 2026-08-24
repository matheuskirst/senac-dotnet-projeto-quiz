namespace SenacQuizApp.Telas
{
    partial class PaginaPrincipal
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
            ButtonIniciarQuiz = new AntdUI.Button();
            SuspendLayout();
            // 
            // ButtonIniciarQuiz
            // 
            ButtonIniciarQuiz.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonIniciarQuiz.Location = new Point(364, 330);
            ButtonIniciarQuiz.Name = "ButtonIniciarQuiz";
            ButtonIniciarQuiz.Size = new Size(290, 83);
            ButtonIniciarQuiz.TabIndex = 0;
            ButtonIniciarQuiz.Text = "Iniciar Quiz";
            ButtonIniciarQuiz.Click += ButtonIniciarQuiz_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(ButtonIniciarQuiz);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1024, 720);
            Load += PaginaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button ButtonIniciarQuiz;
    }
}
