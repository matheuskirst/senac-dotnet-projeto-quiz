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
            LabelProgresso = new AntdUI.Label();
            PanelIcone = new AntdUI.Panel();
            PanelProgresso = new AntdUI.Panel();
            progress1 = new AntdUI.Progress();
            label1 = new AntdUI.Label();
            PanelProgresso.SuspendLayout();
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
            LabelNome.Size = new Size(452, 24);
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
            LabelDescricao.Size = new Size(451, 30);
            LabelDescricao.TabIndex = 1;
            LabelDescricao.Text = "Descrição";
            LabelDescricao.TextAlign = ContentAlignment.TopLeft;
            // 
            // LabelProgresso
            // 
            LabelProgresso.BackColor = Color.Transparent;
            LabelProgresso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelProgresso.ForeColor = SystemColors.ScrollBar;
            LabelProgresso.Location = new Point(11, 11);
            LabelProgresso.Name = "LabelProgresso";
            LabelProgresso.Prefix = "";
            LabelProgresso.Size = new Size(250, 22);
            LabelProgresso.TabIndex = 2;
            LabelProgresso.Text = "Data de aquisição: DD/MM/AAAA - hh:mm:ss";
            LabelProgresso.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PanelIcone
            // 
            PanelIcone.Location = new Point(13, 15);
            PanelIcone.Name = "PanelIcone";
            PanelIcone.Size = new Size(60, 60);
            PanelIcone.TabIndex = 3;
            // 
            // PanelProgresso
            // 
            PanelProgresso.Back = Color.Transparent;
            PanelProgresso.Controls.Add(progress1);
            PanelProgresso.Controls.Add(LabelProgresso);
            PanelProgresso.Dock = DockStyle.Right;
            PanelProgresso.Location = new Point(526, 10);
            PanelProgresso.Name = "PanelProgresso";
            PanelProgresso.Size = new Size(264, 70);
            PanelProgresso.TabIndex = 4;
            // 
            // progress1
            // 
            progress1.ColorScheme = AntdUI.TAMode.Dark;
            progress1.Location = new Point(22, 37);
            progress1.Name = "progress1";
            progress1.Size = new Size(239, 23);
            progress1.TabIndex = 3;
            progress1.Text = "progress1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(150, 150, 150);
            label1.Location = new Point(80, 63);
            label1.Name = "label1";
            label1.Size = new Size(451, 20);
            label1.TabIndex = 5;
            label1.Text = "00.0% dos jogadores tem essa conquista";
            // 
            // CardConquista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(label1);
            Controls.Add(PanelProgresso);
            Controls.Add(PanelIcone);
            Controls.Add(LabelDescricao);
            Controls.Add(LabelNome);
            Name = "CardConquista";
            Padding = new Padding(10);
            Size = new Size(800, 90);
            PanelProgresso.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelNome;
        private AntdUI.Label LabelDescricao;
        private AntdUI.Label LabelProgresso;
        private AntdUI.Panel PanelIcone;
        private AntdUI.Panel PanelProgresso;
        private AntdUI.Progress progress1;
        private AntdUI.Label label1;
    }
}
