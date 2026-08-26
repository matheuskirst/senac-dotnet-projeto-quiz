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
            LabelQuizSequenciaAcertos = new AntdUI.Label();
            LabelQuizQuestaoPontos = new AntdUI.Label();
            LabelQuizQuestaoNivel = new AntdUI.Label();
            LabelQuizQuestaoIndex = new AntdUI.Label();
            PanelQuizProgresso.SuspendLayout();
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
            PanelQuizProgresso.Controls.Add(LabelQuizSequenciaAcertos);
            PanelQuizProgresso.Controls.Add(LabelQuizQuestaoPontos);
            PanelQuizProgresso.Controls.Add(LabelQuizQuestaoNivel);
            PanelQuizProgresso.Controls.Add(LabelQuizQuestaoIndex);
            PanelQuizProgresso.Dock = DockStyle.Top;
            PanelQuizProgresso.Location = new Point(0, 0);
            PanelQuizProgresso.Name = "PanelQuizProgresso";
            PanelQuizProgresso.Size = new Size(1000, 94);
            PanelQuizProgresso.TabIndex = 1;
            PanelQuizProgresso.Text = "panel1";
            // 
            // LabelQuizSequenciaAcertos
            // 
            LabelQuizSequenciaAcertos.Anchor = AnchorStyles.Left;
            LabelQuizSequenciaAcertos.BackColor = Color.Transparent;
            LabelQuizSequenciaAcertos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizSequenciaAcertos.Location = new Point(3, 32);
            LabelQuizSequenciaAcertos.Name = "LabelQuizSequenciaAcertos";
            LabelQuizSequenciaAcertos.Prefix = "Sequência de Acertos:  ";
            LabelQuizSequenciaAcertos.Size = new Size(378, 23);
            LabelQuizSequenciaAcertos.TabIndex = 5;
            LabelQuizSequenciaAcertos.Text = "0";
            // 
            // LabelQuizQuestaoPontos
            // 
            LabelQuizQuestaoPontos.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoPontos.BackColor = Color.Transparent;
            LabelQuizQuestaoPontos.Font = new Font("Segoe UI", 18F);
            LabelQuizQuestaoPontos.Location = new Point(780, 61);
            LabelQuizQuestaoPontos.Name = "LabelQuizQuestaoPontos";
            LabelQuizQuestaoPontos.Prefix = "Pontos:  ";
            LabelQuizQuestaoPontos.Size = new Size(186, 23);
            LabelQuizQuestaoPontos.TabIndex = 4;
            LabelQuizQuestaoPontos.Text = "*";
            // 
            // LabelQuizQuestaoNivel
            // 
            LabelQuizQuestaoNivel.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoNivel.BackColor = Color.Transparent;
            LabelQuizQuestaoNivel.Font = new Font("Segoe UI", 18F);
            LabelQuizQuestaoNivel.Location = new Point(780, 32);
            LabelQuizQuestaoNivel.Name = "LabelQuizQuestaoNivel";
            LabelQuizQuestaoNivel.Prefix = "Bônus:  ";
            LabelQuizQuestaoNivel.Size = new Size(186, 23);
            LabelQuizQuestaoNivel.TabIndex = 3;
            LabelQuizQuestaoNivel.Text = "*";
            // 
            // LabelQuizQuestaoIndex
            // 
            LabelQuizQuestaoIndex.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoIndex.BackColor = Color.Transparent;
            LabelQuizQuestaoIndex.Font = new Font("Segoe UI", 18F);
            LabelQuizQuestaoIndex.Location = new Point(780, 3);
            LabelQuizQuestaoIndex.Name = "LabelQuizQuestaoIndex";
            LabelQuizQuestaoIndex.Prefix = "Questão Atual:  ";
            LabelQuizQuestaoIndex.Size = new Size(186, 23);
            LabelQuizQuestaoIndex.TabIndex = 2;
            LabelQuizQuestaoIndex.Text = "*";
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
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelQuestoes;
        private AntdUI.Panel PanelQuizProgresso;
        private AntdUI.Label LabelQuizQuestaoIndex;
        private AntdUI.Label LabelQuizQuestaoNivel;
        private AntdUI.Label LabelQuizQuestaoPontos;
        private AntdUI.Label LabelQuizSequenciaAcertos;
    }
}
