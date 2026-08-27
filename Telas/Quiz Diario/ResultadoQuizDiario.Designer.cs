namespace SenacQuizApp.Telas.Quiz_Diario
{
    partial class ResultadoQuizDiario
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
            LabelTotalAcertos = new AntdUI.Label();
            LabelTotalQuestoes = new AntdUI.Label();
            LabelTempoDeConclusao = new AntdUI.Label();
            LabelDataConcluido = new AntdUI.Label();
            LabelDataInicio = new AntdUI.Label();
            LabelSubTitulo = new AntdUI.Label();
            PanelQuizResultados = new AntdUI.Panel();
            CollapsePanel = new AntdUI.Panel();
            CollapseQuestoes = new AntdUI.Collapse();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            PanelQuizConclusao.SuspendLayout();
            PanelQuizResultados.SuspendLayout();
            CollapsePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = Color.White;
            LabelTitulo.Dock = DockStyle.Top;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(0, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(1024, 45);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Resultado do Quiz";
            LabelTitulo.TextAlign = ContentAlignment.BottomCenter;
            // 
            // PanelQuizConclusao
            // 
            PanelQuizConclusao.Back = Color.Transparent;
            PanelQuizConclusao.BackColor = Color.GhostWhite;
            PanelQuizConclusao.BorderColor = Color.Black;
            PanelQuizConclusao.BorderWidth = 1F;
            PanelQuizConclusao.Controls.Add(LabelPontuacaoTotal);
            PanelQuizConclusao.Controls.Add(LabelTotalAcertos);
            PanelQuizConclusao.Controls.Add(LabelTotalQuestoes);
            PanelQuizConclusao.Controls.Add(LabelTempoDeConclusao);
            PanelQuizConclusao.Controls.Add(LabelDataConcluido);
            PanelQuizConclusao.Controls.Add(LabelDataInicio);
            PanelQuizConclusao.Controls.Add(LabelSubTitulo);
            PanelQuizConclusao.Dock = DockStyle.Left;
            PanelQuizConclusao.Location = new Point(0, 45);
            PanelQuizConclusao.Name = "PanelQuizConclusao";
            PanelQuizConclusao.Padding = new Padding(10);
            PanelQuizConclusao.Size = new Size(350, 675);
            PanelQuizConclusao.TabIndex = 1;
            PanelQuizConclusao.Text = "panel1";
            // 
            // LabelPontuacaoTotal
            // 
            LabelPontuacaoTotal.BackColor = Color.Transparent;
            LabelPontuacaoTotal.Dock = DockStyle.Top;
            LabelPontuacaoTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPontuacaoTotal.Location = new Point(11, 239);
            LabelPontuacaoTotal.Name = "LabelPontuacaoTotal";
            LabelPontuacaoTotal.Prefix = "Pontuação Total: ";
            LabelPontuacaoTotal.Size = new Size(328, 38);
            LabelPontuacaoTotal.TabIndex = 14;
            LabelPontuacaoTotal.Text = "*";
            // 
            // LabelTotalAcertos
            // 
            LabelTotalAcertos.BackColor = Color.Transparent;
            LabelTotalAcertos.Dock = DockStyle.Top;
            LabelTotalAcertos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTotalAcertos.Location = new Point(11, 201);
            LabelTotalAcertos.Name = "LabelTotalAcertos";
            LabelTotalAcertos.Prefix = "Total Acertos ";
            LabelTotalAcertos.Size = new Size(328, 38);
            LabelTotalAcertos.TabIndex = 13;
            LabelTotalAcertos.Text = "*";
            // 
            // LabelTotalQuestoes
            // 
            LabelTotalQuestoes.BackColor = Color.Transparent;
            LabelTotalQuestoes.Dock = DockStyle.Top;
            LabelTotalQuestoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTotalQuestoes.Location = new Point(11, 163);
            LabelTotalQuestoes.Name = "LabelTotalQuestoes";
            LabelTotalQuestoes.Prefix = "Total Questões: ";
            LabelTotalQuestoes.Size = new Size(328, 38);
            LabelTotalQuestoes.TabIndex = 12;
            LabelTotalQuestoes.Text = "*";
            // 
            // LabelTempoDeConclusao
            // 
            LabelTempoDeConclusao.BackColor = Color.Transparent;
            LabelTempoDeConclusao.Dock = DockStyle.Top;
            LabelTempoDeConclusao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTempoDeConclusao.Location = new Point(11, 125);
            LabelTempoDeConclusao.Name = "LabelTempoDeConclusao";
            LabelTempoDeConclusao.Prefix = "Tempo de Conclusão: ";
            LabelTempoDeConclusao.Size = new Size(328, 38);
            LabelTempoDeConclusao.TabIndex = 11;
            LabelTempoDeConclusao.Text = "*";
            // 
            // LabelDataConcluido
            // 
            LabelDataConcluido.BackColor = Color.Transparent;
            LabelDataConcluido.Dock = DockStyle.Top;
            LabelDataConcluido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataConcluido.Location = new Point(11, 87);
            LabelDataConcluido.Name = "LabelDataConcluido";
            LabelDataConcluido.Prefix = "Data Concluido: ";
            LabelDataConcluido.Size = new Size(328, 38);
            LabelDataConcluido.TabIndex = 10;
            LabelDataConcluido.Text = "*";
            // 
            // LabelDataInicio
            // 
            LabelDataInicio.BackColor = Color.Transparent;
            LabelDataInicio.Dock = DockStyle.Top;
            LabelDataInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataInicio.Location = new Point(11, 49);
            LabelDataInicio.Name = "LabelDataInicio";
            LabelDataInicio.Prefix = "Data Iniciado: ";
            LabelDataInicio.Size = new Size(328, 38);
            LabelDataInicio.TabIndex = 8;
            LabelDataInicio.Text = "*";
            // 
            // LabelSubTitulo
            // 
            LabelSubTitulo.BackColor = Color.Transparent;
            LabelSubTitulo.Dock = DockStyle.Top;
            LabelSubTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelSubTitulo.Location = new Point(11, 11);
            LabelSubTitulo.Name = "LabelSubTitulo";
            LabelSubTitulo.Prefix = "";
            LabelSubTitulo.Size = new Size(328, 38);
            LabelSubTitulo.TabIndex = 15;
            LabelSubTitulo.Text = "Estátisticas";
            LabelSubTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelQuizResultados
            // 
            PanelQuizResultados.Back = Color.Transparent;
            PanelQuizResultados.BackColor = Color.White;
            PanelQuizResultados.Controls.Add(CollapsePanel);
            PanelQuizResultados.Dock = DockStyle.Fill;
            PanelQuizResultados.Location = new Point(350, 45);
            PanelQuizResultados.Name = "PanelQuizResultados";
            PanelQuizResultados.Padding = new Padding(100);
            PanelQuizResultados.Size = new Size(674, 675);
            PanelQuizResultados.TabIndex = 2;
            PanelQuizResultados.Text = "panel1";
            // 
            // CollapsePanel
            // 
            CollapsePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CollapsePanel.AutoScroll = true;
            CollapsePanel.Back = Color.Transparent;
            CollapsePanel.BackColor = Color.WhiteSmoke;
            CollapsePanel.Controls.Add(CollapseQuestoes);
            CollapsePanel.Location = new Point(95, 49);
            CollapsePanel.Name = "CollapsePanel";
            CollapsePanel.Size = new Size(489, 589);
            CollapsePanel.TabIndex = 0;
            CollapsePanel.Text = "panel1";
            // 
            // CollapseQuestoes
            // 
            CollapseQuestoes.Dock = DockStyle.Fill;
            CollapseQuestoes.Location = new Point(0, 0);
            CollapseQuestoes.Name = "CollapseQuestoes";
            CollapseQuestoes.ResizingLineThickness = 2F;
            CollapseQuestoes.Size = new Size(489, 589);
            CollapseQuestoes.TabIndex = 4;
            CollapseQuestoes.Text = "collapse1";
            // 
            // button1
            // 
            button1.Location = new Point(126, 109);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            // 
            // button2
            // 
            button2.Location = new Point(152, 89);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            // 
            // PainelResultadoQuizDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelQuizResultados);
            Controls.Add(PanelQuizConclusao);
            Controls.Add(LabelTitulo);
            Name = "PainelResultadoQuizDiario";
            Size = new Size(1024, 720);
            Load += PainelResultado_Load;
            PanelQuizConclusao.ResumeLayout(false);
            PanelQuizResultados.ResumeLayout(false);
            CollapsePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel PanelQuizConclusao;
        private AntdUI.Label LabelPontuacaoTotal;
        private AntdUI.Label LabelTotalAcertos;
        private AntdUI.Label LabelTotalQuestoes;
        private AntdUI.Label LabelTempoDeConclusao;
        private AntdUI.Label LabelDataConcluido;
        private AntdUI.Label LabelDataInicio;
        private AntdUI.Label LabelSubTitulo;
        private AntdUI.Panel PanelQuizResultados;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Panel CollapsePanel;
        private AntdUI.Collapse CollapseQuestoes;
    }
}
