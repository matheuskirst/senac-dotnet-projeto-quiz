namespace SenacQuizApp.Telas.Componentes.Quiz
{
    partial class PainelResultado
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
            PanelResultadoCentral = new TableLayoutPanel();
            LabelTitulo = new AntdUI.Label();
            stackPanel1 = new AntdUI.StackPanel();
            LabelPontuacaoTotal = new AntdUI.Label();
            LabelTotalAcertos = new AntdUI.Label();
            LabelTotalQuestoes = new AntdUI.Label();
            LabelTempoDeConclusao = new AntdUI.Label();
            LabelDataConcluido = new AntdUI.Label();
            LabelDataExibido = new AntdUI.Label();
            LabelDataInicio = new AntdUI.Label();
            PanelResultadoCentral.SuspendLayout();
            stackPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelResultadoCentral
            // 
            PanelResultadoCentral.ColumnCount = 3;
            PanelResultadoCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelResultadoCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            PanelResultadoCentral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            PanelResultadoCentral.Controls.Add(LabelTitulo, 1, 0);
            PanelResultadoCentral.Controls.Add(stackPanel1, 1, 1);
            PanelResultadoCentral.Dock = DockStyle.Fill;
            PanelResultadoCentral.Location = new Point(0, 0);
            PanelResultadoCentral.Margin = new Padding(3, 2, 3, 2);
            PanelResultadoCentral.Name = "PanelResultadoCentral";
            PanelResultadoCentral.RowCount = 3;
            PanelResultadoCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            PanelResultadoCentral.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            PanelResultadoCentral.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            PanelResultadoCentral.Size = new Size(1035, 688);
            PanelResultadoCentral.TabIndex = 4;
            // 
            // LabelTitulo
            // 
            LabelTitulo.Dock = DockStyle.Fill;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(54, 3);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(925, 153);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Resultado";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stackPanel1
            // 
            stackPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            stackPanel1.Controls.Add(LabelPontuacaoTotal);
            stackPanel1.Controls.Add(LabelTotalAcertos);
            stackPanel1.Controls.Add(LabelTotalQuestoes);
            stackPanel1.Controls.Add(LabelTempoDeConclusao);
            stackPanel1.Controls.Add(LabelDataConcluido);
            stackPanel1.Controls.Add(LabelDataExibido);
            stackPanel1.Controls.Add(LabelDataInicio);
            stackPanel1.Location = new Point(316, 162);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(400, 472);
            stackPanel1.TabIndex = 1;
            stackPanel1.Text = "stackPanel1";
            stackPanel1.Vertical = true;
            // 
            // LabelPontuacaoTotal
            // 
            LabelPontuacaoTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelPontuacaoTotal.Location = new Point(3, 267);
            LabelPontuacaoTotal.Name = "LabelPontuacaoTotal";
            LabelPontuacaoTotal.Prefix = "Pontuacao Total: ";
            LabelPontuacaoTotal.Size = new Size(394, 38);
            LabelPontuacaoTotal.TabIndex = 7;
            LabelPontuacaoTotal.Text = "*";
            // 
            // LabelTotalAcertos
            // 
            LabelTotalAcertos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTotalAcertos.Location = new Point(3, 223);
            LabelTotalAcertos.Name = "LabelTotalAcertos";
            LabelTotalAcertos.Prefix = "Total Acertos ";
            LabelTotalAcertos.Size = new Size(394, 38);
            LabelTotalAcertos.TabIndex = 6;
            LabelTotalAcertos.Text = "*";
            // 
            // LabelTotalQuestoes
            // 
            LabelTotalQuestoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTotalQuestoes.Location = new Point(3, 179);
            LabelTotalQuestoes.Name = "LabelTotalQuestoes";
            LabelTotalQuestoes.Prefix = "Total Questões: ";
            LabelTotalQuestoes.Size = new Size(394, 38);
            LabelTotalQuestoes.TabIndex = 5;
            LabelTotalQuestoes.Text = "*";
            // 
            // LabelTempoDeConclusao
            // 
            LabelTempoDeConclusao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTempoDeConclusao.Location = new Point(3, 135);
            LabelTempoDeConclusao.Name = "LabelTempoDeConclusao";
            LabelTempoDeConclusao.Prefix = "Tempo de Conclusão: ";
            LabelTempoDeConclusao.Size = new Size(394, 38);
            LabelTempoDeConclusao.TabIndex = 4;
            LabelTempoDeConclusao.Text = "*";
            // 
            // LabelDataConcluido
            // 
            LabelDataConcluido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataConcluido.Location = new Point(3, 91);
            LabelDataConcluido.Name = "LabelDataConcluido";
            LabelDataConcluido.Prefix = "Data Concluido: ";
            LabelDataConcluido.Size = new Size(394, 38);
            LabelDataConcluido.TabIndex = 3;
            LabelDataConcluido.Text = "*";
            // 
            // LabelDataExibido
            // 
            LabelDataExibido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataExibido.Location = new Point(3, 47);
            LabelDataExibido.Name = "LabelDataExibido";
            LabelDataExibido.Prefix = "Data Exibido: ";
            LabelDataExibido.Size = new Size(394, 38);
            LabelDataExibido.TabIndex = 2;
            LabelDataExibido.Text = "*";
            // 
            // LabelDataInicio
            // 
            LabelDataInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDataInicio.Location = new Point(3, 3);
            LabelDataInicio.Name = "LabelDataInicio";
            LabelDataInicio.Prefix = "Data Iniciado: ";
            LabelDataInicio.Size = new Size(394, 38);
            LabelDataInicio.TabIndex = 1;
            LabelDataInicio.Text = "*";
            // 
            // PainelResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelResultadoCentral);
            Name = "PainelResultado";
            Size = new Size(1035, 688);
            Load += PainelResultado_Load;
            PanelResultadoCentral.ResumeLayout(false);
            stackPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelResultadoCentral;
        private AntdUI.Label LabelTitulo;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Label LabelDataInicio;
        private AntdUI.Label LabelTempoDeConclusao;
        private AntdUI.Label LabelDataConcluido;
        private AntdUI.Label LabelDataExibido;
        private AntdUI.Label LabelTotalQuestoes;
        private AntdUI.Label LabelTotalAcertos;
        private AntdUI.Label LabelPontuacaoTotal;
    }
}
