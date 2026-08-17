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
            TableLayoutPanelPrincipal = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            stackPanel1 = new AntdUI.StackPanel();
            ButtonPrincipalSair = new AntdUI.Button();
            stackPanel2 = new AntdUI.StackPanel();
            button2 = new AntdUI.Button();
            TableLayoutPanelPrincipal.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            stackPanel1.SuspendLayout();
            stackPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelPrincipal
            // 
            TableLayoutPanelPrincipal.BackColor = Color.Transparent;
            TableLayoutPanelPrincipal.ColumnCount = 3;
            TableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.Controls.Add(tableLayoutPanel1, 1, 1);
            TableLayoutPanelPrincipal.Dock = DockStyle.Fill;
            TableLayoutPanelPrincipal.Location = new Point(0, 0);
            TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal";
            TableLayoutPanelPrincipal.RowCount = 5;
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            TableLayoutPanelPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutPanelPrincipal.Size = new Size(1024, 720);
            TableLayoutPanelPrincipal.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(stackPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(stackPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.No;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(984, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // stackPanel1
            // 
            stackPanel1.Controls.Add(ButtonPrincipalSair);
            stackPanel1.Dock = DockStyle.Fill;
            stackPanel1.Location = new Point(0, 0);
            stackPanel1.Margin = new Padding(0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Size = new Size(492, 50);
            stackPanel1.TabIndex = 0;
            stackPanel1.Text = "stackPanel1";
            // 
            // ButtonPrincipalSair
            // 
            ButtonPrincipalSair.DefaultBack = Color.Ivory;
            ButtonPrincipalSair.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPrincipalSair.Location = new Point(3, 3);
            ButtonPrincipalSair.Name = "ButtonPrincipalSair";
            ButtonPrincipalSair.Radius = 4;
            ButtonPrincipalSair.Size = new Size(100, 44);
            ButtonPrincipalSair.TabIndex = 1;
            ButtonPrincipalSair.Text = "Sair";
            ButtonPrincipalSair.Click += ButtonPrincipalSair_Click;
            // 
            // stackPanel2
            // 
            stackPanel2.Controls.Add(button2);
            stackPanel2.Dock = DockStyle.Fill;
            stackPanel2.Location = new Point(492, 0);
            stackPanel2.Margin = new Padding(0);
            stackPanel2.Name = "stackPanel2";
            stackPanel2.RightToLeft = RightToLeft.Yes;
            stackPanel2.Size = new Size(492, 50);
            stackPanel2.TabIndex = 1;
            stackPanel2.Text = "stackPanel2";
            // 
            // button2
            // 
            button2.DefaultBack = Color.Wheat;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(389, 3);
            button2.Name = "button2";
            button2.Size = new Size(100, 44);
            button2.TabIndex = 1;
            button2.Text = "Perfil";
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(TableLayoutPanelPrincipal);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(1024, 720);
            TableLayoutPanelPrincipal.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            stackPanel1.ResumeLayout(false);
            stackPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelPrincipal;
        private TableLayoutPanel tableLayoutPanel1;
        private AntdUI.StackPanel stackPanel1;
        private AntdUI.Button ButtonPrincipalSair;
        private AntdUI.StackPanel stackPanel2;
        private AntdUI.Button button2;
    }
}
