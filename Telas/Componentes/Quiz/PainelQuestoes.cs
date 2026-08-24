using SenacQuizApp.Dtos;
using SenacQuizApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacQuizApp.Telas.Componentes
{
    public partial class PainelQuestoes : UserControl
    {
        QuestaoDto _questao;
        public Action<int>? EscolheuAlternativa { get; set; }
        public Action<bool>? EscolheuVerdadeiro { get; set; }

        public PainelQuestoes(QuestaoDto questao)
        {
            _questao = questao;

            InitializeComponent();
        }

        private void PainelPergunta_Load(object sender, EventArgs e)
        {
            InputPergunta.Text = _questao.Enunciado;

            if (_questao.TipoId == QuestaoTipoId.Alternativas)
            {
                foreach (AlternativaDto alternativa in _questao.Alternativas)
                {
                    var button = new AntdUI.Button
                    {
                    
                        Tag = alternativa.Id,
                        Text = alternativa.Texto,
                        Font = new Font("Tahoma", 12),
                        Dock = DockStyle.Fill
                    };

                    button.Click += AlternativaEscolhida;

                    PanelAlternativas.Controls.Add(button, 0, _questao.Alternativas.IndexOf(alternativa));
                }
            }
            else
            {
                var buttonVerdade = new AntdUI.Button
                {
                    Tag = true,
                    Text = "Verdadeiro",
                    Font = new Font("Tahoma", 12),
                    Dock = DockStyle.Fill
                };
                buttonVerdade.Click += AlternativaEscolhida;
                PanelAlternativas.Controls.Add(buttonVerdade, 0, 0);

                var buttonFalso = new AntdUI.Button
                {
                    Tag = false,
                    Text = "Falso",
                    Font = new Font("Tahoma", 12),
                    Dock = DockStyle.Fill
                };
                buttonFalso.Click += AlternativaEscolhida;
                PanelAlternativas.Controls.Add(buttonFalso, 0, 1);
            }
        }

        private void AlternativaEscolhida(object? sender, EventArgs e)
        {
            var btn = sender as AntdUI.Button;
            if (btn != null && btn.Tag != null)
            {
                if (_questao.TipoId == QuestaoTipoId.Alternativas)
                {
                    int alternativaId = (int)btn.Tag;
                    EscolheuAlternativa?.Invoke(alternativaId);
                }
                else
                {
                    bool Opcao = (bool)btn.Tag;
                    EscolheuVerdadeiro?.Invoke(Opcao);
                }
            }
        }
    }
}
