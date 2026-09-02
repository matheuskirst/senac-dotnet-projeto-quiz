namespace SenacQuizApp.Telas.QuizRush
{
    partial class IniciarQuizRush
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
            LabelQuizDiarioTitulo = new AntdUI.Label();
            PanelQuizDiario = new AntdUI.Panel();
            ButtonQuizRush = new AntdUI.Button();
            PanelQuizDiario.SuspendLayout();
            SuspendLayout();
            // 
            // LabelQuizDiarioTitulo
            // 
            LabelQuizDiarioTitulo.BackColor = Color.Transparent;
            LabelQuizDiarioTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizDiarioTitulo.Dock = DockStyle.Top;
            LabelQuizDiarioTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizDiarioTitulo.Location = new Point(0, 0);
            LabelQuizDiarioTitulo.Name = "LabelQuizDiarioTitulo";
            LabelQuizDiarioTitulo.Size = new Size(400, 64);
            LabelQuizDiarioTitulo.TabIndex = 2;
            LabelQuizDiarioTitulo.Text = "Quiz Rush";
            LabelQuizDiarioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelQuizDiario
            // 
            PanelQuizDiario.Anchor = AnchorStyles.None;
            PanelQuizDiario.Back = Color.FromArgb(33, 33, 33);
            PanelQuizDiario.Controls.Add(ButtonQuizRush);
            PanelQuizDiario.Controls.Add(LabelQuizDiarioTitulo);
            PanelQuizDiario.Location = new Point(312, 236);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Size = new Size(400, 248);
            PanelQuizDiario.TabIndex = 4;
            PanelQuizDiario.Text = "panel1";
            // 
            // ButtonQuizRush
            // 
            ButtonQuizRush.BorderWidth = 1F;
            ButtonQuizRush.ColorScheme = AntdUI.TAMode.Dark;
            ButtonQuizRush.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizRush.Location = new Point(121, 125);
            ButtonQuizRush.Name = "ButtonQuizRush";
            ButtonQuizRush.Size = new Size(158, 58);
            ButtonQuizRush.TabIndex = 5;
            ButtonQuizRush.Text = "Iniciar";
            ButtonQuizRush.Click += ButtonQuizRush_Click;
            // 
            // IniciarQuizRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelQuizDiario);
            Name = "IniciarQuizRush";
            Size = new Size(1024, 720);
            PanelQuizDiario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelQuizDiarioTitulo;
        private AntdUI.Panel PanelQuizDiario;
        private AntdUI.Button ButtonQuizRush;
    }
}
