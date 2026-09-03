using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using AntdUI;
using SenacQuizApp.Data;
using SenacQuizApp.Enums;
using SenacQuizApp.Modelos.Questoes;
using SenacQuizApp.Services;
using SenacQuizApp.Utils;

namespace SenacQuizApp.Telas
{
    public partial class PaginaCriarQuestoes : UserControl
    {
        private readonly QuestaoService _questaoService;

        private int? _questaoTemaId;
        private QuestaoNivelId? _questaoNivelId;

        public PaginaCriarQuestoes(QuestaoService questaoService)
        {
            _questaoService = questaoService;

            InitializeComponent();
            ConfigurarEventosAbas();
            ConfigurarInterfaceEAbas();
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var temas = await _questaoService.ObterQuestaoTemas();

            if (temas == null) return;

            foreach (var tema in temas)
            {
                selectTema.Items.Add(new AntdUI.SelectItem(tema.Nome, tema.Id));
            }

            selectNivel.Items.Add(new AntdUI.SelectItem("Iniciante", QuestaoNivelId.Iniciante));
            selectNivel.Items.Add(new AntdUI.SelectItem("Fácil", QuestaoNivelId.Facil));
            selectNivel.Items.Add(new AntdUI.SelectItem("Intermediário", QuestaoNivelId.Intermediario));
            selectNivel.Items.Add(new AntdUI.SelectItem("Avançado", QuestaoNivelId.Avancado));

            if (InputQuestaoEnunciado != null)
            {
                InputQuestaoEnunciado.Multiline = true;
            }
        }

        private void ConfigurarEventosAbas()
        {
            tabs1.SelectedIndexChanged += (s, e) => { };
        }

        private void ConfigurarInterfaceEAbas()
        {
            tabs1.Pages.Clear();
            tabs1.Pages.Add(TabPageVerdadeiroOuFalso);
            tabs1.Pages.Add(TabPageAlternativas);
        }

        private async void btnSalvarVF_Click(object? sender, EventArgs e)
        {
            string enunciado = InputQuestaoEnunciado.Text.Trim();

            if (_questaoNivelId == null)
            {
                PintarErros.ErroNoCampo(selectNivel, titulo: "Aviso", mensagem: "Selecione um nível!");
                return;
            }

            if (_questaoTemaId == null)
            {
                PintarErros.ErroNoCampo(selectTema, titulo: "Aviso", mensagem: "Selecione um tema!");
                return;
            }

            if (string.IsNullOrWhiteSpace(enunciado))
            {
                PintarErros.ErroNoCampo(InputQuestaoEnunciado, titulo: "Aviso", mensagem: "Informe o enunciado da questão!");
                return;
            }

            try
            {
                using var contexto = new QuizAppContexto();

                int temaId = selectTema.SelectedValue != null ? Convert.ToInt32(selectTema.SelectedValue) : 1;
                int nivelIdNumerico = selectNivel.SelectedValue != null ? Convert.ToInt32(selectNivel.SelectedValue) : 1;

                var questao = new Questao
                {
                    Enunciado = enunciado,
                    Tipo = QuestaoTipo.VerdadeiroOuFalso,
                    TemaId = temaId,
                    NivelId = (QuestaoNivelId)nivelIdNumerico,
                    VerdadeiroFalso = radioVerdadeiro.Checked
                };

                contexto.Questoes.Add(questao);
                await contexto.SaveChangesAsync();

                bool respostaEhVerdadeira = radioVerdadeiro.Checked;

                var altVerdadeiro = new Alternativa
                {
                    Texto = "Verdadeiro",
                    EhCorreta = respostaEhVerdadeira,
                    QuestaoId = questao.Id
                };
                var altFalso = new Alternativa
                {
                    Texto = "Falso",
                    EhCorreta = !respostaEhVerdadeira,
                    QuestaoId = questao.Id
                };

                contexto.Alternativas.AddRange(altVerdadeiro, altFalso);
                await contexto.SaveChangesAsync();

                MessageBox.Show("Questão Verdadeiro/Falso salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSalvarAlternativas_Click(object? sender, EventArgs e)
        {
            string enunciado = InputQuestaoEnunciado.Text.Trim();

            if (_questaoNivelId == null)
            {
                PintarErros.ErroNoCampo(selectNivel, titulo: "Aviso", mensagem: "Selecione um nível!");
                return;
            }

            if (_questaoTemaId == null)
            {
                PintarErros.ErroNoCampo(selectTema, titulo: "Aviso", mensagem: "Selecione um tema!");
                return;
            }

            if (string.IsNullOrWhiteSpace(enunciado))
            {
                PintarErros.ErroNoCampo(InputQuestaoEnunciado, titulo: "Aviso", mensagem: "Informe o enunciado da questão!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAlt1.Text) || string.IsNullOrWhiteSpace(txtAlt2.Text) ||
                string.IsNullOrWhiteSpace(txtAlt3.Text) || string.IsNullOrWhiteSpace(txtAlt4.Text))
            {
                PintarErros.ErroNoCampo(InputQuestaoEnunciado, titulo: "Aviso", mensagem: "Informe as alternativas da questão!");
                return;
            }

            try
            {
                using var contexto = new QuizAppContexto();

                var novaQuestao = new Questao
                {
                    Enunciado = enunciado,
                    Tipo = QuestaoTipo.Alternativas,
                    TemaId = _questaoTemaId.Value,
                    NivelId = _questaoNivelId.Value
                };

                contexto.Questoes.Add(novaQuestao);
                await contexto.SaveChangesAsync();

                var alternativas = new List<Alternativa>
                {
                    new Alternativa { Texto = txtAlt1.Text.Trim(), EhCorreta = radioAlt1.Checked, QuestaoId = novaQuestao.Id },
                    new Alternativa { Texto = txtAlt2.Text.Trim(), EhCorreta = radioAlt2.Checked, QuestaoId = novaQuestao.Id },
                    new Alternativa { Texto = txtAlt3.Text.Trim(), EhCorreta = radioAlt3.Checked, QuestaoId = novaQuestao.Id },
                    new Alternativa { Texto = txtAlt4.Text.Trim(), EhCorreta = radioAlt4.Checked, QuestaoId = novaQuestao.Id }
                };

                contexto.Alternativas.AddRange(alternativas);
                await contexto.SaveChangesAsync();

                MessageBox.Show("Questão de Alternativas criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar questão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectTema_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not int temaId) return;

            _questaoTemaId = temaId;
        }

        private void selectNivel_SelectedValueChanged(object sender, ObjectNEventArgs e)
        {
            if (e.Value is not QuestaoNivelId nivelId) return;

            _questaoNivelId = nivelId;
        }
    }
}