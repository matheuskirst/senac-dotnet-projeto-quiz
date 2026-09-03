namespace SenacQuizApp.Telas.QuizRush
{
    partial class PainelQuestaoRush
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
            GridPanelAlternativas = new AntdUI.GridPanel();
            PanelEnunciado = new AntdUI.Panel();
            LabelEnunciado = new AntdUI.Label();
            PanelEnunciado.SuspendLayout();
            SuspendLayout();
            // 
            // GridPanelAlternativas
            // 
            GridPanelAlternativas.Anchor = AnchorStyles.Top;
            GridPanelAlternativas.ColorScheme = AntdUI.TAMode.Dark;
            GridPanelAlternativas.Location = new Point(100, 240);
            GridPanelAlternativas.Name = "GridPanelAlternativas";
            GridPanelAlternativas.Size = new Size(800, 300);
            GridPanelAlternativas.TabIndex = 8;
            GridPanelAlternativas.Text = "gridPanel1";
            // 
            // PanelEnunciado
            // 
            PanelEnunciado.Anchor = AnchorStyles.Top;
            PanelEnunciado.Back = Color.FromArgb(66, 66, 66);
            PanelEnunciado.Controls.Add(LabelEnunciado);
            PanelEnunciado.Location = new Point(50, 25);
            PanelEnunciado.Name = "PanelEnunciado";
            PanelEnunciado.Padding = new Padding(10);
            PanelEnunciado.Size = new Size(900, 175);
            PanelEnunciado.TabIndex = 9;
            PanelEnunciado.Text = "panel1";
            // 
            // LabelEnunciado
            // 
            LabelEnunciado.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelEnunciado.BackColor = Color.Transparent;
            LabelEnunciado.ColorScheme = AntdUI.TAMode.Dark;
            LabelEnunciado.Dock = DockStyle.Fill;
            LabelEnunciado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEnunciado.Location = new Point(10, 10);
            LabelEnunciado.Name = "LabelEnunciado";
            LabelEnunciado.Size = new Size(880, 36);
            LabelEnunciado.TabIndex = 7;
            LabelEnunciado.Text = "Enunciado";
            LabelEnunciado.TextAlign = ContentAlignment.TopLeft;
            // 
            // PainelQuestaoRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelEnunciado);
            Controls.Add(GridPanelAlternativas);
            Name = "PainelQuestaoRush";
            Size = new Size(1000, 700);
            PanelEnunciado.ResumeLayout(false);
            PanelEnunciado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel GridPanelAlternativas;
        private AntdUI.Panel PanelEnunciado;
        private AntdUI.Label LabelEnunciado;
    }
}
