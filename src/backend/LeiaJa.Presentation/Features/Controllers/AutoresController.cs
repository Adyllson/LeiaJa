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

        #region GetAllAutoresAsyn
            [HttpGet("GettAllAutores")]
            public async Task<ActionResult> GetAutores()
            {
                try
                {
                    var autores = await _service.GetAllAutoresAsync();
                    if(autores == null)
                    {
                        return NotFound("Não Foram Encontrados Nenhum Autor");
                    }
                    return Ok(autores);
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        #endregion
    }
}