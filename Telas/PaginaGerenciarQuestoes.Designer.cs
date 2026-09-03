namespace SenacQuizApp.Telas
{
    partial class PaginaGerenciarQuestoes
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
            PanelHistorico = new AntdUI.Panel();
            PanelInserirHistorico = new AntdUI.Panel();
            TableHistorico = new AntdUI.Table();
            PanelHistoricoFiltros = new AntdUI.Panel();
            LabelNivel = new AntdUI.Label();
            SelectNivel = new AntdUI.Select();
            LabelTema = new AntdUI.Label();
            SelectTema = new AntdUI.Select();
            InputEnunciado = new AntdUI.Input();
            ButtonBuscarData = new AntdUI.Button();
            LabelTipoQuiz = new AntdUI.Label();
            SelectQuizTipo = new AntdUI.Select();
            LabelData = new AntdUI.Label();
            PanelHistorico.SuspendLayout();
            PanelInserirHistorico.SuspendLayout();
            PanelHistoricoFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHistorico
            // 
            PanelHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelHistorico.AutoScroll = true;
            PanelHistorico.Back = Color.FromArgb(33, 33, 33);
            PanelHistorico.Controls.Add(PanelInserirHistorico);
            PanelHistorico.Controls.Add(PanelHistoricoFiltros);
            PanelHistorico.Location = new Point(215, 50);
            PanelHistorico.Name = "PanelHistorico";
            PanelHistorico.Size = new Size(850, 620);
            PanelHistorico.TabIndex = 3;
            PanelHistorico.Text = "panel2";
            // 
            // PanelInserirHistorico
            // 
            PanelInserirHistorico.Back = Color.FromArgb(33, 33, 33);
            PanelInserirHistorico.Controls.Add(TableHistorico);
            PanelInserirHistorico.Dock = DockStyle.Fill;
            PanelInserirHistorico.Location = new Point(0, 35);
            PanelInserirHistorico.Name = "PanelInserirHistorico";
            PanelInserirHistorico.Radius = 0;
            PanelInserirHistorico.Size = new Size(850, 585);
            PanelInserirHistorico.TabIndex = 5;
            PanelInserirHistorico.Text = "panel1";
            // 
            // TableHistorico
            // 
            TableHistorico.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableHistorico.BackColor = Color.FromArgb(33, 33, 33);
            TableHistorico.ColorScheme = AntdUI.TAMode.Dark;
            TableHistorico.ColumnDragSort = true;
            TableHistorico.Dock = DockStyle.Fill;
            TableHistorico.EmptyText = "Nenhuma pergunta encontrada";
            TableHistorico.EnableHeaderResizing = true;
            TableHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableHistorico.Gap = 12;
            TableHistorico.Location = new Point(0, 0);
            TableHistorico.Name = "TableHistorico";
            TableHistorico.Size = new Size(850, 585);
            TableHistorico.TabIndex = 0;
            // 
            // PanelHistoricoFiltros
            // 
            PanelHistoricoFiltros.Back = Color.FromArgb(33, 33, 33);
            PanelHistoricoFiltros.ColorScheme = AntdUI.TAMode.Dark;
            PanelHistoricoFiltros.Controls.Add(LabelNivel);
            PanelHistoricoFiltros.Controls.Add(SelectNivel);
            PanelHistoricoFiltros.Controls.Add(LabelTema);
            PanelHistoricoFiltros.Controls.Add(SelectTema);
            PanelHistoricoFiltros.Controls.Add(InputEnunciado);
            PanelHistoricoFiltros.Controls.Add(ButtonBuscarData);
            PanelHistoricoFiltros.Controls.Add(LabelTipoQuiz);
            PanelHistoricoFiltros.Controls.Add(SelectQuizTipo);
            PanelHistoricoFiltros.Controls.Add(LabelData);
            PanelHistoricoFiltros.Dock = DockStyle.Top;
            PanelHistoricoFiltros.Location = new Point(0, 0);
            PanelHistoricoFiltros.Name = "PanelHistoricoFiltros";
            PanelHistoricoFiltros.Padding = new Padding(5, 0, 5, 0);
            PanelHistoricoFiltros.Radius = 0;
            PanelHistoricoFiltros.Size = new Size(850, 35);
            PanelHistoricoFiltros.TabIndex = 4;
            PanelHistoricoFiltros.Text = "panel1";
            // 
            // LabelNivel
            // 
            LabelNivel.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelNivel.BackColor = Color.FromArgb(33, 33, 33);
            LabelNivel.ColorScheme = AntdUI.TAMode.Dark;
            LabelNivel.Dock = DockStyle.Right;
            LabelNivel.Location = new Point(390, 0);
            LabelNivel.Name = "LabelNivel";
            LabelNivel.Size = new Size(30, 35);
            LabelNivel.TabIndex = 5;
            LabelNivel.Text = "Nível:";
            // 
            // SelectNivel
            // 
            SelectNivel.BackColor = Color.FromArgb(66, 66, 66);
            SelectNivel.BorderColor = Color.FromArgb(20, 20, 20);
            SelectNivel.ColorScheme = AntdUI.TAMode.Dark;
            SelectNivel.Dock = DockStyle.Right;
            SelectNivel.List = true;
            SelectNivel.Location = new Point(420, 0);
            SelectNivel.Name = "SelectNivel";
            SelectNivel.Size = new Size(125, 35);
            SelectNivel.TabIndex = 4;
            // 
            // LabelTema
            // 
            LabelTema.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelTema.BackColor = Color.FromArgb(33, 33, 33);
            LabelTema.ColorScheme = AntdUI.TAMode.Dark;
            LabelTema.Dock = DockStyle.Right;
            LabelTema.Location = new Point(545, 0);
            LabelTema.Name = "LabelTema";
            LabelTema.Size = new Size(32, 35);
            LabelTema.TabIndex = 10;
            LabelTema.Text = "Tema:";
            // 
            // SelectTema
            // 
            SelectTema.BackColor = Color.FromArgb(66, 66, 66);
            SelectTema.BorderColor = Color.FromArgb(20, 20, 20);
            SelectTema.ColorScheme = AntdUI.TAMode.Dark;
            SelectTema.Dock = DockStyle.Right;
            SelectTema.List = true;
            SelectTema.Location = new Point(577, 0);
            SelectTema.Name = "SelectTema";
            SelectTema.Size = new Size(125, 35);
            SelectTema.TabIndex = 9;
            // 
            // InputEnunciado
            // 
            InputEnunciado.BackColor = Color.FromArgb(66, 66, 66);
            InputEnunciado.ColorScheme = AntdUI.TAMode.Dark;
            InputEnunciado.Dock = DockStyle.Left;
            InputEnunciado.Location = new Point(63, 0);
            InputEnunciado.Name = "InputEnunciado";
            InputEnunciado.Size = new Size(146, 35);
            InputEnunciado.TabIndex = 8;
            // 
            // ButtonBuscarData
            // 
            ButtonBuscarData.BorderWidth = 2F;
            ButtonBuscarData.ColorScheme = AntdUI.TAMode.Dark;
            ButtonBuscarData.Ghost = true;
            ButtonBuscarData.Location = new Point(208, 0);
            ButtonBuscarData.Margin = new Padding(6);
            ButtonBuscarData.Name = "ButtonBuscarData";
            ButtonBuscarData.Radius = 2;
            ButtonBuscarData.Size = new Size(75, 35);
            ButtonBuscarData.TabIndex = 7;
            ButtonBuscarData.Text = "Buscar";
            // 
            // LabelTipoQuiz
            // 
            LabelTipoQuiz.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelTipoQuiz.BackColor = Color.FromArgb(33, 33, 33);
            LabelTipoQuiz.ColorScheme = AntdUI.TAMode.Dark;
            LabelTipoQuiz.Dock = DockStyle.Right;
            LabelTipoQuiz.Location = new Point(702, 0);
            LabelTipoQuiz.Name = "LabelTipoQuiz";
            LabelTipoQuiz.Size = new Size(26, 35);
            LabelTipoQuiz.TabIndex = 3;
            LabelTipoQuiz.Text = "Tipo:";
            // 
            // SelectQuizTipo
            // 
            SelectQuizTipo.BackColor = Color.FromArgb(66, 66, 66);
            SelectQuizTipo.BorderColor = Color.FromArgb(20, 20, 20);
            SelectQuizTipo.ColorScheme = AntdUI.TAMode.Dark;
            SelectQuizTipo.Dock = DockStyle.Right;
            SelectQuizTipo.List = true;
            SelectQuizTipo.Location = new Point(728, 0);
            SelectQuizTipo.Name = "SelectQuizTipo";
            SelectQuizTipo.Size = new Size(117, 35);
            SelectQuizTipo.TabIndex = 0;
            // 
            // LabelData
            // 
            LabelData.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelData.BackColor = Color.FromArgb(33, 33, 33);
            LabelData.ColorScheme = AntdUI.TAMode.Dark;
            LabelData.Dock = DockStyle.Left;
            LabelData.Location = new Point(5, 0);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(58, 35);
            LabelData.TabIndex = 6;
            LabelData.Text = "Enunciado:";
            // 
            // PaginaGerenciarQuestoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelHistorico);
            Name = "PaginaGerenciarQuestoes";
            Size = new Size(1280, 720);
            Load += PaginaGerenciarQuestoes_Load;
            PanelHistorico.ResumeLayout(false);
            PanelInserirHistorico.ResumeLayout(false);
            PanelHistoricoFiltros.ResumeLayout(false);
            PanelHistoricoFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelHistorico;
        private AntdUI.Panel PanelInserirHistorico;
        private AntdUI.Table TableHistorico;
        private AntdUI.Panel PanelHistoricoFiltros;
        private AntdUI.Label LabelNivel;
        private AntdUI.Select SelectNivel;
        private AntdUI.Label LabelTipoQuiz;
        private AntdUI.Select SelectQuizTipo;
        private AntdUI.Label LabelData;
        private AntdUI.Input InputEnunciado;
        private AntdUI.Button ButtonBuscarData;
        private AntdUI.Label LabelTema;
        private AntdUI.Select SelectTema;
    }
}
