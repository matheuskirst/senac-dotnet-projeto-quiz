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
            LabelQuizDiarioStatus = new AntdUI.Label();
            ButtonQuizDiario = new AntdUI.Button();
            LabelQuizDiario = new AntdUI.Label();
            PanelHistoricoPreview = new AntdUI.Panel();
            LabelQuizzesPartidas = new AntdUI.Label();
            PanelQuizDiario.SuspendLayout();
            PanelHistoricoPreview.SuspendLayout();
            SuspendLayout();
            // 
            // PanelQuizDiario
            // 
            PanelQuizDiario.Back = Color.Transparent;
            PanelQuizDiario.BackColor = SystemColors.ControlLight;
            PanelQuizDiario.Controls.Add(LabelQuizDiarioStatus);
            PanelQuizDiario.Controls.Add(ButtonQuizDiario);
            PanelQuizDiario.Controls.Add(LabelQuizDiario);
            PanelQuizDiario.Dock = DockStyle.Right;
            PanelQuizDiario.Location = new Point(774, 0);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Padding = new Padding(10);
            PanelQuizDiario.Size = new Size(250, 720);
            PanelQuizDiario.TabIndex = 0;
            PanelQuizDiario.Text = "panel1";
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
        private AntdUI.Label LabelQuizDiario;
        private AntdUI.Button ButtonQuizDiario;
        private AntdUI.Panel PanelHistoricoPreview;
        private AntdUI.Label LabelQuizzesPartidas;
        private AntdUI.Label LabelQuizDiarioStatus;
    }
}
