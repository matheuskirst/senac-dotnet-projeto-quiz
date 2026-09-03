using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Conquista;
using SenacQuizApp.Services;
using SenacQuizApp.Telas.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas
{
    public partial class PaginaConquistas : UserControl
    {
        private readonly ConquistaService _conquistaService;

        public PaginaConquistas(ConquistaService conquistaService)
        {
            _conquistaService = conquistaService;

            InitializeComponent();
        }

        private async void PaginaConquistas_Load(object sender, EventArgs e)
        {
            var conquistas = await _conquistaService.ObterTodos();

            foreach(var conquista in conquistas)
            {
                var card = new CardConquista(conquista);
                card.Dock = DockStyle.Top;

                if (conquista.Secreta) continue;

                if (conquista.Desbloqueada)
                {
                    PanelDesbloqueadas.Controls.Add(card);
                }
                else
                {
                    PanelBloqueadas.Controls.Add(card);
                }
            }
        }
    }
}
