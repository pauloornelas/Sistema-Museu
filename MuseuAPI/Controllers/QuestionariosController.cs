using Microsoft.AspNetCore.Mvc;
using MuseuAPI.Services.Interfaces;
using MuseuAPI.Dtos;

namespace MuseuAPI.Controllers
{
    /// <summary>
    /// Controlador para gerenciar as respostas dos questionários.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionariosController : ControllerBase
    {
        private readonly IQuestionarioService _questionarioService;

        /// <summary>
        /// Construtor do controlador de questionários.
        /// </summary>
        /// <param name="questionarioService">Serviço responsável pela lógica dos questionários.</param>
        public QuestionariosController(IQuestionarioService questionarioService)
        {
            _questionarioService = questionarioService;
        }

        /// <summary>
        /// Obtém todas as respostas do questionário.
        /// </summary>
        /// <returns>Uma lista de todas as respostas registradas.</returns>
        /// <response code="200">Retorna a lista de respostas.</response>
        [HttpGet]
        public IActionResult GetRespostas()
        {
            return Ok(_questionarioService.GetAllRespostas());
        }

        /// <summary>
        /// Adiciona uma nova resposta ao questionário.
        /// </summary>
        /// <param name="resposta">Os dados da nova resposta.</param>
        /// <returns>A resposta criada, incluindo o ID gerado.</returns>
        /// <response code="201">Retorna a resposta criada.</response>
        [HttpPost]
        public IActionResult AddResposta([FromBody] QuestionarioDto resposta)
        {
            var novaResposta = _questionarioService.AddResposta(resposta);
            return CreatedAtAction(nameof(GetRespostas), new { id = novaResposta.Id }, novaResposta);
        }

        /// <summary>
        /// Obtém um relatório com a análise das respostas.
        /// </summary>
        /// <returns>Um relatório com as porcentagens de satisfação.</returns>
        /// <response code="200">Retorna o relatório de satisfação.</response>
        [HttpGet("relatorio")]
        public IActionResult GetRelatorio()
        {
            return Ok(_questionarioService.GetRelatorioSatisfacao());
        }

        /// <summary>
        /// Atualiza uma resposta do questionário.
        /// </summary>
        /// <param name="id">O ID da resposta a ser atualizada.</param>
        /// <param name="resposta">Os novos dados da resposta.</param>
        /// <returns>Status da operação.</returns>
        /// <response code="204">Atualização realizada com sucesso.</response>
        /// <response code="404">Se a resposta não for encontrada.</response>
        [HttpPut("{id}")]
        public IActionResult UpdateResposta(int id, [FromBody] QuestionarioDto resposta)
        {
            var updated = _questionarioService.UpdateResposta(id, resposta);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Exclui uma resposta do questionário.
        /// </summary>
        /// <param name="id">O ID da resposta a ser excluída.</param>
        /// <returns>Status da operação.</returns>
        /// <response code="204">Exclusão realizada com sucesso.</response>
        /// <response code="404">Se a resposta não for encontrada.</response>
        [HttpDelete("{id}")]
        public IActionResult DeleteResposta(int id)
        {
            var deleted = _questionarioService.DeleteResposta(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
