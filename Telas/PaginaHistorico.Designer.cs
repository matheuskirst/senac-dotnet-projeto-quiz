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
            CheckboxQuizFinalizado = new AntdUI.Checkbox();
            DatePickerRangeQuiz = new AntdUI.DatePickerRange();
            SelectQuizTipo = new AntdUI.Select();
            LabelTitulo = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
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
            PanelHistoricoFiltros.Controls.Add(CheckboxQuizFinalizado);
            PanelHistoricoFiltros.Controls.Add(DatePickerRangeQuiz);
            PanelHistoricoFiltros.Controls.Add(SelectQuizTipo);
            PanelHistoricoFiltros.Dock = DockStyle.Top;
            PanelHistoricoFiltros.Location = new Point(0, 0);
            PanelHistoricoFiltros.Name = "PanelHistoricoFiltros";
            PanelHistoricoFiltros.Radius = 0;
            PanelHistoricoFiltros.Size = new Size(850, 35);
            PanelHistoricoFiltros.TabIndex = 4;
            PanelHistoricoFiltros.Text = "panel1";
            // 
            // CheckboxQuizFinalizado
            // 
            CheckboxQuizFinalizado.AutoSizeMode = AntdUI.TAutoSize.Width;
            CheckboxQuizFinalizado.BackColor = Color.Transparent;
            CheckboxQuizFinalizado.ColorScheme = AntdUI.TAMode.Dark;
            CheckboxQuizFinalizado.Dock = DockStyle.Left;
            CheckboxQuizFinalizado.Location = new Point(204, 0);
            CheckboxQuizFinalizado.Name = "CheckboxQuizFinalizado";
            CheckboxQuizFinalizado.Size = new Size(86, 35);
            CheckboxQuizFinalizado.TabIndex = 2;
            CheckboxQuizFinalizado.Text = "Finalizado";
            // 
            // DatePickerRangeQuiz
            // 
            DatePickerRangeQuiz.BackColor = Color.FromArgb(66, 66, 66);
            DatePickerRangeQuiz.BorderColor = Color.FromArgb(20, 20, 20);
            DatePickerRangeQuiz.ColorScheme = AntdUI.TAMode.Dark;
            DatePickerRangeQuiz.Dock = DockStyle.Left;
            DatePickerRangeQuiz.Location = new Point(0, 0);
            DatePickerRangeQuiz.Name = "DatePickerRangeQuiz";
            DatePickerRangeQuiz.Size = new Size(204, 35);
            DatePickerRangeQuiz.TabIndex = 1;
            // 
            // SelectQuizTipo
            // 
            SelectQuizTipo.BackColor = Color.FromArgb(66, 66, 66);
            SelectQuizTipo.BorderColor = Color.FromArgb(20, 20, 20);
            SelectQuizTipo.ColorScheme = AntdUI.TAMode.Dark;
            SelectQuizTipo.Dock = DockStyle.Right;
            SelectQuizTipo.List = true;
            SelectQuizTipo.Location = new Point(733, 0);
            SelectQuizTipo.Name = "SelectQuizTipo";
            SelectQuizTipo.Size = new Size(117, 35);
            SelectQuizTipo.TabIndex = 0;
            SelectQuizTipo.Text = "Tipo";
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
        private AntdUI.Checkbox CheckboxQuizFinalizado;
        private AntdUI.DatePickerRange DatePickerRangeQuiz;
        private AntdUI.Panel PanelInserirHistorico;
        private AntdUI.Divider divider1;
        private AntdUI.Table TableHistorico;
    }
}
