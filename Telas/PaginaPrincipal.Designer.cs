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
            panel1 = new AntdUI.Panel();
            LabelQuizDiarioStatus = new AntdUI.Label();
            ButtonQuizDiario = new AntdUI.Button();
            LabelQuizDiario = new AntdUI.Label();
            panel2 = new AntdUI.Panel();
            CollapseQuizzesPartidas = new AntdUI.Collapse();
            LabelQuizzesPartidas = new AntdUI.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Back = Color.Transparent;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(LabelQuizDiarioStatus);
            panel1.Controls.Add(ButtonQuizDiario);
            panel1.Controls.Add(LabelQuizDiario);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(774, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(250, 720);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // LabelQuizDiarioStatus
            // 
            LabelQuizDiarioStatus.BackColor = Color.Transparent;
            LabelQuizDiarioStatus.Dock = DockStyle.Top;
            LabelQuizDiarioStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizDiarioStatus.Location = new Point(10, 58);
            LabelQuizDiarioStatus.Name = "LabelQuizDiarioStatus";
            LabelQuizDiarioStatus.Prefix = "Status: ";
            LabelQuizDiarioStatus.Size = new Size(230, 23);
            LabelQuizDiarioStatus.TabIndex = 2;
            LabelQuizDiarioStatus.Text = "*";
            // 
            // ButtonQuizDiario
            // 
            ButtonQuizDiario.Dock = DockStyle.Bottom;
            ButtonQuizDiario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizDiario.Location = new Point(10, 652);
            ButtonQuizDiario.Name = "ButtonQuizDiario";
            ButtonQuizDiario.Size = new Size(230, 58);
            ButtonQuizDiario.TabIndex = 1;
            ButtonQuizDiario.Text = "Abrir";
            ButtonQuizDiario.Click += ButtonQuizDiario_Click;
            // 
            // LabelQuizDiario
            // 
            LabelQuizDiario.BackColor = Color.Transparent;
            LabelQuizDiario.Dock = DockStyle.Top;
            LabelQuizDiario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizDiario.Location = new Point(10, 10);
            LabelQuizDiario.Name = "LabelQuizDiario";
            LabelQuizDiario.Size = new Size(230, 48);
            LabelQuizDiario.TabIndex = 0;
            LabelQuizDiario.Text = "Quiz Diário";
            LabelQuizDiario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Controls.Add(CollapseQuizzesPartidas);
            panel2.Controls.Add(LabelQuizzesPartidas);
            panel2.Location = new Point(172, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 560);
            panel2.TabIndex = 1;
            panel2.Text = "panel2";
            // 
            // CollapseQuizzesPartidas
            // 
            CollapseQuizzesPartidas.BackColor = Color.Transparent;
            CollapseQuizzesPartidas.Dock = DockStyle.Fill;
            CollapseQuizzesPartidas.Location = new Point(0, 23);
            CollapseQuizzesPartidas.Name = "CollapseQuizzesPartidas";
            CollapseQuizzesPartidas.ResizingLineThickness = 2F;
            CollapseQuizzesPartidas.Size = new Size(430, 537);
            CollapseQuizzesPartidas.TabIndex = 1;
            // 
            // LabelQuizzesPartidas
            // 
            LabelQuizzesPartidas.BackColor = Color.Transparent;
            LabelQuizzesPartidas.Dock = DockStyle.Top;
            LabelQuizzesPartidas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizzesPartidas.Location = new Point(0, 0);
            LabelQuizzesPartidas.Name = "LabelQuizzesPartidas";
            LabelQuizzesPartidas.Size = new Size(430, 23);
            LabelQuizzesPartidas.TabIndex = 0;
            LabelQuizzesPartidas.Text = "Últimas 5 Partidas";
            LabelQuizzesPartidas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1024, 720);
            Load += PaginaPrincipal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Label LabelQuizDiario;
        private AntdUI.Button ButtonQuizDiario;
        private AntdUI.Panel panel2;
        private AntdUI.Label LabelQuizzesPartidas;
        private AntdUI.Collapse CollapseQuizzesPartidas;
        private AntdUI.Label LabelQuizDiarioStatus;
    }
}
