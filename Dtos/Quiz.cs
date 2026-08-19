using SenacQuizApp.Modelos;

namespace SenacQuizApp.Dtos
{
    public record Quiz(DateTime DataCriacao, List<Pergunta> Perguntas);
}
