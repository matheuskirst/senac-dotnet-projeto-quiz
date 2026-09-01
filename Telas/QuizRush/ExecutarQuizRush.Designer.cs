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
            LabelQuizRushTitulo = new AntdUI.Label();
            PanelQuizHeaderQuestao = new AntdUI.Panel();
            LabelQuizQuestaoPontos = new AntdUI.Label();
            LabelQuizQuestaoAtual = new AntdUI.Label();
            PanelQuizHeaderUsuario = new AntdUI.Panel();
            LabelUsuarioNivel = new AntdUI.Label();
            LabelUsuarioNick = new AntdUI.Label();
            LabelQuizSequenciaAcertos = new AntdUI.Label();
            PanelQuestoes = new AntdUI.Panel();
            PanelHeader.SuspendLayout();
            PanelQuizHeaderQuestao.SuspendLayout();
            PanelQuizHeaderUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.Back = Color.FromArgb(33, 33, 33);
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
            LabelQuizQuestaoPontos.Location = new Point(13, 51);
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
            PanelQuizHeaderUsuario.Controls.Add(LabelQuizSequenciaAcertos);
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
            // LabelQuizSequenciaAcertos
            // 
            LabelQuizSequenciaAcertos.Anchor = AnchorStyles.Left;
            LabelQuizSequenciaAcertos.AutoSizeMode = AntdUI.TAutoSize.Auto;
            LabelQuizSequenciaAcertos.BackColor = Color.Transparent;
            LabelQuizSequenciaAcertos.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizSequenciaAcertos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizSequenciaAcertos.Location = new Point(13, 83);
            LabelQuizSequenciaAcertos.Name = "LabelQuizSequenciaAcertos";
            LabelQuizSequenciaAcertos.Prefix = "Streak: ";
            LabelQuizSequenciaAcertos.Size = new Size(74, 28);
            LabelQuizSequenciaAcertos.TabIndex = 5;
            LabelQuizSequenciaAcertos.Text = "0";
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
            // ExecutarQuizRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelQuestoes);
            Controls.Add(PanelHeader);
            Name = "ExecutarQuizRush";
            Size = new Size(1024, 720);
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
        private AntdUI.Label LabelQuizSequenciaAcertos;
        private AntdUI.Panel PanelQuestoes;
    }
}
