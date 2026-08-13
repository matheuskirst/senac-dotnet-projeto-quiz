using SenacQuizApp.Features.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Forms
{
    public partial class FormLogin : Form
    {
        private readonly ModelLogin _modelLogin;
        public FormLogin(ModelLogin modelLogin)
        {
            _modelLogin = modelLogin;

            InitializeComponent();
        }
    }
}
