namespace SenacQuizApp.Telas
{
    partial class PaginaPrincipal
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
            PanelQuizDiario = new AntdUI.Panel();
            ButtonQuizDiario = new AntdUI.Button();
            PanelHistoricoPreview = new AntdUI.Panel();
            LabelQuizzesPartidas = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            label1 = new AntdUI.Label();
            divider2 = new AntdUI.Divider();
            ButtonQuizRush = new AntdUI.Button();
            divider3 = new AntdUI.Divider();
            PanelQuizDiario.SuspendLayout();
            PanelHistoricoPreview.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuizDiario
            // 
            PanelQuizDiario.Back = Color.Transparent;
            PanelQuizDiario.BackColor = SystemColors.ControlLight;
            PanelQuizDiario.Controls.Add(ButtonQuizRush);
            PanelQuizDiario.Controls.Add(divider3);
            PanelQuizDiario.Controls.Add(ButtonQuizDiario);
            PanelQuizDiario.Controls.Add(divider1);
            PanelQuizDiario.Controls.Add(label1);
            PanelQuizDiario.Controls.Add(divider2);
            PanelQuizDiario.Dock = DockStyle.Right;
            PanelQuizDiario.Location = new Point(774, 0);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Padding = new Padding(10);
            PanelQuizDiario.Size = new Size(250, 720);
            PanelQuizDiario.TabIndex = 0;
            PanelQuizDiario.Text = "panel1";
            // 
            // ButtonQuizDiario
            // 
            ButtonQuizDiario.Dock = DockStyle.Top;
            ButtonQuizDiario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizDiario.Location = new Point(10, 141);
            ButtonQuizDiario.Name = "ButtonQuizDiario";
            ButtonQuizDiario.Size = new Size(230, 58);
            ButtonQuizDiario.TabIndex = 1;
            ButtonQuizDiario.Text = "Diário";
            ButtonQuizDiario.Click += ButtonQuizDiario_Click;
            // 
            // PanelHistoricoPreview
            // 
            PanelHistoricoPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelHistoricoPreview.AutoScroll = true;
            PanelHistoricoPreview.Controls.Add(LabelQuizzesPartidas);
            PanelHistoricoPreview.Location = new Point(13, 80);
            PanelHistoricoPreview.Name = "PanelHistoricoPreview";
            PanelHistoricoPreview.Size = new Size(750, 560);
            PanelHistoricoPreview.TabIndex = 1;
            PanelHistoricoPreview.Text = "panel2";
            // 
            // LabelQuizzesPartidas
            // 
            LabelQuizzesPartidas.BackColor = Color.Transparent;
            LabelQuizzesPartidas.Dock = DockStyle.Top;
            LabelQuizzesPartidas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizzesPartidas.Location = new Point(0, 0);
            LabelQuizzesPartidas.Name = "LabelQuizzesPartidas";
            LabelQuizzesPartidas.Size = new Size(750, 39);
            LabelQuizzesPartidas.TabIndex = 0;
            LabelQuizzesPartidas.Text = "Últimas 5 Partidas";
            LabelQuizzesPartidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider1
            // 
            divider1.ColorSplit = Color.Transparent;
            divider1.Dock = DockStyle.Top;
            divider1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider1.Location = new Point(10, 105);
            divider1.Name = "divider1";
            divider1.OrientationMargin = 0F;
            divider1.Size = new Size(230, 36);
            divider1.TabIndex = 8;
            divider1.Text = "";
            divider1.TextPadding = 0F;
            divider1.Thickness = 1F;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 61);
            label1.Name = "label1";
            label1.Size = new Size(230, 44);
            label1.TabIndex = 9;
            label1.Text = "Quizzes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divider2
            // 
            divider2.ColorSplit = Color.Transparent;
            divider2.Dock = DockStyle.Top;
            divider2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider2.Location = new Point(10, 10);
            divider2.Name = "divider2";
            divider2.OrientationMargin = 0F;
            divider2.Size = new Size(230, 51);
            divider2.TabIndex = 10;
            divider2.Text = "";
            divider2.TextPadding = 0F;
            divider2.Thickness = 1F;
            // 
            // ButtonQuizRush
            // 
            ButtonQuizRush.Dock = DockStyle.Top;
            ButtonQuizRush.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizRush.Location = new Point(10, 229);
            ButtonQuizRush.Name = "ButtonQuizRush";
            ButtonQuizRush.Size = new Size(230, 58);
            ButtonQuizRush.TabIndex = 11;
            ButtonQuizRush.Text = "Rush";
            // 
            // divider3
            // 
            divider3.ColorSplit = Color.SlateGray;
            divider3.Dock = DockStyle.Top;
            divider3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            divider3.Location = new Point(10, 199);
            divider3.Name = "divider3";
            divider3.OrientationMargin = 0F;
            divider3.Size = new Size(230, 30);
            divider3.TabIndex = 12;
            divider3.Text = "";
            divider3.TextPadding = 0F;
            divider3.Thickness = 1F;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(PanelHistoricoPreview);
            Controls.Add(PanelQuizDiario);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1024, 720);
            Load += PaginaPrincipal_Load;
            PanelQuizDiario.ResumeLayout(false);
            PanelHistoricoPreview.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel PanelQuizDiario;
        private AntdUI.Button ButtonQuizDiario;
        private AntdUI.Panel PanelHistoricoPreview;
        private AntdUI.Label LabelQuizzesPartidas;
        private AntdUI.Button ButtonQuizRush;
        private AntdUI.Divider divider3;
        private AntdUI.Divider divider1;
        private AntdUI.Label label1;
        private AntdUI.Divider divider2;
    }
}
