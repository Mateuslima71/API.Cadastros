namespace User.api.model
{
    public interface Iestoquerepositorio
    {
        void Add(Estoque estoque); 
        
        List<Estoque> Get();
    }
}
