namespace SenacQuizApp.Telas
{
    partial class PaginaInicial
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableLayoutPanelInicial = new TableLayoutPanel();
            TableLayoutPanelInicial2 = new TableLayoutPanel();
            LabelInicialTitulo = new AntdUI.Label();
            FlowLayoutPanelInicial = new FlowLayoutPanel();
            ButtonInicialLogin = new AntdUI.Button();
            ButtonInicialSignup = new AntdUI.Button();
            TableLayoutPanelInicial.SuspendLayout();
            TableLayoutPanelInicial2.SuspendLayout();
            FlowLayoutPanelInicial.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanelInicial
            // 
            TableLayoutPanelInicial.AutoSize = true;
            TableLayoutPanelInicial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutPanelInicial.BackColor = Color.FromArgb(58, 64, 70);
            TableLayoutPanelInicial.ColumnCount = 1;
            TableLayoutPanelInicial.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanelInicial.Controls.Add(TableLayoutPanelInicial2, 0, 0);
            TableLayoutPanelInicial.Dock = DockStyle.Fill;
            TableLayoutPanelInicial.Location = new Point(0, 0);
            TableLayoutPanelInicial.Name = "TableLayoutPanelInicial";
            TableLayoutPanelInicial.RowCount = 1;
            TableLayoutPanelInicial.RowStyles.Add(new RowStyle(SizeType.Absolute, 318F));
            TableLayoutPanelInicial.Size = new Size(1024, 720);
            TableLayoutPanelInicial.TabIndex = 0;
            // 
            // TableLayoutPanelInicial2
            // 
            TableLayoutPanelInicial2.Anchor = AnchorStyles.None;
            TableLayoutPanelInicial2.ColumnCount = 1;
            TableLayoutPanelInicial2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutPanelInicial2.Controls.Add(LabelInicialTitulo, 0, 0);
            TableLayoutPanelInicial2.Controls.Add(FlowLayoutPanelInicial, 0, 2);
            TableLayoutPanelInicial2.Location = new Point(294, 222);
            TableLayoutPanelInicial2.Name = "TableLayoutPanelInicial2";
            TableLayoutPanelInicial2.RowCount = 3;
            TableLayoutPanelInicial2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            TableLayoutPanelInicial2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanelInicial2.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            TableLayoutPanelInicial2.Size = new Size(436, 275);
            TableLayoutPanelInicial2.TabIndex = 0;
            // 
            // LabelInicialTitulo
            // 
            LabelInicialTitulo.ColorScheme = AntdUI.TAMode.Dark;
            LabelInicialTitulo.Dock = DockStyle.Fill;
            LabelInicialTitulo.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInicialTitulo.Location = new Point(3, 3);
            LabelInicialTitulo.Name = "LabelInicialTitulo";
            LabelInicialTitulo.Size = new Size(430, 46);
            LabelInicialTitulo.TabIndex = 2;
            LabelInicialTitulo.Text = "Entrar";
            LabelInicialTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // FlowLayoutPanelInicial
            // 
            FlowLayoutPanelInicial.Anchor = AnchorStyles.None;
            FlowLayoutPanelInicial.AutoSize = true;
            FlowLayoutPanelInicial.Controls.Add(ButtonInicialLogin);
            FlowLayoutPanelInicial.Controls.Add(ButtonInicialSignup);
            FlowLayoutPanelInicial.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanelInicial.Location = new Point(15, 99);
            FlowLayoutPanelInicial.Name = "FlowLayoutPanelInicial";
            FlowLayoutPanelInicial.Size = new Size(406, 152);
            FlowLayoutPanelInicial.TabIndex = 1;
            FlowLayoutPanelInicial.WrapContents = false;
            // 
            // ButtonInicialLogin
            // 
            ButtonInicialLogin.AutoToggle = true;
            ButtonInicialLogin.BackExtend = "";
            ButtonInicialLogin.ColorScheme = AntdUI.TAMode.Dark;
            ButtonInicialLogin.DefaultBack = Color.FromArgb(75, 150, 75);
            ButtonInicialLogin.Font = new Font("Tahoma", 14.25F);
            ButtonInicialLogin.Location = new Point(3, 3);
            ButtonInicialLogin.Name = "ButtonInicialLogin";
            ButtonInicialLogin.Size = new Size(400, 70);
            ButtonInicialLogin.TabIndex = 0;
            ButtonInicialLogin.Text = "Realizar Login";
            ButtonInicialLogin.Toggle = true;
            ButtonInicialLogin.Click += ButtonInicialLogin_Click;
            // 
            // ButtonInicialSignup
            // 
            ButtonInicialSignup.BackExtend = "";
            ButtonInicialSignup.ColorScheme = AntdUI.TAMode.Dark;
            ButtonInicialSignup.DefaultBack = Color.FromArgb(150, 75, 75);
            ButtonInicialSignup.DialogResult = DialogResult.OK;
            ButtonInicialSignup.Font = new Font("Tahoma", 14.25F);
            ButtonInicialSignup.Location = new Point(3, 79);
            ButtonInicialSignup.Name = "ButtonInicialSignup";
            ButtonInicialSignup.Size = new Size(400, 70);
            ButtonInicialSignup.TabIndex = 1;
            ButtonInicialSignup.Text = "Criar Conta";
            ButtonInicialSignup.Click += ButtonInicialSignup_Click;
            // 
            // PaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            Controls.Add(TableLayoutPanelInicial);
            MinimumSize = new Size(600, 400);
            Name = "PaginaInicial";
            Size = new Size(1024, 720);
            TableLayoutPanelInicial.ResumeLayout(false);
            TableLayoutPanelInicial2.ResumeLayout(false);
            TableLayoutPanelInicial2.PerformLayout();
            FlowLayoutPanelInicial.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableLayoutPanelInicial;
        private TableLayoutPanel TableLayoutPanelInicial2;
        private AntdUI.Label LabelInicialTitulo;
        private FlowLayoutPanel FlowLayoutPanelInicial;
        private AntdUI.Button ButtonInicialLogin;
        private AntdUI.Button ButtonInicialSignup;
    }
}
