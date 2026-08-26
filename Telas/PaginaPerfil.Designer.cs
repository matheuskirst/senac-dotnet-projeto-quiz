namespace SenacQuizApp.Telas
{
    partial class PaginaPerfil
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
            LabelNivel = new AntdUI.Label();
            LabelUsuario = new AntdUI.Label();
            LabelPontuacao = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            ButtonConquistas = new AntdUI.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelNivel
            // 
            LabelNivel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelNivel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNivel.Location = new Point(23, 59);
            LabelNivel.Name = "LabelNivel";
            LabelNivel.Prefix = "Nivel: ";
            LabelNivel.Size = new Size(127, 27);
            LabelNivel.TabIndex = 0;
            LabelNivel.Text = "0";
            // 
            // LabelUsuario
            // 
            LabelUsuario.BackColor = SystemColors.ButtonHighlight;
            LabelUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.Black;
            LabelUsuario.Location = new Point(51, 36);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Prefix = "Usuario: ";
            LabelUsuario.Size = new Size(108, 38);
            LabelUsuario.TabIndex = 1;
            LabelUsuario.Text = "a";
            // 
            // LabelPontuacao
            // 
            LabelPontuacao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelPontuacao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPontuacao.Location = new Point(22, 92);
            LabelPontuacao.Name = "LabelPontuacao";
            LabelPontuacao.Prefix = "Pontuação: ";
            LabelPontuacao.Size = new Size(127, 27);
            LabelPontuacao.TabIndex = 2;
            LabelPontuacao.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(ButtonConquistas);
            panel1.Controls.Add(LabelNivel);
            panel1.Controls.Add(LabelPontuacao);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1108, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 742);
            panel1.TabIndex = 3;
            panel1.Text = "panel1";
            // 
            // ButtonConquistas
            // 
            ButtonConquistas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonConquistas.DefaultBack = SystemColors.Control;
            ButtonConquistas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConquistas.Location = new Point(22, 304);
            ButtonConquistas.Name = "ButtonConquistas";
            ButtonConquistas.OriginalBackColor = SystemColors.Control;
            ButtonConquistas.Size = new Size(127, 45);
            ButtonConquistas.TabIndex = 3;
            ButtonConquistas.Text = "Conquistas";
            ButtonConquistas.Click += ButtonConquistas_Click;
            // 
            // PaginaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(LabelUsuario);
            Name = "PaginaPerfil";
            Size = new Size(1278, 742);
            Load += PaginaPerfil_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelNivel;
        private AntdUI.Label LabelUsuario;
        private AntdUI.Label LabelPontuacao;
        private AntdUI.Panel panel1;
        private AntdUI.Button ButtonConquistas;
    }
}
