using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositores
{
    public class TiposUsuarioRepository : ITiposUsuarioRepository
    {
        //Para cadastrar é necessário ter acesso ao contexto
        private readonly EventContext _eventContext;
        public TiposUsuarioRepository()
        {
            _eventContext= new EventContext();
        }

        public void Atualizar(Guid id, TiposUsuario tipoUsuario)
        {
            TiposUsuario tiposUsuarioBuscado = _eventContext.TiposUsuario.Find(id);

            if (tiposUsuarioBuscado != null)
            {
                tiposUsuarioBuscado.Titulo = tipoUsuario.Titulo;
            }

            _eventContext.TiposUsuario.Update(tiposUsuarioBuscado);

            _eventContext.SaveChanges();
        }

        public TiposUsuario BuscarPorId(Guid id)
        {
            return _eventContext.TiposUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);
        }

        public void Cadastrar(TiposUsuario tipoUsuario)
        {
            _eventContext.TiposUsuario.Add(tipoUsuario);
            
            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tipoUsuarioBuscado = _eventContext.TiposUsuario.Find(id);

            _eventContext.TiposUsuario.Remove(tipoUsuarioBuscado);

            _eventContext.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return _eventContext.TiposUsuario.ToList();
        }
    }
}
