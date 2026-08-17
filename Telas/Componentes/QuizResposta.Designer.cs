namespace SenacQuizApp.Telas.Componentes
{
    partial class QuizResposta
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
            ButtonResposta = new AntdUI.Button();
            SuspendLayout();
            // 
            // ButtonResposta
            // 
            ButtonResposta.Dock = DockStyle.Fill;
            ButtonResposta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonResposta.Location = new Point(0, 0);
            ButtonResposta.Name = "ButtonResposta";
            ButtonResposta.Size = new Size(350, 200);
            ButtonResposta.TabIndex = 0;
            ButtonResposta.TextMultiLine = true;
            ButtonResposta.ToggleText = "";
            // 
            // QuizResposta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonResposta);
            Name = "QuizResposta";
            Size = new Size(350, 200);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button ButtonResposta;
    }
}
