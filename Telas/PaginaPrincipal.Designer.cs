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
            PanelQuizDiario = new AntdUI.Panel();
            ButtonQuizRush = new AntdUI.Button();
            divider3 = new AntdUI.Divider();
            ButtonQuizDiario = new AntdUI.Button();
            divider1 = new AntdUI.Divider();
            LabelQuizzesTitulo = new AntdUI.Label();
            divider2 = new AntdUI.Divider();
            PanelResumoPreview = new AntdUI.Panel();
            TableQuizHistorico = new AntdUI.Table();
            LabelQuizzesPartidas = new AntdUI.Label();
            PanelQuizDiario.SuspendLayout();
            PanelResumoPreview.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuizDiario
            // 
            PanelQuizDiario.Back = Color.FromArgb(30, 41, 50);
            PanelQuizDiario.Controls.Add(ButtonQuizRush);
            PanelQuizDiario.Controls.Add(divider3);
            PanelQuizDiario.Controls.Add(ButtonQuizDiario);
            PanelQuizDiario.Controls.Add(divider1);
            PanelQuizDiario.Controls.Add(LabelQuizzesTitulo);
            PanelQuizDiario.Controls.Add(divider2);
            PanelQuizDiario.Dock = DockStyle.Right;
            PanelQuizDiario.Location = new Point(1030, 0);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Padding = new Padding(10);
            PanelQuizDiario.Size = new Size(250, 720);
            PanelQuizDiario.TabIndex = 0;
            PanelQuizDiario.Text = "panel1";
            // 
            // ButtonQuizRush
            // 
            ButtonQuizRush.Dock = DockStyle.Top;
            ButtonQuizRush.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizRush.Location = new Point(10, 229);
            ButtonQuizRush.Name = "ButtonQuizRush";
            ButtonQuizRush.Size = new Size(230, 58);
            ButtonQuizRush.TabIndex = 11;
            ButtonQuizRush.Text = "Rush";
            // 
            // divider3
            // 
            divider3.BackColor = Color.Transparent;
            divider3.ColorSplit = Color.SlateGray;
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider3.Location = new Point(10, 199);
            divider3.Name = "divider3";
            divider3.OrientationMargin = 0F;
            divider3.Size = new Size(230, 30);
            divider3.TabIndex = 12;
            divider3.Text = "";
            divider3.TextPadding = 0F;
            divider3.Thickness = 1F;
            // 
            // ButtonQuizDiario
            // 
            ButtonQuizDiario.Dock = DockStyle.Top;
            ButtonQuizDiario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizDiario.Location = new Point(10, 141);
            ButtonQuizDiario.Name = "ButtonQuizDiario";
            ButtonQuizDiario.Size = new Size(230, 58);
            ButtonQuizDiario.TabIndex = 1;
            ButtonQuizDiario.Text = "Diário";
            ButtonQuizDiario.Click += ButtonQuizDiario_Click;
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.ColorSplit = Color.Transparent;
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider1.Location = new Point(10, 105);
            divider1.Name = "divider1";
            divider1.OrientationMargin = 0F;
            divider1.Size = new Size(230, 36);
            divider1.TabIndex = 8;
            divider1.Text = "";
            divider1.TextPadding = 0F;
            divider1.Thickness = 1F;
            // 
            // LabelQuizzesTitulo
            // 
            LabelQuizzesTitulo.BackColor = Color.Transparent;
            LabelQuizzesTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizzesTitulo.Dock = DockStyle.Top;
            LabelQuizzesTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizzesTitulo.Location = new Point(10, 61);
            LabelQuizzesTitulo.Name = "LabelQuizzesTitulo";
            LabelQuizzesTitulo.Size = new Size(230, 44);
            LabelQuizzesTitulo.TabIndex = 9;
            LabelQuizzesTitulo.Text = "Quizzes";
            LabelQuizzesTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider2
            // 
            divider2.BackColor = Color.Transparent;
            divider2.ColorSplit = Color.Transparent;
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider2.Location = new Point(10, 10);
            divider2.Name = "divider2";
            divider2.OrientationMargin = 0F;
            divider2.Size = new Size(230, 51);
            divider2.TabIndex = 10;
            divider2.Text = "";
            divider2.TextPadding = 0F;
            divider2.Thickness = 1F;
            // 
            // PanelResumoPreview
            // 
            PanelResumoPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelResumoPreview.AutoScroll = true;
            PanelResumoPreview.BackColor = Color.FromArgb(50, 50, 55);
            PanelResumoPreview.Controls.Add(TableQuizHistorico);
            PanelResumoPreview.Controls.Add(LabelQuizzesPartidas);
            PanelResumoPreview.Location = new Point(84, 80);
            PanelResumoPreview.Name = "PanelResumoPreview";
            PanelResumoPreview.Size = new Size(850, 560);
            PanelResumoPreview.TabIndex = 1;
            PanelResumoPreview.Text = "panel2";
            // 
            // TableQuizHistorico
            // 
            TableQuizHistorico.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableQuizHistorico.Dock = DockStyle.Fill;
            TableQuizHistorico.EmptyText = "Nenhum Quiz Encontrado";
            TableQuizHistorico.EnableHeaderResizing = true;
            TableQuizHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableQuizHistorico.Gap = 12;
            TableQuizHistorico.Location = new Point(0, 39);
            TableQuizHistorico.LostFocusClearSelection = true;
            TableQuizHistorico.Name = "TableQuizHistorico";
            TableQuizHistorico.Size = new Size(850, 521);
            TableQuizHistorico.TabIndex = 2;
            // 
            // LabelQuizzesPartidas
            // 
            LabelQuizzesPartidas.Dock = DockStyle.Top;
            LabelQuizzesPartidas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizzesPartidas.Location = new Point(0, 0);
            LabelQuizzesPartidas.Name = "LabelQuizzesPartidas";
            LabelQuizzesPartidas.Size = new Size(850, 39);
            LabelQuizzesPartidas.TabIndex = 0;
            LabelQuizzesPartidas.Text = "Últimos 10 Quizzes";
            LabelQuizzesPartidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 64, 70);
            Controls.Add(PanelResumoPreview);
            Controls.Add(PanelQuizDiario);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1280, 720);
            Load += PaginaPrincipal_Load;
            PanelQuizDiario.ResumeLayout(false);
            PanelResumoPreview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelQuizDiario;
        private AntdUI.Button ButtonQuizDiario;
        private AntdUI.Panel PanelResumoPreview;
        private AntdUI.Label LabelQuizzesPartidas;
        private AntdUI.Button ButtonQuizRush;
        private AntdUI.Divider divider3;
        private AntdUI.Divider divider1;
        private AntdUI.Label LabelQuizzesTitulo;
        private AntdUI.Divider divider2;
        private AntdUI.Table TableQuizHistorico;
    }
}
