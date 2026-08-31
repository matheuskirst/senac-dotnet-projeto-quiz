namespace SenacQuizApp.Telas.QuizDiario
{
    partial class HubQuizDiario
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
            LabelQuizDiarioTitulo = new AntdUI.Label();
            PanelQuizDiario = new AntdUI.Panel();
            ButtonQuizDiario = new AntdUI.Button();
            LabelStatus = new AntdUI.Label();
            PanelQuizDiario.SuspendLayout();
            SuspendLayout();
            // 
            // LabelQuizDiarioTitulo
            // 
            LabelQuizDiarioTitulo.BackColor = Color.Transparent;
            LabelQuizDiarioTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizDiarioTitulo.Dock = DockStyle.Top;
            LabelQuizDiarioTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizDiarioTitulo.Location = new Point(0, 0);
            LabelQuizDiarioTitulo.Name = "LabelQuizDiarioTitulo";
            LabelQuizDiarioTitulo.Size = new Size(400, 64);
            LabelQuizDiarioTitulo.TabIndex = 2;
            LabelQuizDiarioTitulo.Text = "Quiz Diário";
            LabelQuizDiarioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelQuizDiario
            // 
            PanelQuizDiario.Anchor = AnchorStyles.None;
            PanelQuizDiario.Back = Color.FromArgb(33, 33, 33);
            PanelQuizDiario.Controls.Add(ButtonQuizDiario);
            PanelQuizDiario.Controls.Add(LabelStatus);
            PanelQuizDiario.Controls.Add(LabelQuizDiarioTitulo);
            PanelQuizDiario.Location = new Point(312, 212);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Size = new Size(400, 248);
            PanelQuizDiario.TabIndex = 3;
            PanelQuizDiario.Text = "panel1";
            // 
            // ButtonQuizDiario
            // 
            ButtonQuizDiario.BorderWidth = 1F;
            ButtonQuizDiario.ColorScheme = AntdUI.TAMode.Dark;
            ButtonQuizDiario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizDiario.Location = new Point(121, 125);
            ButtonQuizDiario.Name = "ButtonQuizDiario";
            ButtonQuizDiario.Size = new Size(158, 58);
            ButtonQuizDiario.TabIndex = 5;
            ButtonQuizDiario.Text = "Iniciar";
            // 
            // LabelStatus
            // 
            LabelStatus.BackColor = Color.Transparent;
            LabelStatus.ColorScheme = AntdUI.TAMode.Dark;
            LabelStatus.Dock = DockStyle.Top;
            LabelStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelStatus.Location = new Point(0, 64);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Prefix = "Status: ";
            LabelStatus.Size = new Size(400, 64);
            LabelStatus.TabIndex = 4;
            LabelStatus.Text = "#";
            LabelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HubQuizDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelQuizDiario);
            Name = "HubQuizDiario";
            Size = new Size(1024, 720);
            Load += PaginaQuiz_Load;
            PanelQuizDiario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelQuizDiarioTitulo;
        private AntdUI.Panel PanelQuizDiario;
        private AntdUI.Button ButtonQuizDiario;
        private AntdUI.Label LabelStatus;
    }
}
