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
            TableQuestoes = new AntdUI.Table();
            PanelHistoricoFiltros = new AntdUI.Panel();
            LabelTipo = new AntdUI.Label();
            SelectTipo = new AntdUI.Select();
            LabelNivel = new AntdUI.Label();
            SelectNivel = new AntdUI.Select();
            LabelTema = new AntdUI.Label();
            SelectTema = new AntdUI.Select();
            InputEnunciado = new AntdUI.Input();
            ButtonBuscarData = new AntdUI.Button();
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
            PanelInserirHistorico.Controls.Add(TableQuestoes);
            PanelInserirHistorico.Dock = DockStyle.Fill;
            PanelInserirHistorico.Location = new Point(0, 35);
            PanelInserirHistorico.Name = "PanelInserirHistorico";
            PanelInserirHistorico.Radius = 0;
            PanelInserirHistorico.Size = new Size(850, 585);
            PanelInserirHistorico.TabIndex = 5;
            PanelInserirHistorico.Text = "panel1";
            // 
            // TableQuestoes
            // 
            TableQuestoes.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableQuestoes.BackColor = Color.FromArgb(33, 33, 33);
            TableQuestoes.ColorScheme = AntdUI.TAMode.Dark;
            TableQuestoes.ColumnDragSort = true;
            TableQuestoes.Dock = DockStyle.Fill;
            TableQuestoes.EmptyText = "Nenhuma pergunta encontrada";
            TableQuestoes.EnableHeaderResizing = true;
            TableQuestoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableQuestoes.Gap = 12;
            TableQuestoes.Location = new Point(0, 0);
            TableQuestoes.Name = "TableQuestoes";
            TableQuestoes.Size = new Size(850, 585);
            TableQuestoes.TabIndex = 0;
            // 
            // PanelHistoricoFiltros
            // 
            PanelHistoricoFiltros.Back = Color.FromArgb(33, 33, 33);
            PanelHistoricoFiltros.ColorScheme = AntdUI.TAMode.Dark;
            PanelHistoricoFiltros.Controls.Add(LabelTipo);
            PanelHistoricoFiltros.Controls.Add(SelectTipo);
            PanelHistoricoFiltros.Controls.Add(LabelNivel);
            PanelHistoricoFiltros.Controls.Add(SelectNivel);
            PanelHistoricoFiltros.Controls.Add(LabelTema);
            PanelHistoricoFiltros.Controls.Add(SelectTema);
            PanelHistoricoFiltros.Controls.Add(InputEnunciado);
            PanelHistoricoFiltros.Controls.Add(ButtonBuscarData);
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
            // LabelTipo
            // 
            LabelTipo.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelTipo.BackColor = Color.FromArgb(33, 33, 33);
            LabelTipo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTipo.Dock = DockStyle.Right;
            LabelTipo.Location = new Point(390, 0);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(26, 35);
            LabelTipo.TabIndex = 3;
            LabelTipo.Text = "Tipo:";
            // 
            // SelectTipo
            // 
            SelectTipo.BackColor = Color.FromArgb(66, 66, 66);
            SelectTipo.BorderColor = Color.FromArgb(20, 20, 20);
            SelectTipo.ColorScheme = AntdUI.TAMode.Dark;
            SelectTipo.Dock = DockStyle.Right;
            SelectTipo.List = true;
            SelectTipo.Location = new Point(416, 0);
            SelectTipo.Name = "SelectTipo";
            SelectTipo.Size = new Size(117, 35);
            SelectTipo.TabIndex = 0;
            // 
            // LabelNivel
            // 
            LabelNivel.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelNivel.BackColor = Color.FromArgb(33, 33, 33);
            LabelNivel.ColorScheme = AntdUI.TAMode.Dark;
            LabelNivel.Dock = DockStyle.Right;
            LabelNivel.Location = new Point(533, 0);
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
            SelectNivel.Location = new Point(563, 0);
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
            LabelTema.Location = new Point(688, 0);
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
            SelectTema.Location = new Point(720, 0);
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
        private AntdUI.Table TableQuestoes;
        private AntdUI.Panel PanelHistoricoFiltros;
        private AntdUI.Label LabelNivel;
        private AntdUI.Select SelectNivel;
        private AntdUI.Label LabelTipo;
        private AntdUI.Select SelectTipo;
        private AntdUI.Label LabelData;
        private AntdUI.Input InputEnunciado;
        private AntdUI.Button ButtonBuscarData;
        private AntdUI.Label LabelTema;
        private AntdUI.Select SelectTema;
    }
}
