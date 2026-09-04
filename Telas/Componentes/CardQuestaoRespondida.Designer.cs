namespace SenacQuizApp.Telas.Componentes
{
    partial class CardQuestaoRespondida
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            LabelEnunciado = new AntdUI.Label();
            LabelIndex = new AntdUI.Label();
            LabelRespostaCorreta = new AntdUI.Label();
            LabelAlternativas = new AntdUI.Label();
            LabelUsuarioResposta = new AntdUI.Label();
            PanelAlternativas = new FlowLayoutPanel();
            divider1 = new AntdUI.Divider();
            divider2 = new AntdUI.Divider();
            SuspendLayout();
            // 
            // LabelEnunciado
            // 
            LabelEnunciado.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelEnunciado.Dock = DockStyle.Top;
            LabelEnunciado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEnunciado.ForeColor = Color.FromArgb(224, 224, 224);
            LabelEnunciado.Location = new Point(10, 34);
            LabelEnunciado.Name = "LabelEnunciado";
            LabelEnunciado.Size = new Size(535, 22);
            LabelEnunciado.TabIndex = 7;
            LabelEnunciado.Text = "Enunciado";
            LabelEnunciado.TextAlign = ContentAlignment.TopLeft;
            // 
            // LabelIndex
            // 
            LabelIndex.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelIndex.Dock = DockStyle.Top;
            LabelIndex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelIndex.ForeColor = Color.WhiteSmoke;
            LabelIndex.Location = new Point(10, 10);
            LabelIndex.Name = "LabelIndex";
            LabelIndex.Prefix = "Questão: ";
            LabelIndex.Size = new Size(535, 24);
            LabelIndex.TabIndex = 6;
            LabelIndex.Text = "#";
            LabelIndex.TextMultiLine = false;
            LabelIndex.Click += LabelIndex_Click;
            // 
            // LabelRespostaCorreta
            // 
            LabelRespostaCorreta.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelRespostaCorreta.Dock = DockStyle.Top;
            LabelRespostaCorreta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelRespostaCorreta.ForeColor = Color.FromArgb(224, 224, 224);
            LabelRespostaCorreta.Location = new Point(10, 91);
            LabelRespostaCorreta.Name = "LabelRespostaCorreta";
            LabelRespostaCorreta.Prefix = "Resposta correta: ";
            LabelRespostaCorreta.Size = new Size(535, 24);
            LabelRespostaCorreta.TabIndex = 9;
            LabelRespostaCorreta.Text = "#";
            LabelRespostaCorreta.TextAlign = ContentAlignment.TopLeft;
            LabelRespostaCorreta.TextMultiLine = false;
            // 
            // LabelAlternativas
            // 
            LabelAlternativas.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelAlternativas.Dock = DockStyle.Top;
            LabelAlternativas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAlternativas.ForeColor = Color.FromArgb(224, 224, 224);
            LabelAlternativas.Location = new Point(10, 174);
            LabelAlternativas.Name = "LabelAlternativas";
            LabelAlternativas.Prefix = "";
            LabelAlternativas.Size = new Size(535, 24);
            LabelAlternativas.TabIndex = 10;
            LabelAlternativas.Text = "Alternativas:";
            LabelAlternativas.TextAlign = ContentAlignment.TopLeft;
            LabelAlternativas.TextMultiLine = false;
            // 
            // LabelUsuarioResposta
            // 
            LabelUsuarioResposta.AutoSizeMode = AntdUI.TAutoSize.Height;
            LabelUsuarioResposta.Dock = DockStyle.Top;
            LabelUsuarioResposta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsuarioResposta.ForeColor = Color.FromArgb(224, 224, 224);
            LabelUsuarioResposta.Location = new Point(10, 115);
            LabelUsuarioResposta.Name = "LabelUsuarioResposta";
            LabelUsuarioResposta.Prefix = "Sua resposta: ";
            LabelUsuarioResposta.Size = new Size(535, 24);
            LabelUsuarioResposta.TabIndex = 11;
            LabelUsuarioResposta.Text = "#";
            LabelUsuarioResposta.TextAlign = ContentAlignment.TopLeft;
            LabelUsuarioResposta.TextMultiLine = false;
            // 
            // PanelAlternativas
            // 
            PanelAlternativas.AutoSize = true;
            PanelAlternativas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelAlternativas.Dock = DockStyle.Top;
            PanelAlternativas.FlowDirection = FlowDirection.TopDown;
            PanelAlternativas.Location = new Point(10, 198);
            PanelAlternativas.Name = "PanelAlternativas";
            PanelAlternativas.Size = new Size(535, 0);
            PanelAlternativas.TabIndex = 12;
            PanelAlternativas.WrapContents = false;
            // 
            // divider1
            // 
            divider1.ColorScheme = AntdUI.TAMode.Dark;
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(10, 56);
            divider1.Name = "divider1";
            divider1.OrientationMargin = 0F;
            divider1.Size = new Size(535, 35);
            divider1.TabIndex = 13;
            divider1.Text = "";
            // 
            // divider2
            // 
            divider2.ColorScheme = AntdUI.TAMode.Dark;
            divider2.Dock = DockStyle.Top;
            divider2.Location = new Point(10, 139);
            divider2.Name = "divider2";
            divider2.OrientationMargin = 0F;
            divider2.Size = new Size(535, 35);
            divider2.TabIndex = 14;
            divider2.Text = "";
            // 
            // CardQuestaoRespondida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(PanelAlternativas);
            Controls.Add(LabelAlternativas);
            Controls.Add(divider2);
            Controls.Add(LabelUsuarioResposta);
            Controls.Add(LabelRespostaCorreta);
            Controls.Add(divider1);
            Controls.Add(LabelEnunciado);
            Controls.Add(LabelIndex);
            MinimumSize = new Size(555, 175);
            Name = "CardQuestaoRespondida";
            Padding = new Padding(10);
            Size = new Size(555, 208);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label LabelEnunciado;
        private AntdUI.Label LabelIndex;
        private AntdUI.Label LabelRespostaCorreta;
        private AntdUI.Label LabelAlternativas;
        private AntdUI.Label LabelUsuarioResposta;
        private FlowLayoutPanel PanelAlternativas;
        private AntdUI.Divider divider1;
        private AntdUI.Divider divider2;
    }
}
