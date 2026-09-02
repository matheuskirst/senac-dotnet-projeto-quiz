namespace SenacQuizApp.Telas.QuizRush
{
    partial class ResultadoQuizRush
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
            LabelTitulo = new AntdUI.Label();
            PanelQuizConclusao = new AntdUI.Panel();
            LabelPontuacaoTotal = new AntdUI.Label();
            LabelStreak = new AntdUI.Label();
            LabelTempo = new AntdUI.Label();
            LabelDataConcluido = new AntdUI.Label();
            LabelDataInicio = new AntdUI.Label();
            LabelSubTitulo = new AntdUI.Label();
            LabelMotivoEncerrado = new AntdUI.Label();
            PanelQuizConclusao.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = Color.FromArgb(18, 18, 18);
            LabelTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTitulo.Dock = DockStyle.Top;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(0, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(1024, 45);
            LabelTitulo.TabIndex = 1;
            LabelTitulo.Text = "Resultado do Quiz Rush";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelQuizConclusao
            // 
            PanelQuizConclusao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelQuizConclusao.Back = Color.FromArgb(33, 33, 33);
            PanelQuizConclusao.Controls.Add(LabelPontuacaoTotal);
            PanelQuizConclusao.Controls.Add(LabelStreak);
            PanelQuizConclusao.Controls.Add(LabelMotivoEncerrado);
            PanelQuizConclusao.Controls.Add(LabelTempo);
            PanelQuizConclusao.Controls.Add(LabelDataConcluido);
            PanelQuizConclusao.Controls.Add(LabelDataInicio);
            PanelQuizConclusao.Controls.Add(LabelSubTitulo);
            PanelQuizConclusao.Location = new Point(262, 65);
            PanelQuizConclusao.Name = "PanelQuizConclusao";
            PanelQuizConclusao.Padding = new Padding(10);
            PanelQuizConclusao.Radius = 0;
            PanelQuizConclusao.Size = new Size(500, 636);
            PanelQuizConclusao.TabIndex = 2;
            PanelQuizConclusao.Text = "panel1";
            // 
            // LabelPontuacaoTotal
            // 
            LabelPontuacaoTotal.BackColor = Color.Transparent;
            LabelPontuacaoTotal.ColorScheme = AntdUI.TAMode.Dark;
            LabelPontuacaoTotal.Dock = DockStyle.Top;
            LabelPontuacaoTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPontuacaoTotal.Location = new Point(10, 238);
            LabelPontuacaoTotal.Name = "LabelPontuacaoTotal";
            LabelPontuacaoTotal.Prefix = "Pontuação Total: ";
            LabelPontuacaoTotal.Size = new Size(480, 38);
            LabelPontuacaoTotal.TabIndex = 14;
            LabelPontuacaoTotal.Text = "*";
            // 
            // LabelStreak
            // 
            LabelStreak.BackColor = Color.Transparent;
            LabelStreak.ColorScheme = AntdUI.TAMode.Dark;
            LabelStreak.Dock = DockStyle.Top;
            LabelStreak.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelStreak.Location = new Point(10, 200);
            LabelStreak.Name = "LabelStreak";
            LabelStreak.Prefix = "Streak: ";
            LabelStreak.Size = new Size(480, 38);
            LabelStreak.TabIndex = 12;
            LabelStreak.Text = "*";
            // 
            // LabelTempo
            // 
            LabelTempo.BackColor = Color.Transparent;
            LabelTempo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTempo.Dock = DockStyle.Top;
            LabelTempo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTempo.Location = new Point(10, 124);
            LabelTempo.Name = "LabelTempo";
            LabelTempo.Prefix = "Tempo: ";
            LabelTempo.Size = new Size(480, 38);
            LabelTempo.TabIndex = 11;
            LabelTempo.Text = "*";
            // 
            // LabelDataConcluido
            // 
            LabelDataConcluido.BackColor = Color.Transparent;
            LabelDataConcluido.ColorScheme = AntdUI.TAMode.Dark;
            LabelDataConcluido.Dock = DockStyle.Top;
            LabelDataConcluido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataConcluido.Location = new Point(10, 86);
            LabelDataConcluido.Name = "LabelDataConcluido";
            LabelDataConcluido.Prefix = "Data Concluido: ";
            LabelDataConcluido.Size = new Size(480, 38);
            LabelDataConcluido.TabIndex = 10;
            LabelDataConcluido.Text = "*";
            // 
            // LabelDataInicio
            // 
            LabelDataInicio.BackColor = Color.Transparent;
            LabelDataInicio.ColorScheme = AntdUI.TAMode.Dark;
            LabelDataInicio.Dock = DockStyle.Top;
            LabelDataInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataInicio.Location = new Point(10, 48);
            LabelDataInicio.Name = "LabelDataInicio";
            LabelDataInicio.Prefix = "Data Iniciado: ";
            LabelDataInicio.Size = new Size(480, 38);
            LabelDataInicio.TabIndex = 8;
            LabelDataInicio.Text = "*";
            // 
            // LabelSubTitulo
            // 
            LabelSubTitulo.BackColor = Color.Transparent;
            LabelSubTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelSubTitulo.Dock = DockStyle.Top;
            LabelSubTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelSubTitulo.Location = new Point(10, 10);
            LabelSubTitulo.Name = "LabelSubTitulo";
            LabelSubTitulo.Prefix = "";
            LabelSubTitulo.Size = new Size(480, 38);
            LabelSubTitulo.TabIndex = 15;
            LabelSubTitulo.Text = "Estátisticas";
            LabelSubTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelMotivoEncerrado
            // 
            LabelMotivoEncerrado.BackColor = Color.Transparent;
            LabelMotivoEncerrado.ColorScheme = AntdUI.TAMode.Dark;
            LabelMotivoEncerrado.Dock = DockStyle.Top;
            LabelMotivoEncerrado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelMotivoEncerrado.Location = new Point(10, 162);
            LabelMotivoEncerrado.Name = "LabelMotivoEncerrado";
            LabelMotivoEncerrado.Prefix = "Motivo de encerramento:  ";
            LabelMotivoEncerrado.Size = new Size(480, 38);
            LabelMotivoEncerrado.TabIndex = 16;
            LabelMotivoEncerrado.Text = "*";
            // 
            // ResultadoQuizRush
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelQuizConclusao);
            Controls.Add(LabelTitulo);
            Name = "ResultadoQuizRush";
            Size = new Size(1024, 720);
            Load += ResultadoQuizRush_Load;
            PanelQuizConclusao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel PanelQuizConclusao;
        private AntdUI.Label LabelPontuacaoTotal;
        private AntdUI.Label LabelStreak;
        private AntdUI.Label LabelTempo;
        private AntdUI.Label LabelDataConcluido;
        private AntdUI.Label LabelDataInicio;
        private AntdUI.Label LabelSubTitulo;
        private AntdUI.Label LabelMotivoEncerrado;
    }
}
