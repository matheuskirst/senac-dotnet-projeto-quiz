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
            LabelTitulo = new AntdUI.Label();
            LabelDescricao = new AntdUI.Label();
            LabelDataDeAquisicao = new AntdUI.Label();
            LabelTempoDesbloqueado = new AntdUI.Label();
            SuspendLayout();
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = SystemColors.ControlDarkDark;
            LabelTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.ForeColor = Color.White;
            LabelTitulo.Location = new Point(15, 3);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(331, 41);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Título:";
            // 
            // LabelDescricao
            // 
            LabelDescricao.Anchor = AnchorStyles.Left;
            LabelDescricao.BackColor = SystemColors.ControlDarkDark;
            LabelDescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDescricao.ForeColor = Color.White;
            LabelDescricao.Location = new Point(15, 65);
            LabelDescricao.Name = "LabelDescricao";
            LabelDescricao.Size = new Size(451, 45);
            LabelDescricao.TabIndex = 1;
            LabelDescricao.Text = "Descrição:";
            // 
            // LabelDataDeAquisicao
            // 
            LabelDataDeAquisicao.Anchor = AnchorStyles.Top;
            LabelDataDeAquisicao.BackColor = SystemColors.ControlDarkDark;
            LabelDataDeAquisicao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataDeAquisicao.ForeColor = Color.White;
            LabelDataDeAquisicao.Location = new Point(688, 3);
            LabelDataDeAquisicao.Name = "LabelDataDeAquisicao";
            LabelDataDeAquisicao.Size = new Size(240, 41);
            LabelDataDeAquisicao.TabIndex = 2;
            LabelDataDeAquisicao.Text = "Data de aquisição:";
            LabelDataDeAquisicao.Click += this.label3_Click;
            // 
            // LabelTempoDesbloqueado
            // 
            LabelTempoDesbloqueado.Anchor = AnchorStyles.None;
            LabelTempoDesbloqueado.BackColor = SystemColors.ControlDarkDark;
            LabelTempoDesbloqueado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTempoDesbloqueado.ForeColor = Color.White;
            LabelTempoDesbloqueado.Location = new Point(688, 74);
            LabelTempoDesbloqueado.Name = "LabelTempoDesbloqueado";
            LabelTempoDesbloqueado.Size = new Size(274, 36);
            LabelTempoDesbloqueado.TabIndex = 3;
            LabelTempoDesbloqueado.Text = "Há quanto tempo desbloqueado";
            // 
            // CardConquista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(LabelTempoDesbloqueado);
            Controls.Add(LabelDataDeAquisicao);
            Controls.Add(LabelDescricao);
            Controls.Add(LabelTitulo);
            Name = "CardConquista";
            Size = new Size(980, 125);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelTitulo;
        private AntdUI.Label LabelDescricao;
        private AntdUI.Label LabelDataDeAquisicao;
        private AntdUI.Label LabelTempoDesbloqueado;
    }
}
