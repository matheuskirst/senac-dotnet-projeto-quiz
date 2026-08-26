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
            LabelNivel = new AntdUI.Label();
            LabelUsuario = new AntdUI.Label();
            panel2 = new AntdUI.Panel();
            panel1 = new AntdUI.Panel();
            ProgressUsuarioNivel = new AntdUI.Progress();
            panel3 = new AntdUI.Panel();
            LabelInsertTotalRespostas = new AntdUI.Label();
            LabelTotalRespostas = new AntdUI.Label();
            divider2 = new AntdUI.Divider();
            LabelInsertAcertos = new AntdUI.Label();
            LabelAcertos = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            LabelInsertPontuacaoTotal = new AntdUI.Label();
            LabelPontuacaoTotal = new AntdUI.Label();
            LabelInsertTaxaAcertos = new AntdUI.Label();
            LabelTaxaAcertos = new AntdUI.Label();
            divider3 = new AntdUI.Divider();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // LabelNivel
            // 
            LabelNivel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelNivel.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelNivel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelNivel.Location = new Point(573, 46);
            LabelNivel.Name = "LabelNivel";
            LabelNivel.Prefix = "Nivel: ";
            LabelNivel.Size = new Size(73, 27);
            LabelNivel.TabIndex = 0;
            LabelNivel.Text = "#";
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSizeMode = AntdUI.TAutoSize.Width;
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.Black;
            LabelUsuario.Location = new Point(48, 35);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Prefix = "Usuario: ";
            LabelUsuario.Size = new Size(96, 38);
            LabelUsuario.TabIndex = 1;
            LabelUsuario.Text = "#";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Back = Color.Transparent;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.ShadowAlign = AntdUI.TAlignMini.Right;
            panel2.Size = new Size(1280, 720);
            panel2.TabIndex = 4;
            panel2.Text = "panel2";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Back = Color.Transparent;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ProgressUsuarioNivel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(LabelUsuario);
            panel1.Controls.Add(LabelNivel);
            panel1.Location = new Point(240, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 720);
            panel1.TabIndex = 3;
            panel1.Text = "panel1";
            // 
            // ProgressUsuarioNivel
            // 
            ProgressUsuarioNivel.Location = new Point(573, 79);
            ProgressUsuarioNivel.Name = "ProgressUsuarioNivel";
            ProgressUsuarioNivel.Shape = AntdUI.TShapeProgress.Default;
            ProgressUsuarioNivel.Size = new Size(214, 74);
            ProgressUsuarioNivel.TabIndex = 5;
            ProgressUsuarioNivel.Text = "";
            ProgressUsuarioNivel.TextUnit = "";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Back = Color.Transparent;
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(LabelInsertTaxaAcertos);
            panel3.Controls.Add(LabelTaxaAcertos);
            panel3.Controls.Add(divider3);
            panel3.Controls.Add(LabelInsertTotalRespostas);
            panel3.Controls.Add(LabelTotalRespostas);
            panel3.Controls.Add(divider2);
            panel3.Controls.Add(LabelInsertAcertos);
            panel3.Controls.Add(LabelAcertos);
            panel3.Controls.Add(divider1);
            panel3.Controls.Add(LabelInsertPontuacaoTotal);
            panel3.Controls.Add(LabelPontuacaoTotal);
            panel3.Location = new Point(573, 193);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(224, 524);
            panel3.TabIndex = 4;
            // 
            // LabelInsertTotalRespostas
            // 
            LabelInsertTotalRespostas.BackColor = Color.Gray;
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
            LabelInsertAcertos.BackColor = Color.Gray;
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
            LabelInsertPontuacaoTotal.BackColor = Color.Gray;
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
            // LabelInsertTaxaAcertos
            // 
            LabelInsertTaxaAcertos.BackColor = Color.Gray;
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
            // PaginaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "PaginaPerfil";
            Size = new Size(1280, 720);
            Load += PaginaPerfil_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelNivel;
        private AntdUI.Label LabelUsuario;
        private AntdUI.Panel panel2;
        private AntdUI.Panel panel1;
        private AntdUI.Panel panel3;
        private AntdUI.Label LabelTotalRespostas;
        private AntdUI.Label LabelInsertPontuacaoTotal;
        private AntdUI.Label LabelPontuacaoTotal;
        private AntdUI.Label LabelInsertTotalRespostas;
        private AntdUI.Divider divider1;
        private AntdUI.Label label1;
        private AntdUI.Label LabelAcertos;
        private AntdUI.Divider divider2;
        private AntdUI.Label LabelInsertAcertos;
        private AntdUI.Progress ProgressUsuarioNivel;
        private AntdUI.Label LabelInsertTaxaAcertos;
        private AntdUI.Label LabelTaxaAcertos;
        private AntdUI.Divider divider3;
    }
}
