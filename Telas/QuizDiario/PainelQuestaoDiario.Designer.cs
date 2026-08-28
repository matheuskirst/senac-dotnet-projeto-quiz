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
            InputQuestaoEnunciado = new AntdUI.Input();
            ButtonConfirmar = new AntdUI.Button();
            GridPanelAlternativas = new AntdUI.GridPanel();
            SuspendLayout();
            // 
            // InputQuestaoEnunciado
            // 
            InputQuestaoEnunciado.Anchor = AnchorStyles.Top;
            InputQuestaoEnunciado.AutoScroll = true;
            InputQuestaoEnunciado.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputQuestaoEnunciado.Location = new Point(50, 3);
            InputQuestaoEnunciado.Multiline = true;
            InputQuestaoEnunciado.Name = "InputQuestaoEnunciado";
            InputQuestaoEnunciado.PrefixText = "";
            InputQuestaoEnunciado.ReadOnly = true;
            InputQuestaoEnunciado.Size = new Size(900, 175);
            InputQuestaoEnunciado.TabIndex = 2;
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Anchor = AnchorStyles.Top;
            ButtonConfirmar.BorderWidth = 1F;
            ButtonConfirmar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonConfirmar.Location = new Point(375, 622);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.Size = new Size(250, 75);
            ButtonConfirmar.TabIndex = 5;
            ButtonConfirmar.Text = "Confirmar";
            ButtonConfirmar.Click += ButtonConfirmar_Click;
            // 
            // GridPanelAlternativas
            // 
            GridPanelAlternativas.Anchor = AnchorStyles.Top;
            GridPanelAlternativas.Location = new Point(100, 242);
            GridPanelAlternativas.Name = "GridPanelAlternativas";
            GridPanelAlternativas.Size = new Size(800, 300);
            GridPanelAlternativas.TabIndex = 6;
            GridPanelAlternativas.Text = "gridPanel1";
            // 
            // PainelQuestaoDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(GridPanelAlternativas);
            Controls.Add(ButtonConfirmar);
            Controls.Add(InputQuestaoEnunciado);
            Name = "PainelQuestaoDiario";
            Size = new Size(1000, 700);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Input InputQuestaoEnunciado;
        private AntdUI.Button ButtonConfirmar;
        private AntdUI.GridPanel GridPanelAlternativas;
    }
}
