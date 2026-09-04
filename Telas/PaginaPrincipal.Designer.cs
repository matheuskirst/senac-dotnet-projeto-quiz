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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            PanelQuizDiario = new AntdUI.Panel();
            ButtonQuizRush = new AntdUI.Button();
            ButtonQuizDiario = new AntdUI.Button();
            divider1 = new AntdUI.Divider();
            LabelQuizzesTitulo = new AntdUI.Label();
            divider2 = new AntdUI.Divider();
            PanelResumoQuizzes = new AntdUI.Panel();
            TableResumo = new AntdUI.Table();
            LabelResumoQuizzes = new AntdUI.Label();
            divider3 = new AntdUI.Divider();
            PanelQuizDiario.SuspendLayout();
            PanelResumoQuizzes.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuizDiario
            // 
            PanelQuizDiario.Back = Color.FromArgb(18, 18, 18);
            PanelQuizDiario.Controls.Add(ButtonQuizRush);
            PanelQuizDiario.Controls.Add(divider3);
            PanelQuizDiario.Controls.Add(ButtonQuizDiario);
            PanelQuizDiario.Controls.Add(divider2);
            PanelQuizDiario.Controls.Add(LabelQuizzesTitulo);
            PanelQuizDiario.Controls.Add(divider1);
            PanelQuizDiario.Dock = DockStyle.Right;
            PanelQuizDiario.Location = new Point(1030, 0);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Padding = new Padding(10);
            PanelQuizDiario.Radius = 0;
            PanelQuizDiario.Size = new Size(250, 720);
            PanelQuizDiario.TabIndex = 0;
            PanelQuizDiario.Text = "panel1";
            // 
            // ButtonQuizRush
            // 
            ButtonQuizRush.BorderWidth = 1F;
            ButtonQuizRush.ColorScheme = AntdUI.TAMode.Dark;
            ButtonQuizRush.Dock = DockStyle.Top;
            ButtonQuizRush.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizRush.Ghost = true;
            ButtonQuizRush.IconSvg = resources.GetString("ButtonQuizRush.IconSvg");
            ButtonQuizRush.Location = new Point(10, 222);
            ButtonQuizRush.Name = "ButtonQuizRush";
            ButtonQuizRush.Size = new Size(230, 58);
            ButtonQuizRush.TabIndex = 11;
            ButtonQuizRush.Text = "Rush";
            ButtonQuizRush.Click += ButtonQuizRush_Click;
            // 
            // ButtonQuizDiario
            // 
            ButtonQuizDiario.BorderWidth = 1F;
            ButtonQuizDiario.ColorScheme = AntdUI.TAMode.Dark;
            ButtonQuizDiario.Dock = DockStyle.Top;
            ButtonQuizDiario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizDiario.Ghost = true;
            ButtonQuizDiario.IconSvg = resources.GetString("ButtonQuizDiario.IconSvg");
            ButtonQuizDiario.Location = new Point(10, 134);
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
            divider1.Location = new Point(10, 10);
            divider1.Name = "divider1";
            divider1.OrientationMargin = 0F;
            divider1.Size = new Size(230, 50);
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
            LabelQuizzesTitulo.Location = new Point(10, 60);
            LabelQuizzesTitulo.Name = "LabelQuizzesTitulo";
            LabelQuizzesTitulo.Size = new Size(230, 44);
            LabelQuizzesTitulo.TabIndex = 9;
            LabelQuizzesTitulo.Text = "Modos";
            LabelQuizzesTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider2
            // 
            divider2.BackColor = Color.Transparent;
            divider2.ColorSplit = Color.Transparent;
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider2.Location = new Point(10, 104);
            divider2.Name = "divider2";
            divider2.OrientationMargin = 0F;
            divider2.Size = new Size(230, 30);
            divider2.TabIndex = 10;
            divider2.Text = "";
            divider2.TextPadding = 0F;
            divider2.Thickness = 1F;
            // 
            // PanelResumoQuizzes
            // 
            PanelResumoQuizzes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelResumoQuizzes.AutoScroll = true;
            PanelResumoQuizzes.Back = Color.FromArgb(33, 33, 33);
            PanelResumoQuizzes.ColorScheme = AntdUI.TAMode.Dark;
            PanelResumoQuizzes.Controls.Add(TableResumo);
            PanelResumoQuizzes.Controls.Add(LabelResumoQuizzes);
            PanelResumoQuizzes.Location = new Point(84, 3);
            PanelResumoQuizzes.Name = "PanelResumoQuizzes";
            PanelResumoQuizzes.Radius = 0;
            PanelResumoQuizzes.Size = new Size(850, 717);
            PanelResumoQuizzes.TabIndex = 1;
            PanelResumoQuizzes.Text = "panel2";
            // 
            // TableResumo
            // 
            TableResumo.AutoSizeColumnsMode = AntdUI.ColumnsMode.Fill;
            TableResumo.BackColor = Color.FromArgb(33, 33, 33);
            TableResumo.ColorScheme = AntdUI.TAMode.Dark;
            TableResumo.ColumnDragSort = true;
            TableResumo.Dock = DockStyle.Fill;
            TableResumo.EmptyText = "Nenhum quiz encontrado";
            TableResumo.EnableHeaderResizing = true;
            TableResumo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableResumo.Gap = 12;
            TableResumo.Location = new Point(0, 40);
            TableResumo.Name = "TableResumo";
            TableResumo.Size = new Size(850, 677);
            TableResumo.TabIndex = 1;
            TableResumo.CellClick += TableResumo_CellClick;
            // 
            // LabelResumoQuizzes
            // 
            LabelResumoQuizzes.BackColor = Color.Transparent;
            LabelResumoQuizzes.ColorScheme = AntdUI.TAMode.Dark;
            LabelResumoQuizzes.Dock = DockStyle.Top;
            LabelResumoQuizzes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelResumoQuizzes.Location = new Point(0, 0);
            LabelResumoQuizzes.Name = "LabelResumoQuizzes";
            LabelResumoQuizzes.Size = new Size(850, 40);
            LabelResumoQuizzes.TabIndex = 0;
            LabelResumoQuizzes.Text = "Últimas 10 Partidas Diárias";
            LabelResumoQuizzes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider3
            // 
            divider3.BackColor = Color.Transparent;
            divider3.ColorSplit = Color.SlateGray;
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider3.Location = new Point(10, 192);
            divider3.Name = "divider3";
            divider3.OrientationMargin = 0F;
            divider3.Size = new Size(230, 30);
            divider3.TabIndex = 12;
            divider3.Text = "";
            divider3.TextPadding = 0F;
            divider3.Thickness = 1F;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelResumoQuizzes);
            Controls.Add(PanelQuizDiario);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1280, 720);
            Load += PaginaPrincipal_Load;
            PanelQuizDiario.ResumeLayout(false);
            PanelResumoQuizzes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelQuizDiario;
        private AntdUI.Button ButtonQuizDiario;
        private AntdUI.Panel PanelResumoQuizzes;
        private AntdUI.Button ButtonQuizRush;
        private AntdUI.Divider divider1;
        private AntdUI.Label LabelQuizzesTitulo;
        private AntdUI.Divider divider2;
        private AntdUI.Label LabelResumoQuizzes;
        private AntdUI.Table TableResumo;
        private AntdUI.Divider divider3;
    }
}
