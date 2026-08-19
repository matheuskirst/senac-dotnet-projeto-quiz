namespace SenacQuizApp.Telas
{
    public partial class PaginaInicial : UserControl
    {
        public event EventHandler? EscolheuLogin;
        public event EventHandler? EscolheuSignup;

        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void ButtonInicialLogin_Click(object sender, EventArgs e)
        {
            EscolheuLogin?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonInicialSignup_Click(object sender, EventArgs e)
        {
            EscolheuSignup?.Invoke(this, EventArgs.Empty);
        }
    }
}
