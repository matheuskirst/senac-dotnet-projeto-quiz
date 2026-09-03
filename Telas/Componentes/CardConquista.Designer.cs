namespace SenacQuizApp.Telas
{
    partial class CardConquista
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
            LabelNome = new AntdUI.Label();
            LabelDescricao = new AntdUI.Label();
            PanelIcone = new AntdUI.Panel();
            LabelPorcentagemGlobal = new AntdUI.Label();
            LabelData = new AntdUI.Label();
            SuspendLayout();
            // 
            // LabelNome
            // 
            LabelNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelNome.BackColor = Color.Transparent;
            LabelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNome.ForeColor = Color.WhiteSmoke;
            LabelNome.Location = new Point(79, 13);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(455, 24);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Nome";
            // 
            // LabelDescricao
            // 
            LabelDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelDescricao.BackColor = Color.Transparent;
            LabelDescricao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDescricao.ForeColor = Color.FromArgb(224, 224, 224);
            LabelDescricao.Location = new Point(80, 37);
            LabelDescricao.Name = "LabelDescricao";
            LabelDescricao.Size = new Size(454, 30);
            LabelDescricao.TabIndex = 1;
            LabelDescricao.Text = "Descrição";
            LabelDescricao.TextAlign = ContentAlignment.TopLeft;
            // 
            // PanelIcone
            // 
            PanelIcone.Back = Color.Black;
            PanelIcone.Location = new Point(13, 15);
            PanelIcone.Name = "PanelIcone";
            PanelIcone.Size = new Size(60, 60);
            PanelIcone.TabIndex = 3;
            // 
            // LabelPorcentagemGlobal
            // 
            LabelPorcentagemGlobal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelPorcentagemGlobal.BackColor = Color.Transparent;
            LabelPorcentagemGlobal.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPorcentagemGlobal.ForeColor = Color.FromArgb(150, 150, 150);
            LabelPorcentagemGlobal.Location = new Point(80, 63);
            LabelPorcentagemGlobal.Name = "LabelPorcentagemGlobal";
            LabelPorcentagemGlobal.Size = new Size(454, 20);
            LabelPorcentagemGlobal.Suffix = " dos jogadores tem essa conquista";
            LabelPorcentagemGlobal.TabIndex = 5;
            LabelPorcentagemGlobal.Text = "00.0%";
            // 
            // LabelData
            // 
            LabelData.Anchor = AnchorStyles.Right;
            LabelData.BackColor = Color.Transparent;
            LabelData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelData.ForeColor = SystemColors.ScrollBar;
            LabelData.Location = new Point(540, 32);
            LabelData.Name = "LabelData";
            LabelData.Prefix = "Desbloqueou em: ";
            LabelData.Size = new Size(250, 27);
            LabelData.TabIndex = 6;
            LabelData.Text = "DD/MM/AAAA - hh:mm:ss";
            LabelData.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CardConquista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(LabelData);
            Controls.Add(LabelPorcentagemGlobal);
            Controls.Add(LabelDescricao);
            Controls.Add(LabelNome);
            Controls.Add(PanelIcone);
            Name = "CardConquista";
            Padding = new Padding(10);
            Size = new Size(803, 90);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelNome;
        private AntdUI.Label LabelDescricao;
        private AntdUI.Panel PanelIcone;
        private AntdUI.Label LabelPorcentagemGlobal;
        private AntdUI.Label LabelData;
    }
}
