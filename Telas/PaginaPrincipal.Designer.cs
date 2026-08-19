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
            PanelPrincipalCentro = new TableLayoutPanel();
            ButtonIniciarQuizDiario = new AntdUI.Button();
            PanelPrincipalHeader = new TableLayoutPanel();
            PanelPrincipalHeaderEsquerda = new AntdUI.StackPanel();
            ButtonPrincipalSair = new AntdUI.Button();
            PanelPrincipalFooter = new TableLayoutPanel();
            PanelPrincipalFooterEsquerda = new AntdUI.StackPanel();
            ButtonPrincipalRanking = new AntdUI.Button();
            PanelPrincipalHeaderDireita = new AntdUI.StackPanel();
            PanelPrincipalFooterDireita = new AntdUI.StackPanel();
            ButtonPrincipalPerfil = new AntdUI.Button();
            PanelPrincipalCentro.SuspendLayout();
            PanelPrincipalHeader.SuspendLayout();
            PanelPrincipalHeaderEsquerda.SuspendLayout();
            PanelPrincipalFooter.SuspendLayout();
            PanelPrincipalHeaderDireita.SuspendLayout();
            PanelPrincipalFooterDireita.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipalCentro
            // 
            PanelPrincipalCentro.ColumnCount = 1;
            PanelPrincipalCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelPrincipalCentro.Controls.Add(PanelPrincipalFooter, 0, 2);
            PanelPrincipalCentro.Controls.Add(ButtonIniciarQuizDiario, 0, 1);
            PanelPrincipalCentro.Controls.Add(PanelPrincipalHeader, 0, 0);
            PanelPrincipalCentro.Dock = DockStyle.Fill;
            PanelPrincipalCentro.Location = new Point(0, 0);
            PanelPrincipalCentro.Name = "PanelPrincipalCentro";
            PanelPrincipalCentro.RowCount = 3;
            PanelPrincipalCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PanelPrincipalCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelPrincipalCentro.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PanelPrincipalCentro.Size = new Size(1024, 720);
            PanelPrincipalCentro.TabIndex = 0;
            // 
            // ButtonIniciarQuizDiario
            // 
            ButtonIniciarQuizDiario.Anchor = AnchorStyles.None;
            ButtonIniciarQuizDiario.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonIniciarQuizDiario.Location = new Point(362, 325);
            ButtonIniciarQuizDiario.Name = "ButtonIniciarQuizDiario";
            ButtonIniciarQuizDiario.Size = new Size(300, 70);
            ButtonIniciarQuizDiario.TabIndex = 0;
            ButtonIniciarQuizDiario.Text = "Iniciar Quiz";
            ButtonIniciarQuizDiario.Click += ButtonIniciarQuizDiario_Click;
            // 
            // PanelPrincipalHeader
            // 
            PanelPrincipalHeader.ColumnCount = 2;
            PanelPrincipalHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPrincipalHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPrincipalHeader.Controls.Add(PanelPrincipalHeaderEsquerda, 0, 0);
            PanelPrincipalHeader.Controls.Add(PanelPrincipalHeaderDireita, 1, 0);
            PanelPrincipalHeader.Dock = DockStyle.Fill;
            PanelPrincipalHeader.Location = new Point(3, 3);
            PanelPrincipalHeader.Name = "PanelPrincipalHeader";
            PanelPrincipalHeader.RowCount = 1;
            PanelPrincipalHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelPrincipalHeader.Size = new Size(1018, 54);
            PanelPrincipalHeader.TabIndex = 1;
            // 
            // PanelPrincipalHeaderEsquerda
            // 
            PanelPrincipalHeaderEsquerda.Controls.Add(ButtonPrincipalSair);
            PanelPrincipalHeaderEsquerda.Dock = DockStyle.Fill;
            PanelPrincipalHeaderEsquerda.Location = new Point(0, 0);
            PanelPrincipalHeaderEsquerda.Margin = new Padding(0);
            PanelPrincipalHeaderEsquerda.Name = "PanelPrincipalHeaderEsquerda";
            PanelPrincipalHeaderEsquerda.Size = new Size(509, 54);
            PanelPrincipalHeaderEsquerda.TabIndex = 2;
            PanelPrincipalHeaderEsquerda.Text = "stackPanel1";
            // 
            // ButtonPrincipalSair
            // 
            ButtonPrincipalSair.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPrincipalSair.Location = new Point(3, 3);
            ButtonPrincipalSair.Name = "ButtonPrincipalSair";
            ButtonPrincipalSair.Size = new Size(100, 48);
            ButtonPrincipalSair.TabIndex = 1;
            ButtonPrincipalSair.Text = "Sair";
            ButtonPrincipalSair.Click += ButtonPrincipalSair_Click_1;
            // 
            // PanelPrincipalFooter
            // 
            PanelPrincipalFooter.ColumnCount = 2;
            PanelPrincipalFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPrincipalFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelPrincipalFooter.Controls.Add(PanelPrincipalFooterEsquerda, 0, 0);
            PanelPrincipalFooter.Controls.Add(PanelPrincipalFooterDireita, 1, 0);
            PanelPrincipalFooter.Dock = DockStyle.Fill;
            PanelPrincipalFooter.Location = new Point(3, 663);
            PanelPrincipalFooter.Name = "PanelPrincipalFooter";
            PanelPrincipalFooter.RowCount = 1;
            PanelPrincipalFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelPrincipalFooter.Size = new Size(1018, 54);
            PanelPrincipalFooter.TabIndex = 2;
            // 
            // PanelPrincipalFooterEsquerda
            // 
            PanelPrincipalFooterEsquerda.Dock = DockStyle.Fill;
            PanelPrincipalFooterEsquerda.Location = new Point(0, 0);
            PanelPrincipalFooterEsquerda.Margin = new Padding(0);
            PanelPrincipalFooterEsquerda.Name = "PanelPrincipalFooterEsquerda";
            PanelPrincipalFooterEsquerda.Size = new Size(509, 54);
            PanelPrincipalFooterEsquerda.TabIndex = 2;
            PanelPrincipalFooterEsquerda.Text = "stackPanel1";
            // 
            // ButtonPrincipalRanking
            // 
            ButtonPrincipalRanking.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPrincipalRanking.Location = new Point(406, 3);
            ButtonPrincipalRanking.Name = "ButtonPrincipalRanking";
            ButtonPrincipalRanking.Size = new Size(100, 48);
            ButtonPrincipalRanking.TabIndex = 1;
            ButtonPrincipalRanking.Text = "Ranking";
            ButtonPrincipalRanking.Click += ButtonPrincipalRanking_Click;
            // 
            // PanelPrincipalHeaderDireita
            // 
            PanelPrincipalHeaderDireita.Controls.Add(ButtonPrincipalPerfil);
            PanelPrincipalHeaderDireita.Dock = DockStyle.Fill;
            PanelPrincipalHeaderDireita.Location = new Point(509, 0);
            PanelPrincipalHeaderDireita.Margin = new Padding(0);
            PanelPrincipalHeaderDireita.Name = "PanelPrincipalHeaderDireita";
            PanelPrincipalHeaderDireita.RightToLeft = RightToLeft.Yes;
            PanelPrincipalHeaderDireita.Size = new Size(509, 54);
            PanelPrincipalHeaderDireita.TabIndex = 3;
            PanelPrincipalHeaderDireita.Text = "stackPanel1";
            // 
            // PanelPrincipalFooterDireita
            // 
            PanelPrincipalFooterDireita.Controls.Add(ButtonPrincipalRanking);
            PanelPrincipalFooterDireita.Dock = DockStyle.Fill;
            PanelPrincipalFooterDireita.Location = new Point(509, 0);
            PanelPrincipalFooterDireita.Margin = new Padding(0);
            PanelPrincipalFooterDireita.Name = "PanelPrincipalFooterDireita";
            PanelPrincipalFooterDireita.RightToLeft = RightToLeft.Yes;
            PanelPrincipalFooterDireita.Size = new Size(509, 54);
            PanelPrincipalFooterDireita.TabIndex = 3;
            PanelPrincipalFooterDireita.Text = "stackPanel1";
            // 
            // ButtonPrincipalPerfil
            // 
            ButtonPrincipalPerfil.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPrincipalPerfil.Location = new Point(406, 3);
            ButtonPrincipalPerfil.Name = "ButtonPrincipalPerfil";
            ButtonPrincipalPerfil.Size = new Size(100, 48);
            ButtonPrincipalPerfil.TabIndex = 2;
            ButtonPrincipalPerfil.Text = "Perfil";
            ButtonPrincipalPerfil.Click += ButtonPrincipalPerfil_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(PanelPrincipalCentro);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1024, 720);
            PanelPrincipalCentro.ResumeLayout(false);
            PanelPrincipalHeader.ResumeLayout(false);
            PanelPrincipalHeaderEsquerda.ResumeLayout(false);
            PanelPrincipalFooter.ResumeLayout(false);
            PanelPrincipalHeaderDireita.ResumeLayout(false);
            PanelPrincipalFooterDireita.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelPrincipalCentro;
        private AntdUI.Button ButtonIniciarQuizDiario;
        private TableLayoutPanel PanelPrincipalFooter;
        private AntdUI.StackPanel PanelPrincipalFooterEsquerda;
        private AntdUI.Button ButtonPrincipalRanking;
        private TableLayoutPanel PanelPrincipalHeader;
        private AntdUI.StackPanel PanelPrincipalHeaderEsquerda;
        private AntdUI.Button ButtonPrincipalSair;
        private AntdUI.StackPanel PanelPrincipalFooterDireita;
        private AntdUI.StackPanel PanelPrincipalHeaderDireita;
        private AntdUI.Button ButtonPrincipalPerfil;
    }
}
