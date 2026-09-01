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
            panel1 = new AntdUI.Panel();
            ButtonBuscarUsuario = new AntdUI.Button();
            InputBuscarUsuario = new AntdUI.Input();
            LabelTitulo = new AntdUI.Label();
            PanelRanking.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelRanking
            // 
            PanelRanking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelRanking.Back = Color.FromArgb(33, 33, 33);
            PanelRanking.BorderColor = Color.Black;
            PanelRanking.BorderWidth = 1F;
            PanelRanking.Controls.Add(TableUsuariosRank);
            PanelRanking.Controls.Add(panel1);
            PanelRanking.Location = new Point(240, 90);
            PanelRanking.Name = "PanelRanking";
            PanelRanking.Radius = 0;
            PanelRanking.Size = new Size(800, 620);
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
            TableUsuariosRank.Size = new Size(798, 583);
            TableUsuariosRank.TabIndex = 3;
            TableUsuariosRank.CellClick += TableUsuariosRank_CellClick;
            TableUsuariosRank.CellDoubleClick += TableUsuariosRank_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Back = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(ButtonBuscarUsuario);
            panel1.Controls.Add(InputBuscarUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Radius = 0;
            panel1.Size = new Size(798, 35);
            panel1.TabIndex = 4;
            panel1.Text = "panel1";
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
            LabelTitulo.BackColor = Color.Transparent;
            LabelTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTitulo.Dock = DockStyle.Top;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(0, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(1280, 85);
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
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelRanking;
        private AntdUI.Table TableUsuariosRank;
        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel panel1;
        private AntdUI.Input InputBuscarUsuario;
        private AntdUI.Button ButtonBuscarUsuario;
    }
}
