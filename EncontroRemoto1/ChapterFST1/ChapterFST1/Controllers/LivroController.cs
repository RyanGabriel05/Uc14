using ChapterFST1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFST1.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _LivroRepository;

        public LivroController(LivroRepository LivroRepository)
        {
            _LivroRepository = LivroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_LivroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
