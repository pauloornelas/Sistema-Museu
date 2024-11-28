using Microsoft.AspNetCore.Mvc;
using MuseuAPI.Services.Interfaces;
using MuseuAPI.Dtos;

namespace MuseuAPI.Controllers
{
    /// <summary>
    /// Controlador para gerenciar as obras da exposição.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ObrasController : ControllerBase
    {
        private readonly IObraService _obraService;

        /// <summary>
        /// Construtor do controlador de obras.
        /// </summary>
        /// <param name="obraService">Serviço responsável pela lógica de obras.</param>
        public ObrasController(IObraService obraService)
        {
            _obraService = obraService;
        }

        /// <summary>
        /// Obtém todas as obras da exposição.
        /// </summary>
        /// <returns>Uma lista de todas as obras disponíveis.</returns>
        /// <response code="200">Retorna a lista de obras.</response>
        [HttpGet]
        public IActionResult GetObras()
        {
            return Ok(_obraService.GetAllObras());
        }

        /// <summary>
        /// Obtém os detalhes de uma obra específica.
        /// </summary>
        /// <param name="id">O ID da obra.</param>
        /// <returns>Os detalhes da obra solicitada.</returns>
        /// <response code="200">Retorna os detalhes da obra, incluindo a imagem.</response>
        /// <response code="404">Se a obra não for encontrada.</response>
        [HttpGet("{id}")]
        public IActionResult GetObraById(int id)
        {
            var obra = _obraService.GetObraById(id);
            if (obra == null) return NotFound();
            return File(obra.Imagem, "image/jpeg");
        }

        /// <summary>
        /// Adiciona uma nova obra à exposição.
        /// </summary>
        /// <param name="obra">Os dados da obra a ser criada.</param>
        /// <returns>A obra criada, incluindo o ID gerado.</returns>
        /// <response code="201">Retorna a obra criada.</response>
        [HttpPost]
        public IActionResult AddObra([FromForm] ObraDto obra)
        {
            var novaObra = _obraService.AddObra(obra);
            return CreatedAtAction(nameof(GetObraById), new { id = novaObra.Id }, novaObra);
        }

        /// <summary>
        /// Atualiza uma obra existente.
        /// </summary>
        /// <param name="id">O ID da obra a ser atualizada.</param>
        /// <param name="obra">Os novos dados da obra.</param>
        /// <returns>Status da operação.</returns>
        /// <response code="204">Atualização realizada com sucesso.</response>
        /// <response code="404">Se a obra não for encontrada.</response>
        [HttpPut("{id}")]
        public IActionResult UpdateObra(int id, [FromForm] ObraDto obra)
        {
            var updated = _obraService.UpdateObra(id, obra);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Exclui uma obra.
        /// </summary>
        /// <param name="id">O ID da obra a ser excluída.</param>
        /// <returns>Status da operação.</returns>
        /// <response code="204">Exclusão realizada com sucesso.</response>
        /// <response code="404">Se a obra não for encontrada.</response>
        [HttpDelete("{id}")]
        public IActionResult DeleteObra(int id)
        {
            var deleted = _obraService.DeleteObra(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
