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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarQuizRush));
            LabelQuizDiarioTitulo = new AntdUI.Label();
            PanelQuizDiario = new AntdUI.Panel();
            LabelTempo = new AntdUI.Label();
            LabelRecordeAcertos = new AntdUI.Label();
            LabelDataPartida = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            LabelDescricao = new AntdUI.Label();
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
            LabelQuizDiarioTitulo.Size = new Size(630, 64);
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
            PanelQuizDiario.Controls.Add(divider1);
            PanelQuizDiario.Controls.Add(LabelDescricao);
            PanelQuizDiario.Controls.Add(ButtonQuizRush);
            PanelQuizDiario.Controls.Add(LabelQuizDiarioTitulo);
            PanelQuizDiario.Location = new Point(187, 10);
            PanelQuizDiario.Name = "PanelQuizDiario";
            PanelQuizDiario.Padding = new Padding(10);
            PanelQuizDiario.Size = new Size(650, 700);
            PanelQuizDiario.TabIndex = 4;
            PanelQuizDiario.Text = "panel1";
            // 
            // LabelTempo
            // 
            LabelTempo.BackColor = Color.Transparent;
            LabelTempo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTempo.Dock = DockStyle.Top;
            LabelTempo.Font = new Font("Segoe UI", 15.75F);
            LabelTempo.Location = new Point(10, 384);
            LabelTempo.Name = "LabelTempo";
            LabelTempo.Prefix = "Tempo: ";
            LabelTempo.Size = new Size(630, 38);
            LabelTempo.TabIndex = 17;
            LabelTempo.Text = "---";
            // 
            // LabelRecordeAcertos
            // 
            LabelRecordeAcertos.BackColor = Color.Transparent;
            LabelRecordeAcertos.ColorScheme = AntdUI.TAMode.Dark;
            LabelRecordeAcertos.Dock = DockStyle.Top;
            LabelRecordeAcertos.Font = new Font("Segoe UI", 15.75F);
            LabelRecordeAcertos.Location = new Point(10, 346);
            LabelRecordeAcertos.Name = "LabelRecordeAcertos";
            LabelRecordeAcertos.Prefix = "Recorde: ";
            LabelRecordeAcertos.Size = new Size(630, 38);
            LabelRecordeAcertos.TabIndex = 16;
            LabelRecordeAcertos.Text = "---";
            // 
            // LabelDataPartida
            // 
            LabelDataPartida.BackColor = Color.Transparent;
            LabelDataPartida.ColorScheme = AntdUI.TAMode.Dark;
            LabelDataPartida.Dock = DockStyle.Top;
            LabelDataPartida.Font = new Font("Segoe UI", 15.75F);
            LabelDataPartida.Location = new Point(10, 308);
            LabelDataPartida.Name = "LabelDataPartida";
            LabelDataPartida.Prefix = "Última Partida: ";
            LabelDataPartida.Size = new Size(630, 38);
            LabelDataPartida.TabIndex = 15;
            LabelDataPartida.Text = "---";
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.ColorScheme = AntdUI.TAMode.Dark;
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(10, 257);
            divider1.Name = "divider1";
            divider1.Size = new Size(630, 51);
            divider1.TabIndex = 19;
            divider1.Text = "";
            divider1.TextPadding = 0F;
            divider1.Thickness = 1F;
            // 
            // LabelDescricao
            // 
            LabelDescricao.BackColor = Color.Transparent;
            LabelDescricao.ColorScheme = AntdUI.TAMode.Dark;
            LabelDescricao.Dock = DockStyle.Top;
            LabelDescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDescricao.Location = new Point(10, 74);
            LabelDescricao.Name = "LabelDescricao";
            LabelDescricao.Size = new Size(630, 183);
            LabelDescricao.TabIndex = 18;
            LabelDescricao.Text = resources.GetString("LabelDescricao.Text");
            // 
            // ButtonQuizRush
            // 
            ButtonQuizRush.BorderWidth = 1F;
            ButtonQuizRush.ColorScheme = AntdUI.TAMode.Dark;
            ButtonQuizRush.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonQuizRush.Location = new Point(221, 629);
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
        private AntdUI.Label LabelDescricao;
        private AntdUI.Divider divider1;
    }
}
