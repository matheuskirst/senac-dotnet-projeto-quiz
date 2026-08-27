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
            PanelAlternativas = new TableLayoutPanel();
            PanelPerguntaCentral = new TableLayoutPanel();
            InputQuestaoEnunciado = new AntdUI.Input();
            PanelPerguntaCentral.SuspendLayout();
            SuspendLayout();
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
            PanelAlternativas.Padding = new Padding(150, 0, 150, 0);
            PanelAlternativas.RowCount = 4;
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelAlternativas.Size = new Size(840, 427);
            PanelAlternativas.TabIndex = 1;
            // 
            // PanelPerguntaCentral
            // 
            PanelPerguntaCentral.ColumnCount = 3;
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            PanelPerguntaCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelPerguntaCentral.Controls.Add(PanelAlternativas, 1, 1);
            PanelPerguntaCentral.Controls.Add(InputQuestaoEnunciado, 1, 0);
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
            // InputQuestaoEnunciado
            // 
            InputQuestaoEnunciado.Dock = DockStyle.Fill;
            InputQuestaoEnunciado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputQuestaoEnunciado.Location = new Point(53, 3);
            InputQuestaoEnunciado.Multiline = true;
            InputQuestaoEnunciado.Name = "InputQuestaoEnunciado";
            InputQuestaoEnunciado.PrefixText = "";
            InputQuestaoEnunciado.ReadOnly = true;
            InputQuestaoEnunciado.Size = new Size(894, 156);
            InputQuestaoEnunciado.TabIndex = 2;
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
        private TableLayoutPanel PanelAlternativas;
        private TableLayoutPanel PanelPerguntaCentral;
        private AntdUI.Input InputQuestaoEnunciado;
    }
}
