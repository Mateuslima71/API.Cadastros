using Microsoft.AspNetCore.Identity;
using User.api.model;

namespace User.api.Infraestrutura
{
    public class EstoqueRepositorio : Iestoquerepositorio
    {
        private readonly ConectionDatabase _context = new ConectionDatabase();

        public void Add(Estoque estoque)
        {
            _context.Estoque.Add(estoque);
            _context.SaveChanges();
        }

        public List<Estoque> Get()
        {
            return _context.Estoque.ToList();
        }

    }
}
