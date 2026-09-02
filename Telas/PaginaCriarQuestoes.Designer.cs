namespace SenacQuizApp.Telas
{
    partial class PaginaCriarQuestoes
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
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            InputQuestaoEnunciado = new AntdUI.Input();
            tabs1 = new AntdUI.Tabs();
            TabPageVerdadeiroOuFalso = new AntdUI.TabPage();
            TabPageAlternativas = new AntdUI.TabPage();
            tabs1.SuspendLayout();
            SuspendLayout();
            // 
            // InputQuestaoEnunciado
            // 
            InputQuestaoEnunciado.Anchor = AnchorStyles.Top;
            InputQuestaoEnunciado.AutoScroll = true;
            InputQuestaoEnunciado.BackColor = Color.FromArgb(66, 66, 66);
            InputQuestaoEnunciado.ColorScheme = AntdUI.TAMode.Dark;
            InputQuestaoEnunciado.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputQuestaoEnunciado.Location = new Point(190, 0);
            InputQuestaoEnunciado.Multiline = true;
            InputQuestaoEnunciado.Name = "InputQuestaoEnunciado";
            InputQuestaoEnunciado.PrefixText = "";
            InputQuestaoEnunciado.ReadOnly = true;
            InputQuestaoEnunciado.Size = new Size(900, 175);
            InputQuestaoEnunciado.TabIndex = 3;
            // 
            // tabs1
            // 
            tabs1.ColorScheme = AntdUI.TAMode.Dark;
            tabs1.Controls.Add(TabPageVerdadeiroOuFalso);
            tabs1.Controls.Add(TabPageAlternativas);
            tabs1.Location = new Point(290, 232);
            tabs1.Name = "tabs1";
            tabs1.Pages.Add(TabPageVerdadeiroOuFalso);
            tabs1.Pages.Add(TabPageAlternativas);
            tabs1.Size = new Size(700, 300);
            tabs1.Style = styleLine1;
            tabs1.TabIndex = 4;
            tabs1.Text = "Abas";
            // 
            // TabPageVerdadeiroOuFalso
            // 
            TabPageVerdadeiroOuFalso.BackColor = Color.FromArgb(66, 66, 66);
            TabPageVerdadeiroOuFalso.ForeColor = SystemColors.Control;
            TabPageVerdadeiroOuFalso.Location = new Point(0, 30);
            TabPageVerdadeiroOuFalso.Name = "TabPageVerdadeiroOuFalso";
            TabPageVerdadeiroOuFalso.Size = new Size(700, 270);
            TabPageVerdadeiroOuFalso.TabIndex = 0;
            TabPageVerdadeiroOuFalso.Text = "Verdadeiro/Falso";
            // 
            // TabPageAlternativas
            // 
            TabPageAlternativas.BackColor = Color.FromArgb(66, 66, 66);
            TabPageAlternativas.ForeColor = SystemColors.Control;
            TabPageAlternativas.Location = new Point(0, 0);
            TabPageAlternativas.Name = "TabPageAlternativas";
            TabPageAlternativas.Size = new Size(0, 0);
            TabPageAlternativas.TabIndex = 1;
            TabPageAlternativas.Text = "Alternativas";
            // 
            // PaginaCriarQuestoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(tabs1);
            Controls.Add(InputQuestaoEnunciado);
            Name = "PaginaCriarQuestoes";
            Size = new Size(1280, 720);
            tabs1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Input InputQuestaoEnunciado;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage TabPageVerdadeiroOuFalso;
        private AntdUI.TabPage TabPageAlternativas;
    }
}
