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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(272, 76);
            button1.Name = "button1";
            button1.Size = new Size(354, 70);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Quiz";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(272, 187);
            button2.Name = "button2";
            button2.Size = new Size(355, 66);
            button2.TabIndex = 1;
            button2.Text = "Ver ranking";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSalmon;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(272, 285);
            button3.Name = "button3";
            button3.Size = new Size(354, 69);
            button3.TabIndex = 2;
            button3.Text = "Consultar histórico";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Coral;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(272, 401);
            button4.Name = "button4";
            button4.Size = new Size(354, 70);
            button4.TabIndex = 3;
            button4.Text = "Ver perfil";
            button4.UseVisualStyleBackColor = false;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "PaginaPrincipal";
            Size = new Size(938, 664);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
