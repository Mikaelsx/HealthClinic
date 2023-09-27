using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.healthclinic.tarde.Domains;
using webapi.healthclinic.tarde.Interfaces;
using webapi.healthclinic.tarde.Repositories;

namespace webapi.healthclinic.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository ctx;

        public UsuarioController()
        {
            ctx = new UsuarioRepository();
        }

        // Funcionando
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                ctx.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // Funcionando
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(ctx.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        // Funcionando
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                ctx.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // Funcionando
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(ctx.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
