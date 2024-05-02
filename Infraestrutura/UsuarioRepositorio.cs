using Microsoft.EntityFrameworkCore;
using User.api.model;


namespace User.api.Infraestrutura
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ConectionDatabase _context = new ConectionDatabase();
        public void Add(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> Get()
        {
            return _context.Usuario.ToList();
        }
    }
}
