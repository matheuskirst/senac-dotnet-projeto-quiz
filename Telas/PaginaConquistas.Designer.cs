namespace SenacQuizApp.Telas
{
    partial class PaginaConquistas
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
            PanelCentral = new AntdUI.Panel();
            PanelConquistas = new AntdUI.Panel();
            PanelBloqueadas = new FlowLayoutPanel();
            LabelBloqueadas = new AntdUI.Label();
            PanelDesbloqueadas = new FlowLayoutPanel();
            PanelCentral.SuspendLayout();
            PanelConquistas.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = Color.FromArgb(33, 33, 33);
            LabelTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTitulo.Dock = DockStyle.Top;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(0, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(850, 70);
            LabelTitulo.TabIndex = 5;
            LabelTitulo.Text = "Conquistas";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelCentral
            // 
            PanelCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PanelCentral.Back = Color.Transparent;
            PanelCentral.Controls.Add(PanelConquistas);
            PanelCentral.Controls.Add(LabelTitulo);
            PanelCentral.Location = new Point(215, 0);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(850, 720);
            PanelCentral.TabIndex = 8;
            PanelCentral.Text = "panel1";
            // 
            // PanelConquistas
            // 
            PanelConquistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelConquistas.AutoScroll = true;
            PanelConquistas.Back = Color.FromArgb(33, 33, 33);
            PanelConquistas.Controls.Add(PanelBloqueadas);
            PanelConquistas.Controls.Add(LabelBloqueadas);
            PanelConquistas.Controls.Add(PanelDesbloqueadas);
            PanelConquistas.Location = new Point(0, 76);
            PanelConquistas.Name = "PanelConquistas";
            PanelConquistas.Padding = new Padding(10);
            PanelConquistas.Radius = 0;
            PanelConquistas.Size = new Size(850, 641);
            PanelConquistas.TabIndex = 8;
            // 
            // PanelBloqueadas
            // 
            PanelBloqueadas.AutoSize = true;
            PanelBloqueadas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelBloqueadas.Dock = DockStyle.Top;
            PanelBloqueadas.FlowDirection = FlowDirection.TopDown;
            PanelBloqueadas.Location = new Point(10, 80);
            PanelBloqueadas.Name = "PanelBloqueadas";
            PanelBloqueadas.Size = new Size(830, 0);
            PanelBloqueadas.TabIndex = 7;
            PanelBloqueadas.WrapContents = false;
            // 
            // LabelBloqueadas
            // 
            LabelBloqueadas.BackColor = Color.FromArgb(33, 33, 33);
            LabelBloqueadas.ColorScheme = AntdUI.TAMode.Dark;
            LabelBloqueadas.Dock = DockStyle.Top;
            LabelBloqueadas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelBloqueadas.Location = new Point(10, 10);
            LabelBloqueadas.Name = "LabelBloqueadas";
            LabelBloqueadas.Size = new Size(830, 70);
            LabelBloqueadas.TabIndex = 6;
            LabelBloqueadas.Text = "Conquistas Bloqueadas";
            LabelBloqueadas.TextAlign = ContentAlignment.BottomLeft;
            // 
            // PanelDesbloqueadas
            // 
            PanelDesbloqueadas.AutoSize = true;
            PanelDesbloqueadas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelDesbloqueadas.Dock = DockStyle.Top;
            PanelDesbloqueadas.FlowDirection = FlowDirection.TopDown;
            PanelDesbloqueadas.Location = new Point(10, 10);
            PanelDesbloqueadas.Name = "PanelDesbloqueadas";
            PanelDesbloqueadas.Size = new Size(830, 0);
            PanelDesbloqueadas.TabIndex = 1;
            PanelDesbloqueadas.WrapContents = false;
            // 
            // PaginaConquistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(PanelCentral);
            Name = "PaginaConquistas";
            Size = new Size(1280, 720);
            Load += PaginaConquistas_Load;
            PanelCentral.ResumeLayout(false);
            PanelConquistas.ResumeLayout(false);
            PanelConquistas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Divider divider1;
        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel PanelCentral;
        private FlowLayoutPanel PanelDesbloqueadas;
        private AntdUI.Label LabelBloqueadas;
        private FlowLayoutPanel PanelBloqueadas;
        private AntdUI.Panel PanelConquistas;
    }
}
