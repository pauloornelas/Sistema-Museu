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
                Email = r.Email,
                DataNascimento = r.DataNascimento,
                Pergunta1 = r.Pergunta1,
                Resposta1 = r.Resposta1,
                Pergunta2 = r.Pergunta2,
                Resposta2 = r.Resposta2,
                Pergunta3 = r.Pergunta3,
                Resposta3 = r.Resposta3,
                Pergunta4 = r.Pergunta4,
                Resposta4 = r.Resposta4,
                Pergunta5 = r.Pergunta5,
                Resposta5 = r.Resposta5,
                Comentarios = r.Comentarios
            });
        }

        public QuestionarioDto AddResposta(QuestionarioDto respostaDto)
        {
            var resposta = new Questionario
            {
                Email = respostaDto.Email,
                DataNascimento = respostaDto.DataNascimento,
                Pergunta1 = respostaDto.Pergunta1,
                Resposta1 = respostaDto.Resposta1,
                Pergunta2 = respostaDto.Pergunta2,
                Resposta2 = respostaDto.Resposta2,
                Pergunta3 = respostaDto.Pergunta3,
                Resposta3 = respostaDto.Resposta3,
                Pergunta4 = respostaDto.Pergunta4,
                Resposta4 = respostaDto.Resposta4,
                Pergunta5 = respostaDto.Pergunta5,
                Resposta5 = respostaDto.Resposta5,
                Comentarios = respostaDto.Comentarios
            };

            var novaResposta = _questionarioRepository.AddAsync(resposta).Result;

            return new QuestionarioDto
            {
                Id = novaResposta.Id,
                Email = novaResposta.Email,
                DataNascimento = novaResposta.DataNascimento,
                Pergunta1 = novaResposta.Pergunta1,
                Resposta1 = novaResposta.Resposta1,
                Pergunta2 = novaResposta.Pergunta2,
                Resposta2 = novaResposta.Resposta2,
                Pergunta3 = novaResposta.Pergunta3,
                Resposta3 = novaResposta.Resposta3,
                Pergunta4 = novaResposta.Pergunta4,
                Resposta4 = novaResposta.Resposta4,
                Pergunta5 = novaResposta.Pergunta5,
                Resposta5 = novaResposta.Resposta5,
                Comentarios = novaResposta.Comentarios
            };
        }

        public bool UpdateResposta(int id, QuestionarioDto respostaDto)
        {
            var resposta = _questionarioRepository.GetByIdAsync(id).Result;
            if (resposta == null) return false;

            resposta.Email = respostaDto.Email;
            resposta.DataNascimento = respostaDto.DataNascimento;
            resposta.Pergunta1 = respostaDto.Pergunta1;
            resposta.Resposta1 = respostaDto.Resposta1;
            resposta.Pergunta2 = respostaDto.Pergunta2;
            resposta.Resposta2 = respostaDto.Resposta2;
            resposta.Pergunta3 = respostaDto.Pergunta3;
            resposta.Resposta3 = respostaDto.Resposta3;
            resposta.Pergunta4 = respostaDto.Pergunta4;
            resposta.Resposta4 = respostaDto.Resposta4;
            resposta.Pergunta5 = respostaDto.Pergunta5;
            resposta.Resposta5 = respostaDto.Resposta5;
            resposta.Comentarios = respostaDto.Comentarios;

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
