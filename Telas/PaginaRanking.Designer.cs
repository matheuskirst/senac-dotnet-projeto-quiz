namespace SenacQuizApp.Telas
{
    partial class PaginaRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaRanking));
            PanelRanking = new AntdUI.Panel();
            TableUsuariosRank = new AntdUI.Table();
            Header = new AntdUI.Panel();
            LabelQuizTipo = new AntdUI.Label();
            SelectRankTipo = new AntdUI.Select();
            ButtonBuscarUsuario = new AntdUI.Button();
            InputBuscarUsuario = new AntdUI.Input();
            LabelTitulo = new AntdUI.Label();
            PanelRanking.SuspendLayout();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // PanelRanking
            // 
            PanelRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelRanking.Back = Color.FromArgb(33, 33, 33);
            PanelRanking.BorderColor = Color.Black;
            PanelRanking.BorderWidth = 1F;
            PanelRanking.Controls.Add(TableUsuariosRank);
            PanelRanking.Controls.Add(Header);
            PanelRanking.Location = new Point(240, 76);
            PanelRanking.Name = "PanelRanking";
            PanelRanking.Radius = 0;
            PanelRanking.Size = new Size(800, 644);
            PanelRanking.TabIndex = 0;
            // 
            // TableUsuariosRank
            // 
            TableUsuariosRank.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableUsuariosRank.BackColor = Color.FromArgb(33, 33, 33);
            TableUsuariosRank.Bordered = true;
            TableUsuariosRank.ColorScheme = AntdUI.TAMode.Dark;
            TableUsuariosRank.ColumnDragSort = true;
            TableUsuariosRank.Dock = DockStyle.Fill;
            TableUsuariosRank.EmptyText = "Nenhum usuário encontrado";
            TableUsuariosRank.EnableHeaderResizing = true;
            TableUsuariosRank.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableUsuariosRank.Gap = 12;
            TableUsuariosRank.Location = new Point(1, 36);
            TableUsuariosRank.LostFocusClearSelection = true;
            TableUsuariosRank.Name = "TableUsuariosRank";
            TableUsuariosRank.Size = new Size(798, 607);
            TableUsuariosRank.TabIndex = 3;
            TableUsuariosRank.CellClick += TableUsuariosRank_CellClick;
            TableUsuariosRank.CellDoubleClick += TableUsuariosRank_CellDoubleClick;
            // 
            // Header
            // 
            Header.Back = Color.FromArgb(33, 33, 33);
            Header.Controls.Add(LabelQuizTipo);
            Header.Controls.Add(SelectRankTipo);
            Header.Controls.Add(ButtonBuscarUsuario);
            Header.Controls.Add(InputBuscarUsuario);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(1, 1);
            Header.Name = "Header";
            Header.Radius = 0;
            Header.Size = new Size(798, 35);
            Header.TabIndex = 4;
            Header.Text = "panel1";
            // 
            // LabelQuizTipo
            // 
            LabelQuizTipo.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelQuizTipo.BackColor = Color.FromArgb(33, 33, 33);
            LabelQuizTipo.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizTipo.Dock = DockStyle.Right;
            LabelQuizTipo.Location = new Point(671, 0);
            LabelQuizTipo.Name = "LabelQuizTipo";
            LabelQuizTipo.Size = new Size(27, 35);
            LabelQuizTipo.TabIndex = 10;
            LabelQuizTipo.Text = "Quiz:";
            // 
            // SelectRankTipo
            // 
            SelectRankTipo.BackColor = Color.FromArgb(66, 66, 66);
            SelectRankTipo.BorderColor = Color.FromArgb(20, 20, 20);
            SelectRankTipo.ColorScheme = AntdUI.TAMode.Dark;
            SelectRankTipo.Dock = DockStyle.Right;
            SelectRankTipo.List = true;
            SelectRankTipo.Location = new Point(698, 0);
            SelectRankTipo.Name = "SelectRankTipo";
            SelectRankTipo.Size = new Size(100, 35);
            SelectRankTipo.TabIndex = 9;
            SelectRankTipo.SelectedValueChanged += SelectRankTipo_SelectedValueChanged;
            // 
            // ButtonBuscarUsuario
            // 
            ButtonBuscarUsuario.BorderWidth = 2F;
            ButtonBuscarUsuario.ColorScheme = AntdUI.TAMode.Dark;
            ButtonBuscarUsuario.Dock = DockStyle.Left;
            ButtonBuscarUsuario.Ghost = true;
            ButtonBuscarUsuario.Location = new Point(200, 0);
            ButtonBuscarUsuario.Margin = new Padding(6);
            ButtonBuscarUsuario.Name = "ButtonBuscarUsuario";
            ButtonBuscarUsuario.Radius = 2;
            ButtonBuscarUsuario.Size = new Size(75, 35);
            ButtonBuscarUsuario.TabIndex = 8;
            ButtonBuscarUsuario.Text = "Buscar";
            ButtonBuscarUsuario.Click += ButtonBuscarUsuario_Click;
            // 
            // InputBuscarUsuario
            // 
            InputBuscarUsuario.BackColor = Color.FromArgb(66, 66, 66);
            InputBuscarUsuario.ColorScheme = AntdUI.TAMode.Dark;
            InputBuscarUsuario.Dock = DockStyle.Left;
            InputBuscarUsuario.Location = new Point(0, 0);
            InputBuscarUsuario.Name = "InputBuscarUsuario";
            InputBuscarUsuario.PlaceholderText = "Buscar...";
            InputBuscarUsuario.PrefixFore = Color.White;
            InputBuscarUsuario.PrefixSvg = resources.GetString("InputBuscarUsuario.PrefixSvg");
            InputBuscarUsuario.Size = new Size(200, 35);
            InputBuscarUsuario.SuffixSvg = resources.GetString("InputBuscarUsuario.SuffixSvg");
            InputBuscarUsuario.TabIndex = 0;
            InputBuscarUsuario.SuffixClick += InputBuscarUsuario_SuffixClick;
            InputBuscarUsuario.KeyDown += InputBuscarUsuario_KeyDown;
            // 
            // LabelTitulo
            // 
            LabelTitulo.Anchor = AnchorStyles.Top;
            LabelTitulo.BackColor = Color.FromArgb(33, 33, 33);
            LabelTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(240, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(800, 70);
            LabelTitulo.TabIndex = 1;
            LabelTitulo.Text = "Ranking";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaRanking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(LabelTitulo);
            Controls.Add(PanelRanking);
            Name = "PaginaRanking";
            Size = new Size(1280, 720);
            Load += PaginaRanking_Load;
            PanelRanking.ResumeLayout(false);
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelRanking;
        private AntdUI.Table TableUsuariosRank;
        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel Header;
        private AntdUI.Input InputBuscarUsuario;
        private AntdUI.Button ButtonBuscarUsuario;
        private AntdUI.Label LabelQuizTipo;
        private AntdUI.Select SelectRankTipo;
    }
}
