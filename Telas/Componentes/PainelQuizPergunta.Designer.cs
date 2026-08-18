namespace SenacQuizApp.Telas.Componentes
{
    partial class PainelQuizPergunta
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
            PanelRespostas = new TableLayoutPanel();
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
            PanelPerguntaCentral.Controls.Add(PanelRespostas, 1, 1);
            PanelPerguntaCentral.Dock = DockStyle.Fill;
            PanelPerguntaCentral.Location = new Point(0, 0);
            PanelPerguntaCentral.Name = "PanelPerguntaCentral";
            PanelPerguntaCentral.RowCount = 2;
            PanelPerguntaCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelPerguntaCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            PanelPerguntaCentral.Size = new Size(600, 400);
            PanelPerguntaCentral.TabIndex = 1;
            // 
            // InputPergunta
            // 
            InputPergunta.Anchor = AnchorStyles.None;
            InputPergunta.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputPergunta.Location = new Point(33, 3);
            InputPergunta.Multiline = true;
            InputPergunta.Name = "InputPergunta";
            InputPergunta.PrefixText = "Pergunta: ";
            InputPergunta.Size = new Size(534, 94);
            InputPergunta.TabIndex = 0;
            // 
            // PanelRespostas
            // 
            PanelRespostas.ColumnCount = 2;
            PanelRespostas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelRespostas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelRespostas.Dock = DockStyle.Fill;
            PanelRespostas.Location = new Point(33, 103);
            PanelRespostas.Name = "PanelRespostas";
            PanelRespostas.RowCount = 2;
            PanelRespostas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelRespostas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PanelRespostas.Size = new Size(534, 294);
            PanelRespostas.TabIndex = 1;
            // 
            // PainelQuizPergunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPerguntaCentral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PainelQuizPergunta";
            Size = new Size(600, 400);
            Load += PainelQuizPergunta_Load;
            PanelPerguntaCentral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelPerguntaCentral;
        private AntdUI.Input InputPergunta;
        private TableLayoutPanel PanelRespostas;
    }
}
