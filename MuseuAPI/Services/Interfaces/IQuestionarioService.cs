using MuseuAPI.Dtos;

namespace MuseuAPI.Services.Interfaces
{
    public interface IQuestionarioService
    {
        IEnumerable<QuestionarioDto> GetAllRespostas();
        QuestionarioDto AddResposta(QuestionarioDto resposta);
        object GetRelatorioSatisfacao();
        bool UpdateResposta(int id, QuestionarioDto resposta);
        bool DeleteResposta(int id);
    }
}
