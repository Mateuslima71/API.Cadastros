using Microsoft.AspNetCore.Mvc;
using User.api.model;
using User.api.ViewModel;

namespace User.api.Controllers
{
    [ApiController]
    [Route("api/v1/Estoque")]
    public class EstoqueController : ControllerBase
    {
        private readonly Iestoquerepositorio _estoque;
        public EstoqueController(Iestoquerepositorio estoque)
        {
            _estoque = estoque ?? throw new ArgumentNullException(nameof(estoque));
        }
        [HttpPost]
        public IActionResult Add(estoqueViewModel estoqueViewModel)
        {
            double preco = Convert.ToDouble(estoqueViewModel.preco);

            var estoque = new Estoque(estoqueViewModel.id, estoqueViewModel.produto, preco, estoqueViewModel.quantidade);

            _estoque.Add(estoque);

            return Ok();
        }


        [HttpGet]

        public IActionResult Get()
        {
            var estoque = _estoque.Get();
            return Ok(estoque);
        }
            
    }
}
