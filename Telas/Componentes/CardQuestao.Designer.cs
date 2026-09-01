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
            PanelProgresso = new AntdUI.Panel();
            SuspendLayout();
            // 
            // LabelEnunciado
            // 
            LabelEnunciado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelEnunciado.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelEnunciado.BackColor = Color.Transparent;
            LabelEnunciado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEnunciado.ForeColor = Color.FromArgb(224, 224, 224);
            LabelEnunciado.Location = new Point(12, 42);
            LabelEnunciado.Name = "LabelEnunciado";
            LabelEnunciado.Size = new Size(451, 22);
            LabelEnunciado.TabIndex = 7;
            LabelEnunciado.Text = "Enunciado";
            LabelEnunciado.TextAlign = ContentAlignment.TopLeft;
            // 
            // LabelIndex
            // 
            LabelIndex.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelIndex.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelIndex.BackColor = Color.Transparent;
            LabelIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelIndex.ForeColor = Color.WhiteSmoke;
            LabelIndex.Location = new Point(11, 13);
            LabelIndex.Name = "LabelIndex";
            LabelIndex.Prefix = "Questão: ";
            LabelIndex.Size = new Size(79, 24);
            LabelIndex.TabIndex = 6;
            LabelIndex.Text = "#";
            // 
            // PanelProgresso
            // 
            PanelProgresso.Back = Color.Transparent;
            PanelProgresso.Dock = DockStyle.Right;
            PanelProgresso.Location = new Point(449, 10);
            PanelProgresso.Name = "PanelProgresso";
            PanelProgresso.Size = new Size(341, 130);
            PanelProgresso.TabIndex = 9;
            // 
            // CardQuestao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(LabelEnunciado);
            Controls.Add(LabelIndex);
            Controls.Add(PanelProgresso);
            Name = "CardQuestao";
            Padding = new Padding(10);
            Size = new Size(800, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label LabelEnunciado;
        private AntdUI.Label LabelIndex;
        private AntdUI.Panel PanelProgresso;
    }
}
