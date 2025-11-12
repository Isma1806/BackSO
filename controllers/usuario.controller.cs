using InvestigacionSO.Api.models;
using InvestigacionSO.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace InvestigacionSO.Api.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest("El usuario no puede ser nulo");

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return Ok(new
            {
                message = "Usuario registrado exitosamente",
                usuario
            });
        }
    }
}
