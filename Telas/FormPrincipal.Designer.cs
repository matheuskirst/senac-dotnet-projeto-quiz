namespace SenacQuizApp.Telas
{
    partial class FormPrincipal
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
            panelContainer = new Panel();
            PageHeader = new AntdUI.PageHeader();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 30);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(854, 450);
            panelContainer.TabIndex = 3;
            // 
            // PageHeader
            // 
            PageHeader.BackColor = SystemColors.ControlLight;
            PageHeader.Dock = DockStyle.Top;
            PageHeader.Location = new Point(0, 0);
            PageHeader.Name = "PageHeader";
            PageHeader.ShowButton = true;
            PageHeader.Size = new Size(854, 30);
            PageHeader.TabIndex = 5;
            PageHeader.Text = "Quiz";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 480);
            Controls.Add(panelContainer);
            Controls.Add(PageHeader);
            MinimumSize = new Size(854, 480);
            Name = "FormPrincipal";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto Quiz";
            WindowState = FormWindowState.Maximized;
            Load += FormJanelaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContainer;
        private AntdUI.PageHeader PageHeader;
    }
}