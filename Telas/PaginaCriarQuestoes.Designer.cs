namespace SenacQuizApp.Telas
{
    partial class PaginaCriarQuestoes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            InputQuestaoEnunciado = new AntdUI.Input();
            tabs1 = new AntdUI.Tabs();
            TabPageVerdadeiroOuFalso = new AntdUI.TabPage();
            btnSalvarVF = new AntdUI.Button();
            radioFalso = new AntdUI.Radio();
            radioVerdadeiro = new AntdUI.Radio();
            TabPageAlternativas = new AntdUI.TabPage();
            btnSalvarAlternativas = new AntdUI.Button();
            radioAlt4 = new AntdUI.Radio();
            radioAlt3 = new AntdUI.Radio();
            radioAlt2 = new AntdUI.Radio();
            radioAlt1 = new AntdUI.Radio();
            txtAlt4 = new AntdUI.Input();
            txtAlt3 = new AntdUI.Input();
            txtAlt2 = new AntdUI.Input();
            txtAlt1 = new AntdUI.Input();
            lblAlternativa1 = new AntdUI.Label();
            lblAlternativa2 = new AntdUI.Label();
            lblAlternativa3 = new AntdUI.Label();
            lblAlternativa4 = new AntdUI.Label();
            selectTema = new AntdUI.Select();
            selectNivel = new AntdUI.Select();
            tabs1.SuspendLayout();
            TabPageVerdadeiroOuFalso.SuspendLayout();
            TabPageAlternativas.SuspendLayout();
            SuspendLayout();
            // 
            // InputQuestaoEnunciado
            // 
            InputQuestaoEnunciado.Anchor = AnchorStyles.Top;
            InputQuestaoEnunciado.AutoScroll = true;
            InputQuestaoEnunciado.BackColor = Color.FromArgb(66, 66, 66);
            InputQuestaoEnunciado.ColorScheme = AntdUI.TAMode.Dark;
            InputQuestaoEnunciado.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputQuestaoEnunciado.LineHeight = 2;
            InputQuestaoEnunciado.Location = new Point(116, 27);
            InputQuestaoEnunciado.Margin = new Padding(10);
            InputQuestaoEnunciado.Multiline = true;
            InputQuestaoEnunciado.Name = "InputQuestaoEnunciado";
            InputQuestaoEnunciado.PaddGap = 1F;
            InputQuestaoEnunciado.PlaceholderText = "Digite o enunciado da questão aqui...";
            InputQuestaoEnunciado.PrefixFormat = AntdUI.FormatFlags.Top;
            InputQuestaoEnunciado.RightToLeft = RightToLeft.No;
            InputQuestaoEnunciado.Size = new Size(1044, 110);
            InputQuestaoEnunciado.TabIndex = 0;
            // 
            // tabs1
            // 
            tabs1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tabs1.BackColor = Color.FromArgb(33, 33, 33);
            tabs1.ColorScheme = AntdUI.TAMode.Dark;
            tabs1.Controls.Add(TabPageVerdadeiroOuFalso);
            tabs1.Controls.Add(TabPageAlternativas);
            tabs1.Location = new Point(190, 205);
            tabs1.Name = "tabs1";
            tabs1.Pages.Add(TabPageVerdadeiroOuFalso);
            tabs1.Pages.Add(TabPageAlternativas);
            tabs1.Size = new Size(900, 480);
            tabs1.Style = styleLine1;
            tabs1.TabIndex = 3;
            tabs1.Text = "Abas";
            // 
            // TabPageVerdadeiroOuFalso
            // 
            TabPageVerdadeiroOuFalso.BackColor = Color.FromArgb(33, 33, 33);
            TabPageVerdadeiroOuFalso.Controls.Add(btnSalvarVF);
            TabPageVerdadeiroOuFalso.Controls.Add(radioFalso);
            TabPageVerdadeiroOuFalso.Controls.Add(radioVerdadeiro);
            TabPageVerdadeiroOuFalso.ForeColor = SystemColors.Control;
            TabPageVerdadeiroOuFalso.Location = new Point(0, 30);
            TabPageVerdadeiroOuFalso.Name = "TabPageVerdadeiroOuFalso";
            TabPageVerdadeiroOuFalso.Size = new Size(900, 450);
            TabPageVerdadeiroOuFalso.TabIndex = 0;
            TabPageVerdadeiroOuFalso.Text = "Verdadeiro / Falso";
            // 
            // btnSalvarVF
            // 
            btnSalvarVF.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvarVF.Location = new Point(50, 160);
            btnSalvarVF.Name = "btnSalvarVF";
            btnSalvarVF.Size = new Size(200, 45);
            btnSalvarVF.TabIndex = 2;
            btnSalvarVF.Text = "Salvar Questão (V/F)";
            btnSalvarVF.Type = AntdUI.TTypeMini.Primary;
            btnSalvarVF.Click += btnSalvarVF_Click;
            // 
            // radioFalso
            // 
            radioFalso.BackColor = Color.FromArgb(33, 33, 33);
            radioFalso.ColorScheme = AntdUI.TAMode.Dark;
            radioFalso.Font = new Font("Segoe UI", 12F);
            radioFalso.Location = new Point(50, 90);
            radioFalso.Name = "radioFalso";
            radioFalso.Size = new Size(300, 40);
            radioFalso.TabIndex = 1;
            radioFalso.Text = "A afirmação é Falsa";
            // 
            // radioVerdadeiro
            // 
            radioVerdadeiro.BackColor = Color.FromArgb(33, 33, 33);
            radioVerdadeiro.Checked = true;
            radioVerdadeiro.ColorScheme = AntdUI.TAMode.Dark;
            radioVerdadeiro.Font = new Font("Segoe UI", 12F);
            radioVerdadeiro.Location = new Point(50, 40);
            radioVerdadeiro.Name = "radioVerdadeiro";
            radioVerdadeiro.Size = new Size(300, 40);
            radioVerdadeiro.TabIndex = 0;
            radioVerdadeiro.Text = "A afirmação é Verdadeira";
            // 
            // TabPageAlternativas
            // 
            TabPageAlternativas.BackColor = Color.FromArgb(33, 33, 33);
            TabPageAlternativas.Controls.Add(btnSalvarAlternativas);
            TabPageAlternativas.Controls.Add(radioAlt4);
            TabPageAlternativas.Controls.Add(radioAlt3);
            TabPageAlternativas.Controls.Add(radioAlt2);
            TabPageAlternativas.Controls.Add(radioAlt1);
            TabPageAlternativas.Controls.Add(txtAlt4);
            TabPageAlternativas.Controls.Add(txtAlt3);
            TabPageAlternativas.Controls.Add(txtAlt2);
            TabPageAlternativas.Controls.Add(txtAlt1);
            TabPageAlternativas.Controls.Add(lblAlternativa1);
            TabPageAlternativas.Controls.Add(lblAlternativa2);
            TabPageAlternativas.Controls.Add(lblAlternativa3);
            TabPageAlternativas.Controls.Add(lblAlternativa4);
            TabPageAlternativas.ForeColor = SystemColors.Control;
            TabPageAlternativas.Location = new Point(-1800, -900);
            TabPageAlternativas.Name = "TabPageAlternativas";
            TabPageAlternativas.Size = new Size(900, 450);
            TabPageAlternativas.TabIndex = 1;
            TabPageAlternativas.Text = "Múltipla Escolha";
            // 
            // btnSalvarAlternativas
            // 
            btnSalvarAlternativas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalvarAlternativas.Location = new Point(30, 230);
            btnSalvarAlternativas.Name = "btnSalvarAlternativas";
            btnSalvarAlternativas.Size = new Size(240, 45);
            btnSalvarAlternativas.TabIndex = 8;
            btnSalvarAlternativas.Text = "Salvar Múltipla Escolha";
            btnSalvarAlternativas.Type = AntdUI.TTypeMini.Primary;
            btnSalvarAlternativas.Click += btnSalvarAlternativas_Click;
            // 
            // radioAlt4
            // 
            radioAlt4.ColorScheme = AntdUI.TAMode.Dark;
            radioAlt4.Location = new Point(730, 170);
            radioAlt4.Name = "radioAlt4";
            radioAlt4.Size = new Size(120, 40);
            radioAlt4.TabIndex = 7;
            radioAlt4.Text = "Correta";
            // 
            // radioAlt3
            // 
            radioAlt3.ColorScheme = AntdUI.TAMode.Dark;
            radioAlt3.Location = new Point(730, 120);
            radioAlt3.Name = "radioAlt3";
            radioAlt3.Size = new Size(120, 40);
            radioAlt3.TabIndex = 5;
            radioAlt3.Text = "Correta";
            // 
            // radioAlt2
            // 
            radioAlt2.ColorScheme = AntdUI.TAMode.Dark;
            radioAlt2.Location = new Point(730, 70);
            radioAlt2.Name = "radioAlt2";
            radioAlt2.Size = new Size(120, 40);
            radioAlt2.TabIndex = 3;
            radioAlt2.Text = "Correta";
            // 
            // radioAlt1
            // 
            radioAlt1.Checked = true;
            radioAlt1.ColorScheme = AntdUI.TAMode.Dark;
            radioAlt1.Location = new Point(730, 20);
            radioAlt1.Name = "radioAlt1";
            radioAlt1.Size = new Size(120, 40);
            radioAlt1.TabIndex = 1;
            radioAlt1.Text = "Correta";
            // 
            // txtAlt4
            // 
            txtAlt4.BackColor = Color.FromArgb(50, 50, 50);
            txtAlt4.ColorScheme = AntdUI.TAMode.Dark;
            txtAlt4.Location = new Point(150, 170);
            txtAlt4.Name = "txtAlt4";
            txtAlt4.Radius = 3;
            txtAlt4.Size = new Size(560, 40);
            txtAlt4.TabIndex = 6;
            // 
            // txtAlt3
            // 
            txtAlt3.BackColor = Color.FromArgb(50, 50, 50);
            txtAlt3.ColorScheme = AntdUI.TAMode.Dark;
            txtAlt3.Location = new Point(150, 120);
            txtAlt3.Name = "txtAlt3";
            txtAlt3.Radius = 3;
            txtAlt3.Size = new Size(560, 40);
            txtAlt3.TabIndex = 4;
            // 
            // txtAlt2
            // 
            txtAlt2.BackColor = Color.FromArgb(50, 50, 50);
            txtAlt2.ColorScheme = AntdUI.TAMode.Dark;
            txtAlt2.Location = new Point(150, 70);
            txtAlt2.Name = "txtAlt2";
            txtAlt2.Radius = 3;
            txtAlt2.Size = new Size(560, 40);
            txtAlt2.TabIndex = 2;
            // 
            // txtAlt1
            // 
            txtAlt1.BackColor = Color.FromArgb(50, 50, 50);
            txtAlt1.ColorScheme = AntdUI.TAMode.Dark;
            txtAlt1.Location = new Point(150, 20);
            txtAlt1.Name = "txtAlt1";
            txtAlt1.Radius = 3;
            txtAlt1.Size = new Size(560, 40);
            txtAlt1.TabIndex = 0;
            // 
            // lblAlternativa1
            // 
            lblAlternativa1.ForeColor = Color.White;
            lblAlternativa1.Location = new Point(20, 20);
            lblAlternativa1.Name = "lblAlternativa1";
            lblAlternativa1.Size = new Size(120, 40);
            lblAlternativa1.TabIndex = 0;
            lblAlternativa1.Text = "Alternativa 1:";
            lblAlternativa1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAlternativa2
            // 
            lblAlternativa2.ForeColor = Color.White;
            lblAlternativa2.Location = new Point(20, 70);
            lblAlternativa2.Name = "lblAlternativa2";
            lblAlternativa2.Size = new Size(120, 40);
            lblAlternativa2.TabIndex = 0;
            lblAlternativa2.Text = "Alternativa 2:";
            lblAlternativa2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAlternativa3
            // 
            lblAlternativa3.ForeColor = Color.White;
            lblAlternativa3.Location = new Point(20, 120);
            lblAlternativa3.Name = "lblAlternativa3";
            lblAlternativa3.Size = new Size(120, 40);
            lblAlternativa3.TabIndex = 0;
            lblAlternativa3.Text = "Alternativa 3:";
            lblAlternativa3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAlternativa4
            // 
            lblAlternativa4.ForeColor = Color.White;
            lblAlternativa4.Location = new Point(20, 170);
            lblAlternativa4.Name = "lblAlternativa4";
            lblAlternativa4.Size = new Size(120, 40);
            lblAlternativa4.TabIndex = 0;
            lblAlternativa4.Text = "Alternativa 4:";
            lblAlternativa4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // selectTema
            // 
            selectTema.Anchor = AnchorStyles.Top;
            selectTema.BackColor = Color.FromArgb(66, 66, 66);
            selectTema.ColorScheme = AntdUI.TAMode.Dark;
            selectTema.Location = new Point(190, 150);
            selectTema.Name = "selectTema";
            selectTema.PlaceholderText = "Selecione o Tema";
            selectTema.Size = new Size(440, 40);
            selectTema.TabIndex = 1;
            // 
            // selectNivel
            // 
            selectNivel.Anchor = AnchorStyles.Top;
            selectNivel.BackColor = Color.FromArgb(66, 66, 66);
            selectNivel.ColorScheme = AntdUI.TAMode.Dark;
            selectNivel.Location = new Point(650, 150);
            selectNivel.Name = "selectNivel";
            selectNivel.PlaceholderText = "Selecione o Nível";
            selectNivel.Size = new Size(440, 40);
            selectNivel.TabIndex = 2;
            // 
            // PaginaCriarQuestoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(selectNivel);
            Controls.Add(selectTema);
            Controls.Add(tabs1);
            Controls.Add(InputQuestaoEnunciado);
            Name = "PaginaCriarQuestoes";
            Size = new Size(1280, 720);
            tabs1.ResumeLayout(false);
            TabPageVerdadeiroOuFalso.ResumeLayout(false);
            TabPageAlternativas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Input InputQuestaoEnunciado;
        private AntdUI.Select selectTema;
        private AntdUI.Select selectNivel;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage TabPageVerdadeiroOuFalso;

        // Componentes da Aba V/F
        private AntdUI.Radio radioVerdadeiro;
        private AntdUI.Radio radioFalso;
        private AntdUI.Button btnSalvarVF;

        // Componentes da Aba Múltipla Escolha
        private AntdUI.Label lblAlternativa1;
        private AntdUI.Label lblAlternativa2;
        private AntdUI.Label lblAlternativa3;
        private AntdUI.Label lblAlternativa4;
        private AntdUI.TabPage TabPageAlternativas;
        private AntdUI.Button btnSalvarAlternativas;
        private AntdUI.Radio radioAlt4;
        private AntdUI.Radio radioAlt3;
        private AntdUI.Radio radioAlt2;
        private AntdUI.Radio radioAlt1;
        private AntdUI.Input txtAlt4;
        private AntdUI.Input txtAlt3;
        private AntdUI.Input txtAlt2;
        private AntdUI.Input txtAlt1;
    }
}