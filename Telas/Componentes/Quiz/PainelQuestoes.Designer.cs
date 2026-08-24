namespace SenacQuizApp.Telas.Componentes
{
    partial class PainelQuestoes
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
            PanelPerguntaCentral = new TableLayoutPanel();
            InputPergunta = new AntdUI.Input();
            PanelAlternativas = new TableLayoutPanel();
            PanelPerguntaCentral.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPerguntaCentral
            // 
            PanelPerguntaCentral.ColumnCount = 3;
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelPerguntaCentral.Controls.Add(InputPergunta, 1, 0);
            PanelPerguntaCentral.Controls.Add(PanelAlternativas, 1, 1);
            PanelPerguntaCentral.Dock = DockStyle.Fill;
            PanelPerguntaCentral.Location = new Point(0, 0);
            PanelPerguntaCentral.Margin = new Padding(3, 2, 3, 2);
            PanelPerguntaCentral.Name = "PanelPerguntaCentral";
            PanelPerguntaCentral.RowCount = 3;
            PanelPerguntaCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelPerguntaCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            PanelPerguntaCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            PanelPerguntaCentral.Size = new Size(1000, 700);
            PanelPerguntaCentral.TabIndex = 3;
            // 
            // InputPergunta
            // 
            InputPergunta.AutoScroll = true;
            InputPergunta.Dock = DockStyle.Fill;
            InputPergunta.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputPergunta.Location = new Point(53, 2);
            InputPergunta.Margin = new Padding(3, 2, 3, 2);
            InputPergunta.MinimumSize = new Size(460, 100);
            InputPergunta.Multiline = true;
            InputPergunta.Name = "InputPergunta";
            InputPergunta.PrefixText = "Pergunta: ";
            InputPergunta.ReadOnly = true;
            InputPergunta.Size = new Size(894, 158);
            InputPergunta.TabIndex = 0;
            // 
            // PanelAlternativas
            // 
            PanelAlternativas.AutoScroll = true;
            PanelAlternativas.ColumnCount = 1;
            PanelAlternativas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PanelAlternativas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelAlternativas.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            PanelAlternativas.Dock = DockStyle.Fill;
            PanelAlternativas.Location = new Point(80, 192);
            PanelAlternativas.Margin = new Padding(30);
            PanelAlternativas.Name = "PanelAlternativas";
            PanelAlternativas.RowCount = 4;
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.Size = new Size(840, 427);
            PanelAlternativas.TabIndex = 1;
            // 
            // PainelQuestoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPerguntaCentral);
            Name = "PainelQuestoes";
            Size = new Size(1000, 700);
            Load += PainelPergunta_Load;
            PanelPerguntaCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelPerguntaCentral;
        private AntdUI.Input InputPergunta;
        private TableLayoutPanel PanelAlternativas;
    }
}
