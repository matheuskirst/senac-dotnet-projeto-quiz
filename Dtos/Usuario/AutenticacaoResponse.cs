using SenacQuizApp.Enums;

namespace SenacQuizApp.Dtos.Usuario
{
    public record AutenticacaoResponse(bool IsSucesso, ErroAutenticacao? Erro=null);
}
