namespace SenacQuizApp.Telas
{
    partial class PaginaHistorico
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelHistorico = new AntdUI.Panel();
            PanelInserirHistorico = new AntdUI.Panel();
            TableHistorico = new AntdUI.Table();
            PanelHistoricoFiltros = new AntdUI.Panel();
            LabelStatus = new AntdUI.Label();
            SelectStatus = new AntdUI.Select();
            LabelTipoQuiz = new AntdUI.Label();
            SelectQuizTipo = new AntdUI.Select();
            DatePickerRangeQuiz = new AntdUI.DatePickerRange();
            LabelData = new AntdUI.Label();
            LabelTitulo = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            ButtonBuscarData = new AntdUI.Button();
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
            PanelHistorico.Location = new Point(215, 90);
            PanelHistorico.Name = "PanelHistorico";
            PanelHistorico.Size = new Size(850, 620);
            PanelHistorico.TabIndex = 2;
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
            TableHistorico.EmptyText = "Nenhum quiz encontrado";
            TableHistorico.EnableHeaderResizing = true;
            TableHistorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableHistorico.Gap = 12;
            TableHistorico.Location = new Point(0, 0);
            TableHistorico.Name = "TableHistorico";
            TableHistorico.Size = new Size(850, 585);
            TableHistorico.TabIndex = 0;
            TableHistorico.CellClick += TableHistorico_CellClick;
            // 
            // PanelHistoricoFiltros
            // 
            PanelHistoricoFiltros.Back = Color.FromArgb(33, 33, 33);
            PanelHistoricoFiltros.ColorScheme = AntdUI.TAMode.Dark;
            PanelHistoricoFiltros.Controls.Add(ButtonBuscarData);
            PanelHistoricoFiltros.Controls.Add(LabelStatus);
            PanelHistoricoFiltros.Controls.Add(SelectStatus);
            PanelHistoricoFiltros.Controls.Add(LabelTipoQuiz);
            PanelHistoricoFiltros.Controls.Add(SelectQuizTipo);
            PanelHistoricoFiltros.Controls.Add(DatePickerRangeQuiz);
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
            // LabelStatus
            // 
            LabelStatus.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelStatus.BackColor = Color.FromArgb(33, 33, 33);
            LabelStatus.ColorScheme = AntdUI.TAMode.Dark;
            LabelStatus.Dock = DockStyle.Right;
            LabelStatus.Location = new Point(541, 0);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(36, 35);
            LabelStatus.TabIndex = 5;
            LabelStatus.Text = "Status:";
            // 
            // SelectStatus
            // 
            SelectStatus.BackColor = Color.FromArgb(66, 66, 66);
            SelectStatus.BorderColor = Color.FromArgb(20, 20, 20);
            SelectStatus.ColorScheme = AntdUI.TAMode.Dark;
            SelectStatus.Dock = DockStyle.Right;
            SelectStatus.List = true;
            SelectStatus.Location = new Point(577, 0);
            SelectStatus.Name = "SelectStatus";
            SelectStatus.Size = new Size(125, 35);
            SelectStatus.TabIndex = 4;
            SelectStatus.SelectedValueChanged += SelectStatus_SelectedValueChanged;
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
            SelectQuizTipo.SelectedValueChanged += SelectQuizTipo_SelectedValueChanged;
            // 
            // DatePickerRangeQuiz
            // 
            DatePickerRangeQuiz.BackColor = Color.FromArgb(66, 66, 66);
            DatePickerRangeQuiz.BorderColor = Color.FromArgb(20, 20, 20);
            DatePickerRangeQuiz.ColorScheme = AntdUI.TAMode.Dark;
            DatePickerRangeQuiz.Dock = DockStyle.Left;
            DatePickerRangeQuiz.Location = new Point(78, 0);
            DatePickerRangeQuiz.Name = "DatePickerRangeQuiz";
            DatePickerRangeQuiz.Size = new Size(204, 35);
            DatePickerRangeQuiz.TabIndex = 1;
            // 
            // LabelData
            // 
            LabelData.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelData.BackColor = Color.FromArgb(33, 33, 33);
            LabelData.ColorScheme = AntdUI.TAMode.Dark;
            LabelData.Dock = DockStyle.Left;
            LabelData.Location = new Point(5, 0);
            LabelData.Name = "LabelData";
            LabelData.Size = new Size(73, 35);
            LabelData.TabIndex = 6;
            LabelData.Text = "Data Iniciado:";
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = Color.Transparent;
            LabelTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTitulo.Dock = DockStyle.Top;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(0, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(1280, 64);
            LabelTitulo.TabIndex = 3;
            LabelTitulo.Text = "Histórico";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.ColorScheme = AntdUI.TAMode.Dark;
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(0, 64);
            divider1.Name = "divider1";
            divider1.OrientationMargin = 0F;
            divider1.Size = new Size(1280, 18);
            divider1.TabIndex = 4;
            divider1.Text = "";
            divider1.TextPadding = 0F;
            divider1.Thickness = 5F;
            // 
            // ButtonBuscarData
            // 
            ButtonBuscarData.BorderWidth = 2F;
            ButtonBuscarData.ColorScheme = AntdUI.TAMode.Dark;
            ButtonBuscarData.Dock = DockStyle.Left;
            ButtonBuscarData.Ghost = true;
            ButtonBuscarData.Location = new Point(282, 0);
            ButtonBuscarData.Margin = new Padding(6);
            ButtonBuscarData.Name = "ButtonBuscarData";
            ButtonBuscarData.Radius = 2;
            ButtonBuscarData.Size = new Size(75, 35);
            ButtonBuscarData.TabIndex = 7;
            ButtonBuscarData.Text = "Buscar";
            ButtonBuscarData.Click += ButtonBuscarData_Click;
            // 
            // PaginaHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(divider1);
            Controls.Add(LabelTitulo);
            Controls.Add(PanelHistorico);
            Name = "PaginaHistorico";
            Size = new Size(1280, 720);
            Load += PaginaHistorico_Load;
            PanelHistorico.ResumeLayout(false);
            PanelInserirHistorico.ResumeLayout(false);
            PanelHistoricoFiltros.ResumeLayout(false);
            PanelHistoricoFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelHistorico;
        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel PanelHistoricoFiltros;
        private AntdUI.Select SelectQuizTipo;
        private AntdUI.DatePickerRange DatePickerRangeQuiz;
        private AntdUI.Panel PanelInserirHistorico;
        private AntdUI.Divider divider1;
        private AntdUI.Table TableHistorico;
        private AntdUI.Label LabelTipoQuiz;
        private AntdUI.Label LabelStatus;
        private AntdUI.Select SelectStatus;
        private AntdUI.Label LabelData;
        private AntdUI.Button ButtonBuscarData;
    }
}
