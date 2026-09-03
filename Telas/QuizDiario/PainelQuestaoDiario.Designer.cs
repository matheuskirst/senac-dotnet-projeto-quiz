namespace SenacQuizApp.Telas.QuizDiario
{
    partial class PainelQuestaoDiario
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
            ButtonConfirmar = new AntdUI.Button();
            GridPanelAlternativas = new AntdUI.GridPanel();
            LabelEnunciado = new AntdUI.Label();
            PanelEnunciado = new AntdUI.Panel();
            PanelEnunciado.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Anchor = AnchorStyles.Top;
            ButtonConfirmar.BorderWidth = 2F;
            ButtonConfirmar.ColorScheme = AntdUI.TAMode.Dark;
            ButtonConfirmar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConfirmar.Ghost = true;
            ButtonConfirmar.Location = new Point(375, 619);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(250, 75);
            ButtonConfirmar.TabIndex = 5;
            ButtonConfirmar.Text = "Confirmar";
            ButtonConfirmar.Click += ButtonConfirmar_Click;
            // 
            // GridPanelAlternativas
            // 
            GridPanelAlternativas.Anchor = AnchorStyles.Top;
            GridPanelAlternativas.ColorScheme = AntdUI.TAMode.Dark;
            GridPanelAlternativas.Location = new Point(100, 240);
            GridPanelAlternativas.Name = "GridPanelAlternativas";
            GridPanelAlternativas.Size = new Size(800, 300);
            GridPanelAlternativas.TabIndex = 6;
            GridPanelAlternativas.Text = "gridPanel1";
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
            // PanelEnunciado
            // 
            PanelEnunciado.Anchor = AnchorStyles.Top;
            PanelEnunciado.Back = Color.FromArgb(66, 66, 66);
            PanelEnunciado.Controls.Add(LabelEnunciado);
            PanelEnunciado.Location = new Point(50, 25);
            PanelEnunciado.Name = "PanelEnunciado";
            PanelEnunciado.Padding = new Padding(10);
            PanelEnunciado.Size = new Size(900, 175);
            PanelEnunciado.TabIndex = 8;
            PanelEnunciado.Text = "panel1";
            // 
            // PainelQuestaoDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelEnunciado);
            Controls.Add(GridPanelAlternativas);
            Controls.Add(ButtonConfirmar);
            Name = "PainelQuestaoDiario";
            Size = new Size(1000, 700);
            PanelEnunciado.ResumeLayout(false);
            PanelEnunciado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Button ButtonConfirmar;
        private AntdUI.GridPanel GridPanelAlternativas;
        private AntdUI.Label LabelEnunciado;
        private AntdUI.Panel PanelEnunciado;
    }
}
