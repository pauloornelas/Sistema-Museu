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

        public QuestionariosController(IQuestionarioService questionarioService)
        {
            _questionarioService = questionarioService;
        }

        /// <summary>
        /// Obtém todas as respostas do questionário.
        /// </summary>
        [HttpGet]
        public IActionResult GetRespostas()
        {
            return Ok(_questionarioService.GetAllRespostas());
        }

        /// <summary>
        /// Adiciona uma nova resposta ao questionário.
        /// </summary>
        [HttpPost]
        public IActionResult AddResposta([FromBody] QuestionarioDto resposta)
        {
            var novaResposta = _questionarioService.AddResposta(resposta);
            return CreatedAtAction(nameof(GetRespostas), new { id = novaResposta.Id }, novaResposta);
        }

        /// <summary>
        /// Atualiza uma resposta existente no questionário.
        /// </summary>
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
        [HttpDelete("{id}")]
        public IActionResult DeleteResposta(int id)
        {
            var deleted = _questionarioService.DeleteResposta(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
