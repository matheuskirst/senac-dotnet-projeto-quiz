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
            PanelHistoricoFiltros = new AntdUI.Panel();
            checkbox1 = new AntdUI.Checkbox();
            DatePickerRangeQuiz = new AntdUI.DatePickerRange();
            SelectQuizTipo = new AntdUI.Select();
            LabelTitulo = new AntdUI.Label();
            PanelInserirHistorico = new AntdUI.Panel();
            PanelHistorico.SuspendLayout();
            PanelHistoricoFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHistorico
            // 
            PanelHistorico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelHistorico.AutoScroll = true;
            PanelHistorico.Back = Color.FromArgb(50, 45, 45);
            PanelHistorico.Controls.Add(PanelInserirHistorico);
            PanelHistorico.Controls.Add(PanelHistoricoFiltros);
            PanelHistorico.Location = new Point(240, 90);
            PanelHistorico.Name = "PanelHistorico";
            PanelHistorico.Size = new Size(800, 620);
            PanelHistorico.TabIndex = 2;
            PanelHistorico.Text = "panel2";
            // 
            // PanelHistoricoFiltros
            // 
            PanelHistoricoFiltros.Back = Color.FromArgb(50, 45, 45);
            PanelHistoricoFiltros.ColorScheme = AntdUI.TAMode.Dark;
            PanelHistoricoFiltros.Controls.Add(checkbox1);
            PanelHistoricoFiltros.Controls.Add(DatePickerRangeQuiz);
            PanelHistoricoFiltros.Controls.Add(SelectQuizTipo);
            PanelHistoricoFiltros.Dock = DockStyle.Top;
            PanelHistoricoFiltros.Location = new Point(0, 0);
            PanelHistoricoFiltros.Name = "PanelHistoricoFiltros";
            PanelHistoricoFiltros.Radius = 0;
            PanelHistoricoFiltros.Size = new Size(800, 49);
            PanelHistoricoFiltros.TabIndex = 4;
            PanelHistoricoFiltros.Text = "panel1";
            // 
            // checkbox1
            // 
            checkbox1.AutoSizeMode = AntdUI.TAutoSize.Width;
            checkbox1.BackColor = Color.Transparent;
            checkbox1.ColorScheme = AntdUI.TAMode.Dark;
            checkbox1.Location = new Point(266, 6);
            checkbox1.Name = "checkbox1";
            checkbox1.Size = new Size(86, 37);
            checkbox1.TabIndex = 2;
            checkbox1.Text = "Finalizado";
            // 
            // DatePickerRangeQuiz
            // 
            DatePickerRangeQuiz.BackColor = Color.FromArgb(77, 84, 92);
            DatePickerRangeQuiz.BorderColor = Color.FromArgb(61, 61, 61);
            DatePickerRangeQuiz.ColorScheme = AntdUI.TAMode.Dark;
            DatePickerRangeQuiz.Location = new Point(3, 6);
            DatePickerRangeQuiz.Name = "DatePickerRangeQuiz";
            DatePickerRangeQuiz.Size = new Size(257, 37);
            DatePickerRangeQuiz.TabIndex = 1;
            // 
            // SelectQuizTipo
            // 
            SelectQuizTipo.Anchor = AnchorStyles.Right;
            SelectQuizTipo.BackColor = Color.FromArgb(77, 84, 92);
            SelectQuizTipo.BorderColor = Color.FromArgb(61, 61, 61);
            SelectQuizTipo.ColorScheme = AntdUI.TAMode.Dark;
            SelectQuizTipo.List = true;
            SelectQuizTipo.Location = new Point(680, 6);
            SelectQuizTipo.Name = "SelectQuizTipo";
            SelectQuizTipo.Size = new Size(117, 37);
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
            LabelTitulo.Size = new Size(1280, 85);
            LabelTitulo.TabIndex = 3;
            LabelTitulo.Text = "Histórico";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelInserirHistorico
            // 
            PanelInserirHistorico.Back = Color.FromArgb(50, 45, 45);
            PanelInserirHistorico.Dock = DockStyle.Fill;
            PanelInserirHistorico.Location = new Point(0, 49);
            PanelInserirHistorico.Name = "PanelInserirHistorico";
            PanelInserirHistorico.Radius = 0;
            PanelInserirHistorico.Size = new Size(800, 571);
            PanelInserirHistorico.TabIndex = 5;
            PanelInserirHistorico.Text = "panel1";
            // 
            // PaginaHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 64, 70);
            Controls.Add(LabelTitulo);
            Controls.Add(PanelHistorico);
            Name = "PaginaHistorico";
            Size = new Size(1280, 720);
            Load += PaginaHistorico_Load;
            PanelHistorico.ResumeLayout(false);
            PanelHistoricoFiltros.ResumeLayout(false);
            PanelHistoricoFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelHistorico;
        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel PanelHistoricoFiltros;
        private AntdUI.Select SelectQuizTipo;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.DatePickerRange DatePickerRangeQuiz;
        private AntdUI.Panel PanelInserirHistorico;
    }
}
