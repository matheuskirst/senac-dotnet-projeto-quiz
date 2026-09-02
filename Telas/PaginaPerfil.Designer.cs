namespace SenacQuizApp.Telas
{
    partial class PaginaPerfil
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
            LabelUsuario = new AntdUI.Label();
            LabelNivel = new AntdUI.Label();
            ProgressUsuarioNivel = new AntdUI.Progress();
            LabelProgressoPontos = new AntdUI.Label();
            LabelPontosProximoNivel = new AntdUI.Label();
            PanelStats = new AntdUI.Panel();
            LabelInsertTaxaAcertos = new AntdUI.Label();
            LabelTaxaAcertos = new AntdUI.Label();
            divider3 = new AntdUI.Divider();
            LabelInsertTotalRespostas = new AntdUI.Label();
            LabelTotalRespostas = new AntdUI.Label();
            divider2 = new AntdUI.Divider();
            LabelInsertAcertos = new AntdUI.Label();
            LabelAcertos = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            LabelInsertPontuacaoTotal = new AntdUI.Label();
            LabelPontuacaoTotal = new AntdUI.Label();
            PanelCentral = new AntdUI.Panel();
            LabelConquistas = new AntdUI.Label();
            PanelUsuario = new AntdUI.Panel();
            PanelConquistas = new AntdUI.Panel();
            PanelNivel = new AntdUI.Panel();
            PanelStats.SuspendLayout();
            PanelCentral.SuspendLayout();
            PanelUsuario.SuspendLayout();
            PanelNivel.SuspendLayout();
            SuspendLayout();
            // 
            // LabelUsuario
            // 
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.ColorScheme = AntdUI.TAMode.Dark;
            LabelUsuario.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsuario.Location = new Point(13, 11);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Prefix = "";
            LabelUsuario.Size = new Size(497, 58);
            LabelUsuario.TabIndex = 1;
            LabelUsuario.Text = "";
            // 
            // LabelNivel
            // 
            LabelNivel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelNivel.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelNivel.BackColor = Color.Transparent;
            LabelNivel.ColorScheme = AntdUI.TAMode.Dark;
            LabelNivel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNivel.Location = new Point(10, 11);
            LabelNivel.Name = "LabelNivel";
            LabelNivel.Prefix = "Nivel: ";
            LabelNivel.Size = new Size(83, 27);
            LabelNivel.TabIndex = 0;
            LabelNivel.Text = "#";
            // 
            // ProgressUsuarioNivel
            // 
            ProgressUsuarioNivel.BackColor = Color.Transparent;
            ProgressUsuarioNivel.ColorScheme = AntdUI.TAMode.Dark;
            ProgressUsuarioNivel.Fill = Color.Green;
            ProgressUsuarioNivel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgressUsuarioNivel.Location = new Point(10, 44);
            ProgressUsuarioNivel.Name = "ProgressUsuarioNivel";
            ProgressUsuarioNivel.Shape = AntdUI.TShapeProgress.Default;
            ProgressUsuarioNivel.Size = new Size(191, 25);
            ProgressUsuarioNivel.TabIndex = 5;
            ProgressUsuarioNivel.Text = "";
            // 
            // LabelProgressoPontos
            // 
            LabelProgressoPontos.BackColor = Color.Transparent;
            LabelProgressoPontos.ColorScheme = AntdUI.TAMode.Dark;
            LabelProgressoPontos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelProgressoPontos.Location = new Point(10, 75);
            LabelProgressoPontos.Name = "LabelProgressoPontos";
            LabelProgressoPontos.Size = new Size(191, 28);
            LabelProgressoPontos.TabIndex = 6;
            LabelProgressoPontos.Text = "0/0 Pontos";
            // 
            // LabelPontosProximoNivel
            // 
            LabelPontosProximoNivel.BackColor = Color.Transparent;
            LabelPontosProximoNivel.ColorScheme = AntdUI.TAMode.Dark;
            LabelPontosProximoNivel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPontosProximoNivel.Location = new Point(10, 109);
            LabelPontosProximoNivel.Name = "LabelPontosProximoNivel";
            LabelPontosProximoNivel.Size = new Size(217, 43);
            LabelPontosProximoNivel.TabIndex = 7;
            LabelPontosProximoNivel.Text = "0 Pontos para o próximo nível";
            LabelPontosProximoNivel.TextAlign = ContentAlignment.TopLeft;
            // 
            // PanelStats
            // 
            PanelStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PanelStats.Back = Color.FromArgb(33, 30, 30);
            PanelStats.BackColor = Color.DimGray;
            PanelStats.Controls.Add(LabelInsertTaxaAcertos);
            PanelStats.Controls.Add(LabelTaxaAcertos);
            PanelStats.Controls.Add(divider3);
            PanelStats.Controls.Add(LabelInsertTotalRespostas);
            PanelStats.Controls.Add(LabelTotalRespostas);
            PanelStats.Controls.Add(divider2);
            PanelStats.Controls.Add(LabelInsertAcertos);
            PanelStats.Controls.Add(LabelAcertos);
            PanelStats.Controls.Add(divider1);
            PanelStats.Controls.Add(LabelInsertPontuacaoTotal);
            PanelStats.Controls.Add(LabelPontuacaoTotal);
            PanelStats.Location = new Point(623, 193);
            PanelStats.Name = "PanelStats";
            PanelStats.Padding = new Padding(10);
            PanelStats.Radius = 0;
            PanelStats.Size = new Size(224, 524);
            PanelStats.TabIndex = 4;
            // 
            // LabelInsertTaxaAcertos
            // 
            LabelInsertTaxaAcertos.BackColor = Color.FromArgb(61, 61, 61);
            LabelInsertTaxaAcertos.Dock = DockStyle.Top;
            LabelInsertTaxaAcertos.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInsertTaxaAcertos.ForeColor = Color.White;
            LabelInsertTaxaAcertos.Location = new Point(10, 360);
            LabelInsertTaxaAcertos.Name = "LabelInsertTaxaAcertos";
            LabelInsertTaxaAcertos.Prefix = "";
            LabelInsertTaxaAcertos.Size = new Size(204, 40);
            LabelInsertTaxaAcertos.TabIndex = 14;
            LabelInsertTaxaAcertos.Text = "0";
            LabelInsertTaxaAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelTaxaAcertos
            // 
            LabelTaxaAcertos.BackColor = Color.Transparent;
            LabelTaxaAcertos.Dock = DockStyle.Top;
            LabelTaxaAcertos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTaxaAcertos.ForeColor = Color.White;
            LabelTaxaAcertos.Location = new Point(10, 325);
            LabelTaxaAcertos.Name = "LabelTaxaAcertos";
            LabelTaxaAcertos.Prefix = "";
            LabelTaxaAcertos.Size = new Size(204, 35);
            LabelTaxaAcertos.TabIndex = 13;
            LabelTaxaAcertos.Text = "Taxa de Acertos:";
            // 
            // divider3
            // 
            divider3.BackColor = Color.Transparent;
            divider3.ColorSplit = Color.Transparent;
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider3.Location = new Point(10, 295);
            divider3.Name = "divider3";
            divider3.OrientationMargin = 0F;
            divider3.Size = new Size(204, 30);
            divider3.TabIndex = 15;
            divider3.Text = "";
            divider3.TextPadding = 0F;
            divider3.Thickness = 1F;
            // 
            // LabelInsertTotalRespostas
            // 
            LabelInsertTotalRespostas.BackColor = Color.FromArgb(61, 61, 61);
            LabelInsertTotalRespostas.Dock = DockStyle.Top;
            LabelInsertTotalRespostas.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInsertTotalRespostas.ForeColor = Color.White;
            LabelInsertTotalRespostas.Location = new Point(10, 255);
            LabelInsertTotalRespostas.Name = "LabelInsertTotalRespostas";
            LabelInsertTotalRespostas.Prefix = "";
            LabelInsertTotalRespostas.Size = new Size(204, 40);
            LabelInsertTotalRespostas.TabIndex = 6;
            LabelInsertTotalRespostas.Text = "0";
            LabelInsertTotalRespostas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelTotalRespostas
            // 
            LabelTotalRespostas.BackColor = Color.Transparent;
            LabelTotalRespostas.Dock = DockStyle.Top;
            LabelTotalRespostas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTotalRespostas.ForeColor = Color.White;
            LabelTotalRespostas.Location = new Point(10, 220);
            LabelTotalRespostas.Name = "LabelTotalRespostas";
            LabelTotalRespostas.Prefix = "";
            LabelTotalRespostas.Size = new Size(204, 35);
            LabelTotalRespostas.TabIndex = 4;
            LabelTotalRespostas.Text = "Questões Respondidas:";
            // 
            // divider2
            // 
            divider2.BackColor = Color.Transparent;
            divider2.ColorSplit = Color.Transparent;
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider2.Location = new Point(10, 190);
            divider2.Name = "divider2";
            divider2.OrientationMargin = 0F;
            divider2.Size = new Size(204, 30);
            divider2.TabIndex = 11;
            divider2.Text = "";
            divider2.TextPadding = 0F;
            divider2.Thickness = 1F;
            // 
            // LabelInsertAcertos
            // 
            LabelInsertAcertos.BackColor = Color.FromArgb(61, 61, 61);
            LabelInsertAcertos.Dock = DockStyle.Top;
            LabelInsertAcertos.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInsertAcertos.ForeColor = Color.White;
            LabelInsertAcertos.Location = new Point(10, 150);
            LabelInsertAcertos.Name = "LabelInsertAcertos";
            LabelInsertAcertos.Prefix = "";
            LabelInsertAcertos.Size = new Size(204, 40);
            LabelInsertAcertos.TabIndex = 12;
            LabelInsertAcertos.Text = "0";
            LabelInsertAcertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAcertos
            // 
            LabelAcertos.BackColor = Color.Transparent;
            LabelAcertos.Dock = DockStyle.Top;
            LabelAcertos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAcertos.ForeColor = Color.White;
            LabelAcertos.Location = new Point(10, 115);
            LabelAcertos.Name = "LabelAcertos";
            LabelAcertos.Prefix = "";
            LabelAcertos.Size = new Size(204, 35);
            LabelAcertos.TabIndex = 9;
            LabelAcertos.Text = "Acertos:";
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.ColorSplit = Color.Transparent;
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider1.Location = new Point(10, 85);
            divider1.Name = "divider1";
            divider1.OrientationMargin = 0F;
            divider1.Size = new Size(204, 30);
            divider1.TabIndex = 7;
            divider1.Text = "";
            divider1.TextPadding = 0F;
            divider1.Thickness = 1F;
            // 
            // LabelInsertPontuacaoTotal
            // 
            LabelInsertPontuacaoTotal.BackColor = Color.FromArgb(61, 61, 61);
            LabelInsertPontuacaoTotal.Dock = DockStyle.Top;
            LabelInsertPontuacaoTotal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInsertPontuacaoTotal.ForeColor = Color.White;
            LabelInsertPontuacaoTotal.Location = new Point(10, 45);
            LabelInsertPontuacaoTotal.Name = "LabelInsertPontuacaoTotal";
            LabelInsertPontuacaoTotal.Prefix = "";
            LabelInsertPontuacaoTotal.Size = new Size(204, 40);
            LabelInsertPontuacaoTotal.TabIndex = 5;
            LabelInsertPontuacaoTotal.Text = "0";
            LabelInsertPontuacaoTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelPontuacaoTotal
            // 
            LabelPontuacaoTotal.BackColor = Color.Transparent;
            LabelPontuacaoTotal.Dock = DockStyle.Top;
            LabelPontuacaoTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPontuacaoTotal.ForeColor = Color.White;
            LabelPontuacaoTotal.Location = new Point(10, 10);
            LabelPontuacaoTotal.Name = "LabelPontuacaoTotal";
            LabelPontuacaoTotal.Prefix = "";
            LabelPontuacaoTotal.Size = new Size(204, 35);
            LabelPontuacaoTotal.TabIndex = 2;
            LabelPontuacaoTotal.Text = "Pontuação Total:";
            // 
            // PanelCentral
            // 
            PanelCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelCentral.Back = Color.FromArgb(33, 33, 33);
            PanelCentral.Controls.Add(LabelConquistas);
            PanelCentral.Controls.Add(PanelUsuario);
            PanelCentral.Controls.Add(PanelConquistas);
            PanelCentral.Controls.Add(PanelNivel);
            PanelCentral.Controls.Add(PanelStats);
            PanelCentral.Location = new Point(215, 0);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Radius = 0;
            PanelCentral.Size = new Size(850, 720);
            PanelCentral.TabIndex = 3;
            PanelCentral.Text = "panel1";
            // 
            // LabelConquistas
            // 
            LabelConquistas.BackColor = Color.FromArgb(33, 30, 30);
            LabelConquistas.ColorScheme = AntdUI.TAMode.Dark;
            LabelConquistas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelConquistas.Location = new Point(12, 193);
            LabelConquistas.Name = "LabelConquistas";
            LabelConquistas.Padding = new Padding(10);
            LabelConquistas.Size = new Size(595, 45);
            LabelConquistas.TabIndex = 11;
            LabelConquistas.Text = "Conquistas:";
            // 
            // PanelUsuario
            // 
            PanelUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelUsuario.Back = Color.FromArgb(33, 30, 30);
            PanelUsuario.BackColor = Color.DimGray;
            PanelUsuario.Controls.Add(LabelUsuario);
            PanelUsuario.Location = new Point(12, 26);
            PanelUsuario.Name = "PanelUsuario";
            PanelUsuario.Padding = new Padding(10);
            PanelUsuario.Radius = 0;
            PanelUsuario.Size = new Size(595, 152);
            PanelUsuario.TabIndex = 10;
            // 
            // PanelConquistas
            // 
            PanelConquistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelConquistas.AutoScroll = true;
            PanelConquistas.Back = Color.FromArgb(33, 30, 30);
            PanelConquistas.Location = new Point(12, 238);
            PanelConquistas.Name = "PanelConquistas";
            PanelConquistas.Padding = new Padding(10);
            PanelConquistas.Radius = 0;
            PanelConquistas.Size = new Size(595, 479);
            PanelConquistas.TabIndex = 9;
            // 
            // PanelNivel
            // 
            PanelNivel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelNivel.Back = Color.FromArgb(33, 30, 30);
            PanelNivel.BackColor = Color.DimGray;
            PanelNivel.Controls.Add(LabelNivel);
            PanelNivel.Controls.Add(ProgressUsuarioNivel);
            PanelNivel.Controls.Add(LabelPontosProximoNivel);
            PanelNivel.Controls.Add(LabelProgressoPontos);
            PanelNivel.Location = new Point(623, 26);
            PanelNivel.Name = "PanelNivel";
            PanelNivel.Padding = new Padding(10);
            PanelNivel.Radius = 0;
            PanelNivel.Size = new Size(224, 152);
            PanelNivel.TabIndex = 8;
            // 
            // PaginaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelCentral);
            Name = "PaginaPerfil";
            Size = new Size(1280, 720);
            Load += PaginaPerfil_Load;
            PanelStats.ResumeLayout(false);
            PanelCentral.ResumeLayout(false);
            PanelUsuario.ResumeLayout(false);
            PanelNivel.ResumeLayout(false);
            PanelNivel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelUsuario;
        private AntdUI.Label LabelNivel;
        private AntdUI.Progress ProgressUsuarioNivel;
        private AntdUI.Label LabelProgressoPontos;
        private AntdUI.Label LabelPontosProximoNivel;
        private AntdUI.Panel PanelStats;
        private AntdUI.Label LabelInsertTaxaAcertos;
        private AntdUI.Label LabelTaxaAcertos;
        private AntdUI.Divider divider3;
        private AntdUI.Label LabelInsertTotalRespostas;
        private AntdUI.Label LabelTotalRespostas;
        private AntdUI.Divider divider2;
        private AntdUI.Label LabelInsertAcertos;
        private AntdUI.Label LabelAcertos;
        private AntdUI.Divider divider1;
        private AntdUI.Label LabelInsertPontuacaoTotal;
        private AntdUI.Label LabelPontuacaoTotal;
        private AntdUI.Panel PanelCentral;
        private AntdUI.Panel PanelNivel;
        private AntdUI.Panel PanelConquistas;
        private AntdUI.Panel PanelUsuario;
        private AntdUI.Label LabelConquistas;
    }
}
