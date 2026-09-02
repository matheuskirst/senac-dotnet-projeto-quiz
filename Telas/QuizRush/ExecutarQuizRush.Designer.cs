namespace SenacQuizApp.Telas.QuizRush
{
    partial class ExecutarQuizRush
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
            PanelHeader = new AntdUI.Panel();
            LabelTempo = new AntdUI.Label();
            LabelTempoRestante = new AntdUI.Label();
            LabelQuizRushTitulo = new AntdUI.Label();
            PanelQuizHeaderQuestao = new AntdUI.Panel();
            LabelQuizQuestaoPontos = new AntdUI.Label();
            LabelQuizQuestaoAtual = new AntdUI.Label();
            PanelQuizHeaderUsuario = new AntdUI.Panel();
            LabelUsuarioNivel = new AntdUI.Label();
            LabelUsuarioNick = new AntdUI.Label();
            LabelStreak = new AntdUI.Label();
            PanelQuestoes = new AntdUI.Panel();
            LabelPontuacaoTotal = new AntdUI.Label();
            PanelHeader.SuspendLayout();
            PanelQuizHeaderQuestao.SuspendLayout();
            PanelQuizHeaderUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.Back = Color.FromArgb(33, 33, 33);
            PanelHeader.Controls.Add(LabelTempo);
            PanelHeader.Controls.Add(LabelTempoRestante);
            PanelHeader.Controls.Add(LabelQuizRushTitulo);
            PanelHeader.Controls.Add(PanelQuizHeaderQuestao);
            PanelHeader.Controls.Add(PanelQuizHeaderUsuario);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Margin = new Padding(0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1024, 120);
            PanelHeader.TabIndex = 4;
            // 
            // LabelTempo
            // 
            LabelTempo.BackColor = Color.Transparent;
            LabelTempo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTempo.Dock = DockStyle.Top;
            LabelTempo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTempo.Location = new Point(300, 79);
            LabelTempo.Name = "LabelTempo";
            LabelTempo.Size = new Size(424, 41);
            LabelTempo.TabIndex = 10;
            LabelTempo.Text = "00:00";
            LabelTempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelTempoRestante
            // 
            LabelTempoRestante.BackColor = Color.Transparent;
            LabelTempoRestante.ColorScheme = AntdUI.TAMode.Dark;
            LabelTempoRestante.Dock = DockStyle.Top;
            LabelTempoRestante.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTempoRestante.ForeColor = Color.Gray;
            LabelTempoRestante.Location = new Point(300, 50);
            LabelTempoRestante.Name = "LabelTempoRestante";
            LabelTempoRestante.Size = new Size(424, 29);
            LabelTempoRestante.TabIndex = 9;
            LabelTempoRestante.Text = "Tempo Restante:";
            LabelTempoRestante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelQuizRushTitulo
            // 
            LabelQuizRushTitulo.BackColor = Color.Transparent;
            LabelQuizRushTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizRushTitulo.Dock = DockStyle.Top;
            LabelQuizRushTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizRushTitulo.Location = new Point(300, 0);
            LabelQuizRushTitulo.Name = "LabelQuizRushTitulo";
            LabelQuizRushTitulo.Size = new Size(424, 50);
            LabelQuizRushTitulo.TabIndex = 8;
            LabelQuizRushTitulo.Text = "Rush";
            LabelQuizRushTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelQuizHeaderQuestao
            // 
            PanelQuizHeaderQuestao.Back = Color.FromArgb(50, 45, 45);
            PanelQuizHeaderQuestao.BackColor = Color.Transparent;
            PanelQuizHeaderQuestao.Controls.Add(LabelPontuacaoTotal);
            PanelQuizHeaderQuestao.Controls.Add(LabelQuizQuestaoPontos);
            PanelQuizHeaderQuestao.Controls.Add(LabelQuizQuestaoAtual);
            PanelQuizHeaderQuestao.Dock = DockStyle.Right;
            PanelQuizHeaderQuestao.Location = new Point(724, 0);
            PanelQuizHeaderQuestao.Margin = new Padding(0);
            PanelQuizHeaderQuestao.Name = "PanelQuizHeaderQuestao";
            PanelQuizHeaderQuestao.Padding = new Padding(10);
            PanelQuizHeaderQuestao.Radius = 15;
            PanelQuizHeaderQuestao.RadiusAlign = AntdUI.TAlignRound.BL;
            PanelQuizHeaderQuestao.Size = new Size(300, 120);
            PanelQuizHeaderQuestao.TabIndex = 7;
            PanelQuizHeaderQuestao.Text = "panel2";
            // 
            // LabelQuizQuestaoPontos
            // 
            LabelQuizQuestaoPontos.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoPontos.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelQuizQuestaoPontos.BackColor = Color.Transparent;
            LabelQuizQuestaoPontos.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizQuestaoPontos.Font = new Font("Segoe UI", 14.25F);
            LabelQuizQuestaoPontos.Location = new Point(13, 49);
            LabelQuizQuestaoPontos.Name = "LabelQuizQuestaoPontos";
            LabelQuizQuestaoPontos.Prefix = "Vale:  ";
            LabelQuizQuestaoPontos.Size = new Size(63, 28);
            LabelQuizQuestaoPontos.TabIndex = 7;
            LabelQuizQuestaoPontos.Text = "0";
            // 
            // LabelQuizQuestaoAtual
            // 
            LabelQuizQuestaoAtual.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoAtual.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelQuizQuestaoAtual.BackColor = Color.Transparent;
            LabelQuizQuestaoAtual.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizQuestaoAtual.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizQuestaoAtual.Location = new Point(13, 13);
            LabelQuizQuestaoAtual.Name = "LabelQuizQuestaoAtual";
            LabelQuizQuestaoAtual.Prefix = "Questão Atual:  ";
            LabelQuizQuestaoAtual.Size = new Size(146, 30);
            LabelQuizQuestaoAtual.TabIndex = 5;
            LabelQuizQuestaoAtual.Text = "0";
            // 
            // PanelQuizHeaderUsuario
            // 
            PanelQuizHeaderUsuario.Back = Color.FromArgb(50, 45, 45);
            PanelQuizHeaderUsuario.BackColor = Color.Transparent;
            PanelQuizHeaderUsuario.Controls.Add(LabelUsuarioNivel);
            PanelQuizHeaderUsuario.Controls.Add(LabelUsuarioNick);
            PanelQuizHeaderUsuario.Controls.Add(LabelStreak);
            PanelQuizHeaderUsuario.Dock = DockStyle.Left;
            PanelQuizHeaderUsuario.Location = new Point(0, 0);
            PanelQuizHeaderUsuario.Margin = new Padding(0);
            PanelQuizHeaderUsuario.Name = "PanelQuizHeaderUsuario";
            PanelQuizHeaderUsuario.Padding = new Padding(10);
            PanelQuizHeaderUsuario.Radius = 15;
            PanelQuizHeaderUsuario.RadiusAlign = AntdUI.TAlignRound.BR;
            PanelQuizHeaderUsuario.Size = new Size(300, 120);
            PanelQuizHeaderUsuario.TabIndex = 6;
            PanelQuizHeaderUsuario.Text = "panel2";
            // 
            // LabelUsuarioNivel
            // 
            LabelUsuarioNivel.Anchor = AnchorStyles.Left;
            LabelUsuarioNivel.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelUsuarioNivel.BackColor = Color.Transparent;
            LabelUsuarioNivel.ColorScheme = AntdUI.TAMode.Dark;
            LabelUsuarioNivel.Font = new Font("Segoe UI", 14.25F);
            LabelUsuarioNivel.Location = new Point(13, 49);
            LabelUsuarioNivel.Name = "LabelUsuarioNivel";
            LabelUsuarioNivel.Prefix = "Nível: ";
            LabelUsuarioNivel.Size = new Size(66, 30);
            LabelUsuarioNivel.TabIndex = 7;
            LabelUsuarioNivel.Text = "#";
            // 
            // LabelUsuarioNick
            // 
            LabelUsuarioNick.Anchor = AnchorStyles.Left;
            LabelUsuarioNick.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelUsuarioNick.BackColor = Color.Transparent;
            LabelUsuarioNick.ColorScheme = AntdUI.TAMode.Dark;
            LabelUsuarioNick.Font = new Font("Segoe UI", 14.25F);
            LabelUsuarioNick.Location = new Point(13, 13);
            LabelUsuarioNick.Name = "LabelUsuarioNick";
            LabelUsuarioNick.Prefix = "Usuário: ";
            LabelUsuarioNick.Size = new Size(88, 30);
            LabelUsuarioNick.TabIndex = 6;
            LabelUsuarioNick.Text = "#";
            // 
            // LabelStreak
            // 
            LabelStreak.Anchor = AnchorStyles.Left;
            LabelStreak.AutoSizeMode = AntdUI.TAutoSize.Auto;
            LabelStreak.BackColor = Color.Transparent;
            LabelStreak.ColorScheme = AntdUI.TAMode.Dark;
            LabelStreak.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelStreak.Location = new Point(13, 83);
            LabelStreak.Name = "LabelStreak";
            LabelStreak.Prefix = "Streak: ";
            LabelStreak.Size = new Size(74, 28);
            LabelStreak.TabIndex = 5;
            LabelStreak.Text = "0";
            // 
            // PanelQuestoes
            // 
            PanelQuestoes.Back = Color.FromArgb(33, 33, 33);
            PanelQuestoes.Dock = DockStyle.Fill;
            PanelQuestoes.Location = new Point(0, 120);
            PanelQuestoes.Name = "PanelQuestoes";
            PanelQuestoes.Radius = 0;
            PanelQuestoes.Size = new Size(1024, 600);
            PanelQuestoes.TabIndex = 5;
            // 
            // LabelPontuacaoTotal
            // 
            LabelPontuacaoTotal.Anchor = AnchorStyles.Right;
            LabelPontuacaoTotal.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelPontuacaoTotal.BackColor = Color.Transparent;
            LabelPontuacaoTotal.ColorScheme = AntdUI.TAMode.Dark;
            LabelPontuacaoTotal.Font = new Font("Segoe UI", 14.25F);
            LabelPontuacaoTotal.Location = new Point(13, 83);
            LabelPontuacaoTotal.Name = "LabelPontuacaoTotal";
            LabelPontuacaoTotal.Prefix = "Total:  ";
            LabelPontuacaoTotal.Size = new Size(69, 28);
            LabelPontuacaoTotal.TabIndex = 8;
            LabelPontuacaoTotal.Text = "0";
            // 
            // ExecutarQuizRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelQuestoes);
            Controls.Add(PanelHeader);
            Name = "ExecutarQuizRush";
            Size = new Size(1024, 720);
            Load += ExecutarQuizRush_Load;
            PanelHeader.ResumeLayout(false);
            PanelQuizHeaderQuestao.ResumeLayout(false);
            PanelQuizHeaderQuestao.PerformLayout();
            PanelQuizHeaderUsuario.ResumeLayout(false);
            PanelQuizHeaderUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelHeader;
        private AntdUI.Label LabelQuizRush;
        private AntdUI.Label LabelQuizRushTitulo;
        private AntdUI.Panel PanelQuizHeaderQuestao;
        private AntdUI.Label LabelQuizQuestaoPontos;
        private AntdUI.Label LabelQuizQuestaoAtual;
        private AntdUI.Panel PanelQuizHeaderUsuario;
        private AntdUI.Label LabelUsuarioNivel;
        private AntdUI.Label LabelUsuarioNick;
        private AntdUI.Label LabelStreak;
        private AntdUI.Panel PanelQuestoes;
        private AntdUI.Label LabelTempoRestante;
        private AntdUI.Label LabelTempo;
        private AntdUI.Label LabelPontuacaoTotal;
    }
}
