namespace LeiaJa.Presentation.Features.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly IAutorService _service;
        public AutoresController(IAutorService service)
        {
            _service = service;
        }

        #region GetAllAutoresAsync
            [HttpGet("GettAllAutores")]
            public async Task<ActionResult> GetAutores([FromQuery]PaginationParams paginationParams)
            {
                try
                {
                    var autores = await _service.GetAllAutoresAsync(paginationParams.PageNumber, paginationParams.PageSize);
                    if(autores == null)
                    {
                        return NotFound("Não Foram Encontrados Nenhum Autor");
                    }
                    return Ok(autores);
                }
                catch
                {
                    return Problem("Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.");
                }
            }
        #endregion
    
        #region GetAutoreByIDAsync
            [HttpGet("GetAutorById")]
            public async Task<ActionResult> GetAutor(int autorId)
            {
                try
                {
                    if(autorId <= 0)
                    {
                        return BadRequest("Não Deve Ser Negativa ou Zero");
                    }
                    var autor = await _service.GetAutorByIdAsync(autorId);

                    if(autor == null)
                    {
                        return NotFound("Não Foi Encontrado");
                    }
                    return Ok(autor);
                }
                catch 
                {
                    return Problem("Ocorreu um erro ao processar a solicitação. Tente novamente mais tarde.");
                }
                
            }
        #endregion

        #region CreateAutorAsync
            [HttpPost("CreateAutor")]
            public async Task<ActionResult> CreateAsync(AutorPostDTO autorPostDTO)
            {
                try
                {
                    if(autorPostDTO == null)
                        return BadRequest("Não deve ser vazia");

                    var autor = await _service.CreateAutorAsync(autorPostDTO);
                    return Ok(autor);
                }
                catch
                {
                    return Problem("Ocorreu um erro ao salvar. Tente novamente mais tarde.");
                }
            }
        #endregion

        #region UpdateAutorAsync
            [HttpPut("updateAutor")]
            public async Task<ActionResult> UpdateAutor(AutorDTO autorDTO)
            {
                try
                {
                    if(autorDTO == null)
                        return BadRequest("Não deve ser nulo");

                    var autor = await _service.UpdateAutorAsync(autorDTO);
                    return Ok(autor);
                }
                catch
                {
                    return Problem("Ocorreu um erro ao aditar. Tente novamente mais tarde.");
                }
            }
        #endregion
    
        #region DeleteAutorAsync
            [HttpDelete("deleteAutor")]
            public async Task<ActionResult> DeleteAutor(int autorId)
            {
                try
                {
                    if(autorId <= 0)
                        return BadRequest("Não deve ser nulo ou Negativa");
                        
                    var autor = await _service.DeleteAutorAsync(autorId);
                    return Ok(autor);
                }
                catch
                {
                    return Problem("Ocorreu um erro ao deletar. Tente novamente mais tarde.");
                }
            }
        #endregion
    }
}