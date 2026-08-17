using AntdUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Telas.Utils
{
    public class PintarErros
    {
        public static void ErroNoCampo(
            Control control,
            bool highlight = true,
            string? titulo = null,
            string? mensagem = null,
            TAlign alinhamento = TAlign.Right
            )
        {
            if (control is Input inputControl && highlight)
            {
                inputControl.BorderColor = Color.Red;
            }
            if (titulo != null || mensagem != null)
            {
                var popover = new Popover.Config(control:control, title:titulo, content:mensagem)
                {
                    ArrowAlign = alinhamento
                };
                Popover.open(popover);
            }
        }
    }
}
