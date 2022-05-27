using ChapterFST1.Interfaces;
using ChapterFST1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFST1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _IUsuarioRepository;

        public UsuariosController(IUsuarioRepository iUsuarioRepository)
        {
            _IUsuarioRepository = iUsuarioRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_IUsuarioRepository.Listar());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Usuario usuarioEncontrado = _IUsuarioRepository.BuscarPorId(id);

                if (usuarioEncontrado == null)
                    return NotFound();

                return Ok(usuarioEncontrado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                //usuario.Tipo = "0";
                _IUsuarioRepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Usuario usuario)
        {
            try
            {
                _IUsuarioRepository.Atualizar(id, usuario);

                return Ok("Usuario Alterado");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _IUsuarioRepository.Deletar(id);
                return Ok("Usuario deletado");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
