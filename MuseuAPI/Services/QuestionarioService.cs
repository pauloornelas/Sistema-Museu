using MuseuAPI.Dtos;
using MuseuAPI.Repositories.Interfaces;
using MuseuAPI.Services.Interfaces;
using MuseuAPI.Entities;

namespace MuseuAPI.Services
{
    public class QuestionarioService : IQuestionarioService
    {
        private readonly IQuestionarioRepository _questionarioRepository;

        public QuestionarioService(IQuestionarioRepository questionarioRepository)
        {
            _questionarioRepository = questionarioRepository;
        }

        public IEnumerable<QuestionarioDto> GetAllRespostas()
        {
            var respostas = _questionarioRepository.GetAllAsync().Result;
            return respostas.Select(r => new QuestionarioDto
            {
                Id = r.Id,
                Avaliacao = r.Avaliacao,
                Sugestao = r.Sugestao,
                Email = r.Email
            });
        }

        public QuestionarioDto AddResposta(QuestionarioDto respostaDto)
        {
            var resposta = new Questionario
            {
                Avaliacao = respostaDto.Avaliacao,
                Sugestao = respostaDto.Sugestao,
                Email = respostaDto.Email
            };
            var novaResposta = _questionarioRepository.AddAsync(resposta).Result;
            return new QuestionarioDto
            {
                Id = novaResposta.Id,
                Avaliacao = novaResposta.Avaliacao,
                Sugestao = novaResposta.Sugestao,
                Email = novaResposta.Email
            };
        }

        public object GetRelatorioSatisfacao()
        {
            var respostas = _questionarioRepository.GetAllAsync().Result;
            if (!respostas.Any()) return new { Mensagem = "Nenhuma resposta registrada." };

            var total = respostas.Count();
            var excelente = respostas.Count(r => r.Avaliacao == "Excelente") * 100 / total;
            var boa = respostas.Count(r => r.Avaliacao == "Boa") * 100 / total;
            var ruim = respostas.Count(r => r.Avaliacao == "Ruim") * 100 / total;

            return new
            {
                Total = total,
                Excelente = $"{excelente}%",
                Boa = $"{boa}%",
                Ruim = $"{ruim}%"
            };
        }

        public bool UpdateResposta(int id, QuestionarioDto respostaDto)
        {
            var resposta = _questionarioRepository.GetByIdAsync(id).Result;
            if (resposta == null) return false;

            resposta.Avaliacao = respostaDto.Avaliacao;
            resposta.Sugestao = respostaDto.Sugestao;
            resposta.Email = respostaDto.Email;

            _questionarioRepository.UpdateAsync(resposta).Wait();
            return true;
        }

        public bool DeleteResposta(int id)
        {
            var resposta = _questionarioRepository.GetByIdAsync(id).Result;
            if (resposta == null) return false;

            _questionarioRepository.DeleteAsync(resposta).Wait();
            return true;
        }
    }
}
