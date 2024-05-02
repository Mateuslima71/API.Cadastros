using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace User.api.model
{

    //[Table("usuario")] é por que minha tabela no banco está com o nome minuscuo e precisam ser iguais!
    [Table("usuario")]
    public class Usuario   
    {
        public int usuarioid { get; set; }
        
        public string nome { get; set; }

        public string sobrenome { get; set; }
        public string login { get; set; }

        public string senha { get; set; }

        //Precisamos agora adicionar um construtor

        public Usuario(int usuarioid, string nome, string sobrenome, string login, string senha)
        {
            
            this.usuarioid = usuarioid;
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.sobrenome = sobrenome ?? throw new ArgumentNullException( nameof(sobrenome));
            this.login = login ?? throw new ArgumentNullException();
            this.senha = senha ?? throw new ArgumentNullException();

        }


    }
}
