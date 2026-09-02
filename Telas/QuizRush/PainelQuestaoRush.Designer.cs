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
            InputQuestaoEnunciado = new AntdUI.Input();
            SuspendLayout();
            // 
            // GridPanelAlternativas
            // 
            GridPanelAlternativas.Anchor = AnchorStyles.Top;
            GridPanelAlternativas.ColorScheme = AntdUI.TAMode.Dark;
            GridPanelAlternativas.Location = new Point(100, 242);
            GridPanelAlternativas.Name = "GridPanelAlternativas";
            GridPanelAlternativas.Size = new Size(800, 300);
            GridPanelAlternativas.TabIndex = 8;
            GridPanelAlternativas.Text = "gridPanel1";
            // 
            // InputQuestaoEnunciado
            // 
            InputQuestaoEnunciado.Anchor = AnchorStyles.Top;
            InputQuestaoEnunciado.AutoScroll = true;
            InputQuestaoEnunciado.BackColor = Color.FromArgb(66, 66, 66);
            InputQuestaoEnunciado.ColorScheme = AntdUI.TAMode.Dark;
            InputQuestaoEnunciado.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputQuestaoEnunciado.Location = new Point(50, 3);
            InputQuestaoEnunciado.Multiline = true;
            InputQuestaoEnunciado.Name = "InputQuestaoEnunciado";
            InputQuestaoEnunciado.PrefixText = "";
            InputQuestaoEnunciado.ReadOnly = true;
            InputQuestaoEnunciado.Size = new Size(900, 175);
            InputQuestaoEnunciado.TabIndex = 7;
            // 
            // PainelQuestaoRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(GridPanelAlternativas);
            Controls.Add(InputQuestaoEnunciado);
            Name = "PainelQuestaoRush";
            Size = new Size(1000, 700);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.GridPanel GridPanelAlternativas;
        private AntdUI.Input InputQuestaoEnunciado;
    }
}
