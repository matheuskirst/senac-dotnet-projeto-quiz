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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaGerenciarQuestoes));
            PanelQuestoes = new AntdUI.Panel();
            PanelInserirQuestoes = new AntdUI.Panel();
            TableQuestoes = new AntdUI.Table();
            PanelQuestoesHeader = new AntdUI.Panel();
            LabelTipo = new AntdUI.Label();
            SelectTipo = new AntdUI.Select();
            LabelNivel = new AntdUI.Label();
            SelectNivel = new AntdUI.Select();
            LabelTema = new AntdUI.Label();
            SelectTema = new AntdUI.Select();
            ButtonNovaQuestao = new AntdUI.Button();
            ButtonBuscarData = new AntdUI.Button();
            InputEnunciado = new AntdUI.Input();
            LabelData = new AntdUI.Label();
            LabelTitulo = new AntdUI.Label();
            PanelQuestoes.SuspendLayout();
            PanelInserirQuestoes.SuspendLayout();
            PanelQuestoesHeader.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuestoes
            // 
            PanelQuestoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelQuestoes.AutoScroll = true;
            PanelQuestoes.Back = Color.FromArgb(33, 33, 33);
            PanelQuestoes.Controls.Add(PanelInserirQuestoes);
            PanelQuestoes.Controls.Add(PanelQuestoesHeader);
            PanelQuestoes.Location = new Point(115, 66);
            PanelQuestoes.Name = "PanelQuestoes";
            PanelQuestoes.Size = new Size(1050, 654);
            PanelQuestoes.TabIndex = 3;
            PanelQuestoes.Text = "panel2";
            // 
            // PanelInserirQuestoes
            // 
            PanelInserirQuestoes.Back = Color.FromArgb(33, 33, 33);
            PanelInserirQuestoes.Controls.Add(TableQuestoes);
            PanelInserirQuestoes.Dock = DockStyle.Fill;
            PanelInserirQuestoes.Location = new Point(0, 40);
            PanelInserirQuestoes.Name = "PanelInserirQuestoes";
            PanelInserirQuestoes.Radius = 0;
            PanelInserirQuestoes.Size = new Size(1050, 614);
            PanelInserirQuestoes.TabIndex = 5;
            PanelInserirQuestoes.Text = "panel1";
            // 
            // TableQuestoes
            // 
            TableQuestoes.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableQuestoes.BackColor = Color.FromArgb(33, 33, 33);
            TableQuestoes.BorderColor = Color.Black;
            TableQuestoes.Bordered = true;
            TableQuestoes.BorderRenderMode = AntdUI.TableBorderMode.High;
            TableQuestoes.ColorScheme = AntdUI.TAMode.Dark;
            TableQuestoes.ColumnDragSort = true;
            TableQuestoes.Dock = DockStyle.Fill;
            TableQuestoes.EmptyText = "Nenhuma pergunta encontrada";
            TableQuestoes.EnableHeaderResizing = true;
            TableQuestoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableQuestoes.Gap = 12;
            TableQuestoes.Location = new Point(0, 0);
            TableQuestoes.LostFocusClearSelection = true;
            TableQuestoes.MultipleRows = true;
            TableQuestoes.Name = "TableQuestoes";
            TableQuestoes.Size = new Size(1050, 614);
            TableQuestoes.TabIndex = 0;
            // 
            // PanelQuestoesHeader
            // 
            PanelQuestoesHeader.Back = Color.FromArgb(33, 33, 33);
            PanelQuestoesHeader.ColorScheme = AntdUI.TAMode.Dark;
            PanelQuestoesHeader.Controls.Add(LabelTipo);
            PanelQuestoesHeader.Controls.Add(SelectTipo);
            PanelQuestoesHeader.Controls.Add(LabelNivel);
            PanelQuestoesHeader.Controls.Add(SelectNivel);
            PanelQuestoesHeader.Controls.Add(LabelTema);
            PanelQuestoesHeader.Controls.Add(SelectTema);
            PanelQuestoesHeader.Controls.Add(ButtonNovaQuestao);
            PanelQuestoesHeader.Controls.Add(ButtonBuscarData);
            PanelQuestoesHeader.Controls.Add(InputEnunciado);
            PanelQuestoesHeader.Controls.Add(LabelData);
            PanelQuestoesHeader.Dock = DockStyle.Top;
            PanelQuestoesHeader.Location = new Point(0, 0);
            PanelQuestoesHeader.Name = "PanelQuestoesHeader";
            PanelQuestoesHeader.Padding = new Padding(5, 0, 5, 0);
            PanelQuestoesHeader.Radius = 0;
            PanelQuestoesHeader.Size = new Size(1050, 40);
            PanelQuestoesHeader.TabIndex = 4;
            PanelQuestoesHeader.Text = "panel1";
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelTipo.BackColor = Color.FromArgb(33, 33, 33);
            LabelTipo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTipo.Dock = DockStyle.Right;
            LabelTipo.Font = new Font("Segoe UI", 11.25F);
            LabelTipo.Location = new Point(470, 0);
            LabelTipo.Name = "LabelTipo";
            LabelTipo.Size = new Size(33, 40);
            LabelTipo.TabIndex = 3;
            LabelTipo.Text = "Tipo:";
            // 
            // SelectTipo
            // 
            SelectTipo.BackColor = Color.FromArgb(66, 66, 66);
            SelectTipo.BorderColor = Color.FromArgb(20, 20, 20);
            SelectTipo.ColorScheme = AntdUI.TAMode.Dark;
            SelectTipo.Dock = DockStyle.Right;
            SelectTipo.Font = new Font("Segoe UI", 11.25F);
            SelectTipo.List = true;
            SelectTipo.ListAutoWidth = true;
            SelectTipo.Location = new Point(503, 0);
            SelectTipo.MinimumSize = new Size(125, 0);
            SelectTipo.Name = "SelectTipo";
            SelectTipo.Size = new Size(125, 40);
            SelectTipo.TabIndex = 0;
            SelectTipo.SelectedValueChanged += SelectTipo_SelectedValueChanged;
            // 
            // LabelNivel
            // 
            LabelNivel.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelNivel.BackColor = Color.FromArgb(33, 33, 33);
            LabelNivel.ColorScheme = AntdUI.TAMode.Dark;
            LabelNivel.Dock = DockStyle.Right;
            LabelNivel.Font = new Font("Segoe UI", 11.25F);
            LabelNivel.Location = new Point(628, 0);
            LabelNivel.Name = "LabelNivel";
            LabelNivel.Size = new Size(37, 40);
            LabelNivel.TabIndex = 5;
            LabelNivel.Text = "Nível:";
            // 
            // SelectNivel
            // 
            SelectNivel.BackColor = Color.FromArgb(66, 66, 66);
            SelectNivel.BorderColor = Color.FromArgb(20, 20, 20);
            SelectNivel.ColorScheme = AntdUI.TAMode.Dark;
            SelectNivel.Dock = DockStyle.Right;
            SelectNivel.Font = new Font("Segoe UI", 11.25F);
            SelectNivel.List = true;
            SelectNivel.ListAutoWidth = true;
            SelectNivel.Location = new Point(665, 0);
            SelectNivel.MinimumSize = new Size(125, 0);
            SelectNivel.Name = "SelectNivel";
            SelectNivel.Size = new Size(125, 40);
            SelectNivel.TabIndex = 4;
            SelectNivel.SelectedValueChanged += SelectNivel_SelectedValueChanged;
            // 
            // LabelTema
            // 
            LabelTema.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelTema.BackColor = Color.FromArgb(33, 33, 33);
            LabelTema.ColorScheme = AntdUI.TAMode.Dark;
            LabelTema.Dock = DockStyle.Right;
            LabelTema.Font = new Font("Segoe UI", 11.25F);
            LabelTema.Location = new Point(790, 0);
            LabelTema.Name = "LabelTema";
            LabelTema.Size = new Size(40, 40);
            LabelTema.TabIndex = 10;
            LabelTema.Text = "Tema:";
            // 
            // SelectTema
            // 
            SelectTema.BackColor = Color.FromArgb(66, 66, 66);
            SelectTema.BorderColor = Color.FromArgb(20, 20, 20);
            SelectTema.ColorScheme = AntdUI.TAMode.Dark;
            SelectTema.Dock = DockStyle.Right;
            SelectTema.Font = new Font("Segoe UI", 11.25F);
            SelectTema.List = true;
            SelectTema.ListAutoWidth = true;
            SelectTema.Location = new Point(830, 0);
            SelectTema.MinimumSize = new Size(125, 0);
            SelectTema.Name = "SelectTema";
            SelectTema.Size = new Size(125, 40);
            SelectTema.TabIndex = 9;
            SelectTema.SelectedValueChanged += SelectTema_SelectedValueChanged;
            // 
            // ButtonNovaQuestao
            // 
            ButtonNovaQuestao.BorderWidth = 2F;
            ButtonNovaQuestao.ColorScheme = AntdUI.TAMode.Dark;
            ButtonNovaQuestao.Dock = DockStyle.Right;
            ButtonNovaQuestao.Font = new Font("Segoe UI", 11.25F);
            ButtonNovaQuestao.Ghost = true;
            ButtonNovaQuestao.IconSvg = resources.GetString("ButtonNovaQuestao.IconSvg");
            ButtonNovaQuestao.Location = new Point(955, 0);
            ButtonNovaQuestao.Margin = new Padding(6);
            ButtonNovaQuestao.Name = "ButtonNovaQuestao";
            ButtonNovaQuestao.Radius = 2;
            ButtonNovaQuestao.Size = new Size(90, 40);
            ButtonNovaQuestao.TabIndex = 11;
            ButtonNovaQuestao.Text = "Nova";
            ButtonNovaQuestao.Click += ButtonNovaQuestao_Click;
            // 
            // ButtonBuscarData
            // 
            ButtonBuscarData.BorderWidth = 2F;
            ButtonBuscarData.ColorScheme = AntdUI.TAMode.Dark;
            ButtonBuscarData.Dock = DockStyle.Left;
            ButtonBuscarData.Font = new Font("Segoe UI", 11.25F);
            ButtonBuscarData.Ghost = true;
            ButtonBuscarData.Location = new Point(317, 0);
            ButtonBuscarData.Margin = new Padding(6);
            ButtonBuscarData.Name = "ButtonBuscarData";
            ButtonBuscarData.Radius = 2;
            ButtonBuscarData.Size = new Size(93, 40);
            ButtonBuscarData.TabIndex = 7;
            ButtonBuscarData.Text = "Buscar";
            ButtonBuscarData.Click += ButtonBuscarData_Click;
            // 
            // InputEnunciado
            // 
            InputEnunciado.BackColor = Color.FromArgb(66, 66, 66);
            InputEnunciado.ColorScheme = AntdUI.TAMode.Dark;
            InputEnunciado.Dock = DockStyle.Left;
            InputEnunciado.Font = new Font("Segoe UI", 11.25F);
            InputEnunciado.Location = new Point(78, 0);
            InputEnunciado.Name = "InputEnunciado";
            InputEnunciado.Size = new Size(239, 40);
            InputEnunciado.TabIndex = 8;
            InputEnunciado.KeyDown += InputEnunciado_KeyDown;
            // 
            // LabelData
            // 
            LabelData.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelData.BackColor = Color.FromArgb(33, 33, 33);
            LabelData.ColorScheme = AntdUI.TAMode.Dark;
            LabelData.Dock = DockStyle.Left;
            LabelData.Font = new Font("Segoe UI", 11.25F);
            LabelData.Location = new Point(5, 0);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(73, 40);
            LabelData.TabIndex = 6;
            LabelData.Text = "Enunciado:";
            // 
            // LabelTitulo
            // 
            LabelTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelTitulo.BackColor = Color.FromArgb(33, 33, 33);
            LabelTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(115, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(1050, 60);
            LabelTitulo.TabIndex = 4;
            LabelTitulo.Text = "Questões";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaGerenciarQuestoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(LabelTitulo);
            Controls.Add(PanelQuestoes);
            Name = "PaginaGerenciarQuestoes";
            Size = new Size(1280, 720);
            Load += PaginaGerenciarQuestoes_Load;
            PanelQuestoes.ResumeLayout(false);
            PanelInserirQuestoes.ResumeLayout(false);
            PanelQuestoesHeader.ResumeLayout(false);
            PanelQuestoesHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelQuestoes;
        private AntdUI.Panel PanelInserirQuestoes;
        private AntdUI.Table TableQuestoes;
        private AntdUI.Panel PanelQuestoesHeader;
        private AntdUI.Label LabelNivel;
        private AntdUI.Select SelectNivel;
        private AntdUI.Label LabelTipo;
        private AntdUI.Select SelectTipo;
        private AntdUI.Label LabelData;
        private AntdUI.Input InputEnunciado;
        private AntdUI.Button ButtonBuscarData;
        private AntdUI.Label LabelTema;
        private AntdUI.Select SelectTema;
        private AntdUI.Label LabelTitulo;
        private AntdUI.Button ButtonNovaQuestao;
    }
}
