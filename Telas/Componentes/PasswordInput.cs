using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp.Telas.Componentes
{
    // Input customizado para limpa a seleção de texto após clicar no suffix
    public class PasswordInput : AntdUI.Input
    {
        protected override void OnMouseDown(MouseEventArgs e)
        {
            // 1. Deixa o AntdUI processar o clique primeiro (Isso ativa o SuffixClick!)
            base.OnMouseDown(e);

            // 2. Se o clique foi no botão do sufixo (canto direito)
            if (e.Button == MouseButtons.Left && e.X > (Width - 36))
            {
                // Corta a seleção instantaneamente na memória antes do desenho do frame
                this.SelectionLength = 0;
                this.DeselectAll();

                // Força o cursor a ficar parado no final do texto existente
                this.SelectionStart = this.Text.Length;
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            var mousePos = PointToClient(Cursor.Position);

            // Se o usuário clicar duas vezes rápido no olho, aborta completamente 
            // a rotina de seleção por palavra do Windows/AntdUI
            if (mousePos.X > (Width - 36))
            {
                this.SelectionLength = 0;
                this.DeselectAll();
                return;
            }

            base.OnDoubleClick(e);
        }
    }
}
