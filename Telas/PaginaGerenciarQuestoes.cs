using SenacQuizApp.Enums;
using SenacQuizApp.Services;
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
    public partial class PaginaGerenciarQuestoes : UserControl
    {
        private readonly QuestaoService _questaoService;

        public PaginaGerenciarQuestoes(QuestaoService questaoService)
        {
            _questaoService = questaoService;

            InitializeComponent();
        }

        private async void PaginaGerenciarQuestoes_Load(object sender, EventArgs e)
        {
            SelectTipo.Items.Add(new AntdUI.SelectItem("Todos"));
            SelectTipo.Items.Add(new AntdUI.SelectItem("Alternativas", QuestaoTipoId.Alternativas));
            SelectTipo.Items.Add(new AntdUI.SelectItem("Verdadeiro Falso", QuestaoTipoId.VerdadeiroOuFalso));

            SelectNivel.Items.Add(new AntdUI.SelectItem("Todos"));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Iniciante", QuestaoNivelId.Iniciante));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Fácil", QuestaoNivelId.Facil));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Intermediário", QuestaoNivelId.Intermediario));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Avançado", QuestaoNivelId.Avancado));


            var temas = await _questaoService.ObterQuestaoTemas();

            SelectTema.Items.Add(new AntdUI.SelectItem("Não concluído", QuizDiarioStatus.NaoConcluido));
            foreach (var item in temas)
            {
                SelectTema.Items.Add(new AntdUI.SelectItem(item.Nome, item.Id));
            }

            var questoes = await _questaoService.ObterTodos();

            TableQuestoes.DataSource = questoes;
        }
    }
}
