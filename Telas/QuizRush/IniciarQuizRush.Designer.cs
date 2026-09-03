namespace SenacQuizApp.Telas.QuizRush
{
    partial class IniciarQuizRush
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
            LabelQuizDiarioTitulo = new AntdUI.Label();
            PanelQuizDiario = new AntdUI.Panel();
            LabelTempo = new AntdUI.Label();
            LabelRecordeAcertos = new AntdUI.Label();
            LabelDataPartida = new AntdUI.Label();
            ButtonQuizRush = new AntdUI.Button();
            PanelQuizDiario.SuspendLayout();
            SuspendLayout();
            // 
            // LabelQuizDiarioTitulo
            // 
            LabelQuizDiarioTitulo.BackColor = Color.Transparent;
            LabelQuizDiarioTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelQuizDiarioTitulo.Dock = DockStyle.Top;
            LabelQuizDiarioTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelQuizDiarioTitulo.Location = new Point(10, 10);
            LabelQuizDiarioTitulo.Name = "LabelQuizDiarioTitulo";
            LabelQuizDiarioTitulo.Size = new Size(380, 64);
            LabelQuizDiarioTitulo.TabIndex = 2;
            LabelQuizDiarioTitulo.Text = "Quiz Rush";
            LabelQuizDiarioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelQuizDiario
            // 
            PanelQuizDiario.Anchor = AnchorStyles.None;
            PanelQuizDiario.Back = Color.FromArgb(33, 33, 33);
            PanelQuizDiario.Controls.Add(LabelTempo);
            PanelQuizDiario.Controls.Add(LabelRecordeAcertos);
            PanelQuizDiario.Controls.Add(LabelDataPartida);
            PanelQuizDiario.Controls.Add(ButtonQuizRush);
            PanelQuizDiario.Controls.Add(LabelQuizDiarioTitulo);
            PanelQuizDiario.Location = new Point(312, 110);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Padding = new Padding(10);
            PanelQuizDiario.Size = new Size(400, 500);
            PanelQuizDiario.TabIndex = 4;
            PanelQuizDiario.Text = "panel1";
            // 
            // LabelTempo
            // 
            LabelTempo.BackColor = Color.Transparent;
            LabelTempo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTempo.Dock = DockStyle.Top;
            LabelTempo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTempo.Location = new Point(10, 150);
            LabelTempo.Name = "LabelTempo";
            LabelTempo.Prefix = "Tempo: ";
            LabelTempo.Size = new Size(380, 38);
            LabelTempo.TabIndex = 17;
            LabelTempo.Text = "---";
            // 
            // LabelRecordeAcertos
            // 
            LabelRecordeAcertos.BackColor = Color.Transparent;
            LabelRecordeAcertos.ColorScheme = AntdUI.TAMode.Dark;
            LabelRecordeAcertos.Dock = DockStyle.Top;
            LabelRecordeAcertos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelRecordeAcertos.Location = new Point(10, 112);
            LabelRecordeAcertos.Name = "LabelRecordeAcertos";
            LabelRecordeAcertos.Prefix = "Recorde: ";
            LabelRecordeAcertos.Size = new Size(380, 38);
            LabelRecordeAcertos.TabIndex = 16;
            LabelRecordeAcertos.Text = "---";
            // 
            // LabelDataPartida
            // 
            LabelDataPartida.BackColor = Color.Transparent;
            LabelDataPartida.ColorScheme = AntdUI.TAMode.Dark;
            LabelDataPartida.Dock = DockStyle.Top;
            LabelDataPartida.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataPartida.Location = new Point(10, 74);
            LabelDataPartida.Name = "LabelDataPartida";
            LabelDataPartida.Prefix = "Última Partida: ";
            LabelDataPartida.Size = new Size(380, 38);
            LabelDataPartida.TabIndex = 15;
            LabelDataPartida.Text = "---";
            // 
            // ButtonQuizRush
            // 
            ButtonQuizRush.BorderWidth = 1F;
            ButtonQuizRush.ColorScheme = AntdUI.TAMode.Dark;
            ButtonQuizRush.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizRush.Location = new Point(121, 429);
            ButtonQuizRush.Name = "ButtonQuizRush";
            ButtonQuizRush.Size = new Size(158, 58);
            ButtonQuizRush.TabIndex = 5;
            ButtonQuizRush.Text = "Iniciar";
            ButtonQuizRush.Click += ButtonQuizRush_Click;
            // 
            // IniciarQuizRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelQuizDiario);
            Name = "IniciarQuizRush";
            Size = new Size(1024, 720);
            Load += IniciarQuizRush_Load;
            PanelQuizDiario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelQuizDiarioTitulo;
        private AntdUI.Panel PanelQuizDiario;
        private AntdUI.Button ButtonQuizRush;
        private AntdUI.Label LabelTempo;
        private AntdUI.Label LabelRecordeAcertos;
        private AntdUI.Label LabelDataPartida;
    }
}
