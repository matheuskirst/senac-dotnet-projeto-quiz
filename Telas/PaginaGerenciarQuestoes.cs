using SenacQuizApp.Dtos;
using SenacQuizApp.Dtos.Ranking;
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
        public event EventHandler? CriarQuestao;

        private QuestaoTipoId? _questaoTipoId = null;
        private QuestaoNivelId? _questaoNivelId = null;
        private int? _questaoTemaId = null;

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

            SelectTipo.SelectedIndex = 0;

            SelectNivel.Items.Add(new AntdUI.SelectItem("Todos"));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Iniciante", QuestaoNivelId.Iniciante));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Fácil", QuestaoNivelId.Facil));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Intermediário", QuestaoNivelId.Intermediario));
            SelectNivel.Items.Add(new AntdUI.SelectItem("Avançado", QuestaoNivelId.Avancado));

            SelectNivel.SelectedIndex = 0;

            var temas = await _questaoService.ObterQuestaoTemas();

            SelectTema.Items.Add(new AntdUI.SelectItem("Todos"));
            foreach (var item in temas)
            {
                SelectTema.Items.Add(new AntdUI.SelectItem(item.Nome, item.Id) { });
            }

            SelectTema.SelectedIndex = 0;

            TableQuestoes.Columns = new AntdUI.ColumnCollection
            {
                new AntdUI.Column(nameof(QuestaoDados.Tipo), "Tipo") { SortOrder = true },
                new AntdUI.Column(nameof(QuestaoDados.Tema), "Tema") { SortOrder = true },
                new AntdUI.Column(nameof(QuestaoDados.Nivel), "Nível") { SortOrder = true },
                new AntdUI.Column(nameof(QuestaoDados.Enunciado), "Enunciado") { SortOrder = true, Ellipsis = true },
                new AntdUI.Column(nameof(QuestaoDados.Pontos), "Pontos") { SortOrder = true },
                new AntdUI.Column(nameof(QuestaoDados.VerdadeiroFalsoDisplay), "Verdadeiro?") { SortOrder = true },
            };

            await AtualizarTabela();
        }

        private async Task AtualizarTabela()
        {
            TableQuestoes.PauseLayout = true;

            TableQuestoes.DataSource = null;

            string? enunciado = InputEnunciado.Text;

            var questoes = await _questaoService.ObterTodos(enunciado, _questaoTipoId, _questaoNivelId, _questaoTemaId);

            TableQuestoes.DataSource = questoes;

            TableQuestoes.PauseLayout = false;
        }

        private void ButtonNovaQuestao_Click(object sender, EventArgs e)
        {
            CriarQuestao?.Invoke(this, EventArgs.Empty);
        }

        private async void SelectTipo_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            if (e.Value is not QuestaoTipoId tipo)
            {
                _questaoTipoId = null;
            }
            else
            {
                _questaoTipoId = tipo;
            }

            await AtualizarTabela();
        }

        private async void SelectNivel_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            if (e.Value is not QuestaoNivelId nivel)
            {
                _questaoNivelId = null;
            }
            else
            {
                _questaoNivelId = nivel;
            }

            await AtualizarTabela();
        }

        private async void SelectTema_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            if (e.Value is not int tema)
            {
                _questaoTemaId = null;
            }
            else
            {
                _questaoTemaId = tema;
            }

            await AtualizarTabela();
        }

        private async void ButtonBuscarData_Click(object sender, EventArgs e)
        {
            await AtualizarTabela();
        }

        private async void InputEnunciado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await AtualizarTabela();
            }
        }
    }
}
