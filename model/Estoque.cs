using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace User.api.model
{

    [Table("estoque")]
    public class Estoque
    {
        
        public long id { get; set; }

        public string produto { get; set; }

        public double preco { get; set; }

        public long quantidade { get; set; }


        public Estoque(long id, string produto, double preco, long quantidade)
        {
            this.id = id;
            this.produto = produto ?? throw new ArgumentNullException();
            this.preco = preco;
            this.quantidade = quantidade;

        }



    }
}
