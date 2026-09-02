namespace SenacQuizApp.Telas
{
    partial class PaginaConquista
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
            stackPanel1 = new AntdUI.StackPanel();
            divider1 = new AntdUI.Divider();
            LabelTitulo = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            panel2 = new AntdUI.Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // stackPanel1
            // 
            stackPanel1.BackColor = Color.FromArgb(33, 33, 33);
            stackPanel1.Location = new Point(240, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(800, 613);
            stackPanel1.TabIndex = 1;
            stackPanel1.Text = "stackPanel1";
            // 
            // divider1
            // 
            divider1.BackColor = Color.Transparent;
            divider1.ColorScheme = AntdUI.TAMode.Dark;
            divider1.Dock = DockStyle.Top;
            divider1.Location = new Point(0, 64);
            divider1.Name = "divider1";
            divider1.OrientationMargin = 0F;
            divider1.Size = new Size(1280, 18);
            divider1.TabIndex = 6;
            divider1.Text = "";
            divider1.TextPadding = 0F;
            divider1.Thickness = 5F;
            // 
            // LabelTitulo
            // 
            LabelTitulo.BackColor = Color.Transparent;
            LabelTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelTitulo.Dock = DockStyle.Top;
            LabelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(0, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(1280, 64);
            LabelTitulo.TabIndex = 5;
            LabelTitulo.Text = "Conquista";
            LabelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Back = Color.FromArgb(33, 33, 33);
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(240, 1);
            panel1.Name = "panel1";
            panel1.Radius = 0;
            panel1.Size = new Size(800, 21);
            panel1.TabIndex = 7;
            panel1.Text = "panel1";
            // 
            // panel2
            // 
            panel2.Back = Color.FromArgb(50, 50, 50);
            panel2.Controls.Add(stackPanel1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(3, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(1274, 635);
            panel2.TabIndex = 8;
            panel2.Text = "panel2";
            // 
            // PaginaConquista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(panel2);
            Controls.Add(divider1);
            Controls.Add(LabelTitulo);
            Name = "PaginaConquista";
            Size = new Size(1280, 720);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Divider divider1;
        private AntdUI.Label LabelTitulo;
        private AntdUI.Panel panel1;
        private AntdUI.Panel panel2;
    }
}
