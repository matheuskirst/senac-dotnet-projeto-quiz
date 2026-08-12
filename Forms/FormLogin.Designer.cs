namespace SenacQuizApp.Forms
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginMainLayout = new TableLayoutPanel();
            SuspendLayout();
            // 
            // LoginMainLayout
            // 
            LoginMainLayout.ColumnCount = 3;
            LoginMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            LoginMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            LoginMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            LoginMainLayout.Dock = DockStyle.Fill;
            LoginMainLayout.Location = new Point(0, 0);
            LoginMainLayout.Name = "LoginMainLayout";
            LoginMainLayout.RowCount = 4;
            LoginMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            LoginMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            LoginMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LoginMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            LoginMainLayout.Size = new Size(622, 433);
            LoginMainLayout.TabIndex = 0;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 433);
            Controls.Add(LoginMainLayout);
            MinimumSize = new Size(640, 480);
            Name = "FormLogin";
            Text = "Quiz App - Login";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LoginMainLayout;
    }
}