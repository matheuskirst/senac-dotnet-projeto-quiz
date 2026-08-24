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
            TableLayoutPanelPrincipal = new TableLayoutPanel();
            ButtonIniciarQuiz = new AntdUI.Button();
            TableLayoutPanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelPrincipal
            // 
            TableLayoutPanelPrincipal.BackColor = Color.Transparent;
            TableLayoutPanelPrincipal.ColumnCount = 3;
            TableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.Controls.Add(ButtonIniciarQuiz, 1, 1);
            TableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            TableLayoutPanelPrincipal.Location = new Point(0, 0);
            TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal";
            TableLayoutPanelPrincipal.RowCount = 4;
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.Size = new Size(1024, 720);
            TableLayoutPanelPrincipal.TabIndex = 6;
            // 
            // ButtonIniciarQuiz
            // 
            ButtonIniciarQuiz.Anchor = AnchorStyles.None;
            ButtonIniciarQuiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonIniciarQuiz.Location = new Point(396, 286);
            ButtonIniciarQuiz.Name = "ButtonIniciarQuiz";
            ButtonIniciarQuiz.Size = new Size(231, 77);
            ButtonIniciarQuiz.TabIndex = 0;
            ButtonIniciarQuiz.Text = "Iniciar Quiz";
            ButtonIniciarQuiz.Click += ButtonIniciarQuiz_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(TableLayoutPanelPrincipal);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1024, 720);
            Load += PaginaPrincipal_Load;
            TableLayoutPanelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelPrincipal;
        private AntdUI.Button ButtonIniciarQuiz;
    }
}
