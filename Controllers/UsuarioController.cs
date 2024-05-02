using Microsoft.AspNetCore.Mvc;
using User.api.model;
using User.api.ViewModel;
using System.Security.Cryptography;

namespace User.api.Controllers
{
    [ApiController]
    [Route("api/v1/Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuario;

        public UsuarioController(IUsuarioRepositorio usuario)
        {
            _usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
        }
        [HttpPost]
        public IActionResult Add(UsuarioViewModel usuarioViewModel)
        {
            
            var usuario = new Usuario(usuarioViewModel.usuarioid, usuarioViewModel.nome, usuarioViewModel.sobrenome, usuarioViewModel.login, usuarioViewModel.senha);
    
            _usuario.Add(usuario);
            return Ok();


        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuario = _usuario.Get();

            return Ok(usuario);

        }
    }
}
