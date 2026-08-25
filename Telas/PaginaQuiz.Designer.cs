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
            tableLayoutPanel1 = new TableLayoutPanel();
            PanelQuestoes = new Panel();
            PanelQuizProgresso = new AntdUI.Panel();
            LabelQuizSequenciaAcertos = new AntdUI.Label();
            LabelQuizQuestaoPontos = new AntdUI.Label();
            LabelQuizQuestaoNivel = new AntdUI.Label();
            LabelQuizQuestaoIndex = new AntdUI.Label();
            tableLayoutPanel1.SuspendLayout();
            PanelQuizProgresso.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(PanelQuestoes, 0, 1);
            tableLayoutPanel1.Controls.Add(PanelQuizProgresso, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1000, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PanelQuestoes
            // 
            PanelQuestoes.Dock = DockStyle.Fill;
            PanelQuestoes.Location = new Point(3, 103);
            PanelQuestoes.Name = "PanelQuestoes";
            PanelQuestoes.Size = new Size(994, 594);
            PanelQuestoes.TabIndex = 0;
            // 
            // PanelQuizProgresso
            // 
            PanelQuizProgresso.Controls.Add(LabelQuizSequenciaAcertos);
            PanelQuizProgresso.Controls.Add(LabelQuizQuestaoPontos);
            PanelQuizProgresso.Controls.Add(LabelQuizQuestaoNivel);
            PanelQuizProgresso.Controls.Add(LabelQuizQuestaoIndex);
            PanelQuizProgresso.Dock = DockStyle.Fill;
            PanelQuizProgresso.Location = new Point(3, 3);
            PanelQuizProgresso.Name = "PanelQuizProgresso";
            PanelQuizProgresso.Size = new Size(994, 94);
            PanelQuizProgresso.TabIndex = 1;
            PanelQuizProgresso.Text = "panel1";
            // 
            // LabelQuizSequenciaAcertos
            // 
            LabelQuizSequenciaAcertos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LabelQuizSequenciaAcertos.BackColor = Color.Transparent;
            LabelQuizSequenciaAcertos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizSequenciaAcertos.Location = new Point(3, 3);
            LabelQuizSequenciaAcertos.Name = "LabelQuizSequenciaAcertos";
            LabelQuizSequenciaAcertos.Prefix = "Sequência de Acertos:  ";
            LabelQuizSequenciaAcertos.Size = new Size(186, 23);
            LabelQuizSequenciaAcertos.TabIndex = 5;
            LabelQuizSequenciaAcertos.Text = "0";
            // 
            // LabelQuizQuestaoPontos
            // 
            LabelQuizQuestaoPontos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LabelQuizQuestaoPontos.BackColor = Color.Transparent;
            LabelQuizQuestaoPontos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizQuestaoPontos.Location = new Point(805, 61);
            LabelQuizQuestaoPontos.Name = "LabelQuizQuestaoPontos";
            LabelQuizQuestaoPontos.Prefix = "Pontos:  ";
            LabelQuizQuestaoPontos.Size = new Size(186, 23);
            LabelQuizQuestaoPontos.TabIndex = 4;
            LabelQuizQuestaoPontos.Text = "*";
            // 
            // LabelQuizQuestaoNivel
            // 
            LabelQuizQuestaoNivel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LabelQuizQuestaoNivel.BackColor = Color.Transparent;
            LabelQuizQuestaoNivel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizQuestaoNivel.Location = new Point(805, 32);
            LabelQuizQuestaoNivel.Name = "LabelQuizQuestaoNivel";
            LabelQuizQuestaoNivel.Prefix = "Bônus:  ";
            LabelQuizQuestaoNivel.Size = new Size(186, 23);
            LabelQuizQuestaoNivel.TabIndex = 3;
            LabelQuizQuestaoNivel.Text = "*";
            // 
            // LabelQuizQuestaoIndex
            // 
            LabelQuizQuestaoIndex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LabelQuizQuestaoIndex.BackColor = Color.Transparent;
            LabelQuizQuestaoIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizQuestaoIndex.Location = new Point(805, 3);
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
            Controls.Add(tableLayoutPanel1);
            Name = "PaginaQuiz";
            Size = new Size(1000, 700);
            Load += PaginaQuiz_Load;
            tableLayoutPanel1.ResumeLayout(false);
            PanelQuizProgresso.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel PanelQuestoes;
        private AntdUI.Panel PanelQuizProgresso;
        private AntdUI.Label LabelQuizQuestaoIndex;
        private AntdUI.Label LabelQuizQuestaoNivel;
        private AntdUI.Label LabelQuizQuestaoPontos;
        private AntdUI.Label LabelQuizSequenciaAcertos;
    }
}
