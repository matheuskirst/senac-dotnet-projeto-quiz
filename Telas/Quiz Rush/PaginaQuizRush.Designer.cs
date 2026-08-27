namespace SenacQuizApp.Telas
{
    partial class PaginaQuizRush
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
            PanelHeader = new AntdUI.Panel();
            LabelQuizDiarioTitulo = new AntdUI.Label();
            PanelQuizHeaderUsuario = new AntdUI.Panel();
            LabelUsuarioNivel = new AntdUI.Label();
            LabelUsuarioNick = new AntdUI.Label();
            PanelQuizHeaderQuestao = new AntdUI.Panel();
            LabelQuizQuestaoPontos = new AntdUI.Label();
            LabelQuizQuestaoIndex = new AntdUI.Label();
            PanelHeader.SuspendLayout();
            PanelQuizHeaderUsuario.SuspendLayout();
            PanelQuizHeaderQuestao.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuestoes
            // 
            PanelQuestoes.Dock = DockStyle.Fill;
            PanelQuestoes.Location = new Point(0, 120);
            PanelQuestoes.Name = "PanelQuestoes";
            PanelQuestoes.Padding = new Padding(20);
            PanelQuestoes.Size = new Size(1024, 600);
            PanelQuestoes.TabIndex = 1;
            // 
            // PanelHeader
            // 
            PanelHeader.Back = Color.Transparent;
            PanelHeader.BackColor = Color.Transparent;
            PanelHeader.Controls.Add(LabelQuizDiarioTitulo);
            PanelHeader.Controls.Add(PanelQuizHeaderUsuario);
            PanelHeader.Controls.Add(PanelQuizHeaderQuestao);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Margin = new Padding(0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1024, 120);
            PanelHeader.TabIndex = 2;
            PanelHeader.Text = "panel1";
            // 
            // LabelQuizDiarioTitulo
            // 
            LabelQuizDiarioTitulo.Dock = DockStyle.Top;
            LabelQuizDiarioTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizDiarioTitulo.Location = new Point(300, 0);
            LabelQuizDiarioTitulo.Name = "LabelQuizDiarioTitulo";
            LabelQuizDiarioTitulo.Size = new Size(424, 43);
            LabelQuizDiarioTitulo.TabIndex = 8;
            LabelQuizDiarioTitulo.Text = "Quiz Rush";
            LabelQuizDiarioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelQuizHeaderUsuario
            // 
            PanelQuizHeaderUsuario.Controls.Add(LabelUsuarioNivel);
            PanelQuizHeaderUsuario.Controls.Add(LabelUsuarioNick);
            PanelQuizHeaderUsuario.Dock = DockStyle.Left;
            PanelQuizHeaderUsuario.Location = new Point(0, 0);
            PanelQuizHeaderUsuario.Margin = new Padding(0);
            PanelQuizHeaderUsuario.Name = "PanelQuizHeaderUsuario";
            PanelQuizHeaderUsuario.Padding = new Padding(10);
            PanelQuizHeaderUsuario.Radius = 15;
            PanelQuizHeaderUsuario.RadiusAlign = AntdUI.TAlignRound.BR;
            PanelQuizHeaderUsuario.Size = new Size(300, 120);
            PanelQuizHeaderUsuario.TabIndex = 9;
            PanelQuizHeaderUsuario.Text = "panel2";
            // 
            // LabelUsuarioNivel
            // 
            LabelUsuarioNivel.Anchor = AnchorStyles.Left;
            LabelUsuarioNivel.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelUsuarioNivel.BackColor = Color.Transparent;
            LabelUsuarioNivel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsuarioNivel.Location = new Point(23, 110);
            LabelUsuarioNivel.Name = "LabelUsuarioNivel";
            LabelUsuarioNivel.Prefix = "Nível: ";
            LabelUsuarioNivel.Size = new Size(73, 30);
            LabelUsuarioNivel.TabIndex = 7;
            LabelUsuarioNivel.Text = "#";
            // 
            // LabelUsuarioNick
            // 
            LabelUsuarioNick.Anchor = AnchorStyles.Left;
            LabelUsuarioNick.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelUsuarioNick.BackColor = Color.Transparent;
            LabelUsuarioNick.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsuarioNick.Location = new Point(23, 73);
            LabelUsuarioNick.Name = "LabelUsuarioNick";
            LabelUsuarioNick.Prefix = "Usuário: ";
            LabelUsuarioNick.Size = new Size(96, 30);
            LabelUsuarioNick.TabIndex = 6;
            LabelUsuarioNick.Text = "#";
            // 
            // PanelQuizHeaderQuestao
            // 
            PanelQuizHeaderQuestao.Controls.Add(LabelQuizQuestaoPontos);
            PanelQuizHeaderQuestao.Controls.Add(LabelQuizQuestaoIndex);
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
            LabelQuizQuestaoPontos.Font = new Font("Segoe UI", 14.25F);
            LabelQuizQuestaoPontos.Location = new Point(303, 146);
            LabelQuizQuestaoPontos.Name = "LabelQuizQuestaoPontos";
            LabelQuizQuestaoPontos.Prefix = "Vale:  ";
            LabelQuizQuestaoPontos.Size = new Size(63, 28);
            LabelQuizQuestaoPontos.TabIndex = 4;
            LabelQuizQuestaoPontos.Text = "0";
            // 
            // LabelQuizQuestaoIndex
            // 
            LabelQuizQuestaoIndex.Anchor = AnchorStyles.Right;
            LabelQuizQuestaoIndex.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelQuizQuestaoIndex.BackColor = Color.Transparent;
            LabelQuizQuestaoIndex.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizQuestaoIndex.Location = new Point(303, 73);
            LabelQuizQuestaoIndex.Name = "LabelQuizQuestaoIndex";
            LabelQuizQuestaoIndex.Prefix = "Questão Atual:  ";
            LabelQuizQuestaoIndex.Size = new Size(146, 30);
            LabelQuizQuestaoIndex.TabIndex = 2;
            LabelQuizQuestaoIndex.Text = "0";
            // 
            // PaginaQuizRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelQuestoes);
            Controls.Add(PanelHeader);
            Name = "PaginaQuizRush";
            Size = new Size(1024, 720);
            PanelHeader.ResumeLayout(false);
            PanelQuizHeaderUsuario.ResumeLayout(false);
            PanelQuizHeaderUsuario.PerformLayout();
            PanelQuizHeaderQuestao.ResumeLayout(false);
            PanelQuizHeaderQuestao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelQuestoes;
        private AntdUI.Panel PanelHeader;
        private AntdUI.Label LabelQuizDiarioTitulo;
        private AntdUI.Panel PanelQuizHeaderQuestao;
        private AntdUI.Label LabelQuizQuestaoPontos;
        private AntdUI.Label LabelQuizQuestaoIndex;
        private AntdUI.Panel PanelQuizHeaderUsuario;
        private AntdUI.Label LabelUsuarioNivel;
        private AntdUI.Label LabelUsuarioNick;
    }
}
