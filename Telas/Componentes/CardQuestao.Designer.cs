namespace SenacQuizApp.Telas.Componentes
{
    partial class CardQuestao
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
            LabelEnunciado = new AntdUI.Label();
            LabelIndex = new AntdUI.Label();
            StackPanelAlternativas = new AntdUI.StackPanel();
            LabelAcertou = new AntdUI.Label();
            SuspendLayout();
            // 
            // LabelEnunciado
            // 
            LabelEnunciado.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelEnunciado.Dock = DockStyle.Top;
            LabelEnunciado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEnunciado.ForeColor = Color.FromArgb(224, 224, 224);
            LabelEnunciado.Location = new Point(10, 58);
            LabelEnunciado.Name = "LabelEnunciado";
            LabelEnunciado.Size = new Size(780, 22);
            LabelEnunciado.TabIndex = 7;
            LabelEnunciado.Text = "Enunciado";
            LabelEnunciado.TextAlign = ContentAlignment.TopLeft;
            LabelEnunciado.TextMultiLine = false;
            // 
            // LabelIndex
            // 
            LabelIndex.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelIndex.Dock = DockStyle.Top;
            LabelIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelIndex.ForeColor = Color.WhiteSmoke;
            LabelIndex.Location = new Point(10, 10);
            LabelIndex.Name = "LabelIndex";
            LabelIndex.Prefix = "Questão: ";
            LabelIndex.Size = new Size(79, 24);
            LabelIndex.TabIndex = 6;
            LabelIndex.Text = "#";
            LabelIndex.TextMultiLine = false;
            // 
            // StackPanelAlternativas
            // 
            StackPanelAlternativas.Dock = DockStyle.Bottom;
            StackPanelAlternativas.Location = new Point(10, 110);
            StackPanelAlternativas.Name = "StackPanelAlternativas";
            StackPanelAlternativas.Size = new Size(780, 100);
            StackPanelAlternativas.TabIndex = 8;
            StackPanelAlternativas.Text = "stackPanel1";
            StackPanelAlternativas.Vertical = true;
            // 
            // LabelAcertou
            // 
            LabelAcertou.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelAcertou.Dock = DockStyle.Top;
            LabelAcertou.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAcertou.ForeColor = Color.FromArgb(224, 224, 224);
            LabelAcertou.Location = new Point(10, 34);
            LabelAcertou.Name = "LabelAcertou";
            LabelAcertou.Prefix = "Acertou: ";
            LabelAcertou.Size = new Size(780, 24);
            LabelAcertou.TabIndex = 9;
            LabelAcertou.Text = "#";
            LabelAcertou.TextAlign = ContentAlignment.TopLeft;
            LabelAcertou.TextMultiLine = false;
            // 
            // CardQuestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(StackPanelAlternativas);
            Controls.Add(LabelEnunciado);
            Controls.Add(LabelAcertou);
            Controls.Add(LabelIndex);
            Name = "CardQuestao";
            Padding = new Padding(10);
            Size = new Size(800, 220);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label LabelEnunciado;
        private AntdUI.Label LabelIndex;
        private AntdUI.StackPanel StackPanelAlternativas;
        private AntdUI.Label LabelAcertou;
    }
}
