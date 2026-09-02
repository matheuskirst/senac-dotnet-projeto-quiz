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
            LabelPorcentagemJogadores = new AntdUI.Label();
            LabelAquisicao = new AntdUI.Label();
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
            // LabelPorcentagemJogadores
            // 
            LabelPorcentagemJogadores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelPorcentagemJogadores.BackColor = Color.Transparent;
            LabelPorcentagemJogadores.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPorcentagemJogadores.ForeColor = Color.FromArgb(150, 150, 150);
            LabelPorcentagemJogadores.Location = new Point(80, 63);
            LabelPorcentagemJogadores.Name = "LabelPorcentagemJogadores";
            LabelPorcentagemJogadores.Size = new Size(454, 20);
            LabelPorcentagemJogadores.Suffix = " dos jogadores tem essa conquista";
            LabelPorcentagemJogadores.TabIndex = 5;
            LabelPorcentagemJogadores.Text = "00.0%";
            // 
            // LabelAquisicao
            // 
            LabelAquisicao.Anchor = AnchorStyles.Right;
            LabelAquisicao.BackColor = Color.Transparent;
            LabelAquisicao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAquisicao.ForeColor = SystemColors.ScrollBar;
            LabelAquisicao.Location = new Point(540, 32);
            LabelAquisicao.Name = "LabelAquisicao";
            LabelAquisicao.Prefix = "Desbloqueou em: ";
            LabelAquisicao.Size = new Size(250, 27);
            LabelAquisicao.TabIndex = 6;
            LabelAquisicao.Text = "DD/MM/AAAA - hh:mm:ss";
            LabelAquisicao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CardConquista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(LabelAquisicao);
            Controls.Add(LabelPorcentagemJogadores);
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
        private AntdUI.Label LabelPorcentagemJogadores;
        private AntdUI.Label LabelAquisicao;
    }
}
