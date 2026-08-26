namespace SenacQuizApp.Telas.Componentes
{
    partial class PaginaQuiz
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
            PanelQuestoes = new Panel();
            PanelQuizProgresso = new AntdUI.Panel();
            panel1 = new AntdUI.Panel();
            LabelQuizQuestaoBonus = new AntdUI.Label();
            LabelQuizQuestaoPontos = new AntdUI.Label();
            LabelQuizSequenciaAcertos = new AntdUI.Label();
            LabelQuizQuestaoIndex = new AntdUI.Label();
            PanelQuizProgresso.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuestoes
            // 
            PanelQuestoes.Dock = DockStyle.Fill;
            PanelQuestoes.Location = new Point(0, 94);
            PanelQuestoes.Name = "PanelQuestoes";
            PanelQuestoes.Size = new Size(1000, 606);
            PanelQuestoes.TabIndex = 0;
            // 
            // PanelQuizProgresso
            // 
            PanelQuizProgresso.Controls.Add(panel1);
            PanelQuizProgresso.Controls.Add(LabelQuizSequenciaAcertos);
            PanelQuizProgresso.Controls.Add(LabelQuizQuestaoIndex);
            PanelQuizProgresso.Dock = DockStyle.Top;
            PanelQuizProgresso.Location = new Point(0, 0);
            PanelQuizProgresso.Name = "PanelQuizProgresso";
            PanelQuizProgresso.Padding = new Padding(10);
            PanelQuizProgresso.Size = new Size(1000, 94);
            PanelQuizProgresso.TabIndex = 1;
            PanelQuizProgresso.Text = "panel1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Back = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            panel1.BorderColor = Color.Black;
            panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            panel1.BorderWidth = 1F;
            panel1.Controls.Add(LabelQuizQuestaoBonus);
            panel1.Controls.Add(LabelQuizQuestaoPontos);
            panel1.Location = new Point(767, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 62);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // LabelQuizQuestaoBonus
            // 
            LabelQuizQuestaoBonus.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoBonus.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelQuizQuestaoBonus.BackColor = Color.Transparent;
            LabelQuizQuestaoBonus.Font = new Font("Segoe UI", 14.25F);
            LabelQuizQuestaoBonus.Location = new Point(4, 4);
            LabelQuizQuestaoBonus.Name = "LabelQuizQuestaoBonus";
            LabelQuizQuestaoBonus.Prefix = "Bônus:  ";
            LabelQuizQuestaoBonus.Size = new Size(97, 28);
            LabelQuizQuestaoBonus.TabIndex = 3;
            LabelQuizQuestaoBonus.Text = "0%";
            // 
            // LabelQuizQuestaoPontos
            // 
            LabelQuizQuestaoPontos.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoPontos.AutoSizeMode = AntdUI.TAutoSize.Auto;
            LabelQuizQuestaoPontos.BackColor = Color.Transparent;
            LabelQuizQuestaoPontos.Font = new Font("Segoe UI", 14.25F);
            LabelQuizQuestaoPontos.Location = new Point(4, 33);
            LabelQuizQuestaoPontos.Name = "LabelQuizQuestaoPontos";
            LabelQuizQuestaoPontos.Prefix = "Pontos:  ";
            LabelQuizQuestaoPontos.Size = new Size(85, 28);
            LabelQuizQuestaoPontos.TabIndex = 4;
            LabelQuizQuestaoPontos.Text = "0";
            // 
            // LabelQuizSequenciaAcertos
            // 
            LabelQuizSequenciaAcertos.Anchor = AnchorStyles.Left;
            LabelQuizSequenciaAcertos.BackColor = Color.Transparent;
            LabelQuizSequenciaAcertos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizSequenciaAcertos.Location = new Point(13, 36);
            LabelQuizSequenciaAcertos.Name = "LabelQuizSequenciaAcertos";
            LabelQuizSequenciaAcertos.Prefix = "Sequência de Acertos:  ";
            LabelQuizSequenciaAcertos.Size = new Size(378, 23);
            LabelQuizSequenciaAcertos.TabIndex = 5;
            LabelQuizSequenciaAcertos.Text = "0";
            // 
            // LabelQuizQuestaoIndex
            // 
            LabelQuizQuestaoIndex.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoIndex.BackColor = Color.Transparent;
            LabelQuizQuestaoIndex.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizQuestaoIndex.Location = new Point(769, 5);
            LabelQuizQuestaoIndex.Name = "LabelQuizQuestaoIndex";
            LabelQuizQuestaoIndex.Prefix = "Questão Atual:  ";
            LabelQuizQuestaoIndex.Size = new Size(186, 23);
            LabelQuizQuestaoIndex.TabIndex = 2;
            LabelQuizQuestaoIndex.Text = "0";
            // 
            // PaginaQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelQuestoes);
            Controls.Add(PanelQuizProgresso);
            Name = "PaginaQuiz";
            Size = new Size(1000, 700);
            Load += PaginaQuiz_Load;
            PanelQuizProgresso.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelQuestoes;
        private AntdUI.Panel PanelQuizProgresso;
        private AntdUI.Label LabelQuizQuestaoIndex;
        private AntdUI.Label LabelQuizQuestaoBonus;
        private AntdUI.Label LabelQuizQuestaoPontos;
        private AntdUI.Label LabelQuizSequenciaAcertos;
        private AntdUI.Panel panel1;
    }
}
