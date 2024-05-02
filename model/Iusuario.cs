namespace User.api.model
{
    public interface IUsuarioRepositorio
    {
        void Add(Usuario usuario);

        List<Usuario> Get();
    }
}
