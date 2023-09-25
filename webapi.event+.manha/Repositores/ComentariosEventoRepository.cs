using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositores
{
    public class ComentariosEventoRepository : IComentariosEventoRepository
    {
        private readonly EventContext _eventContext;
        public ComentariosEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public ComentariosEvento BuscarPorId(Guid id)
        {
            return _eventContext.ComentariosEvento.FirstOrDefault(e => e.IdComentariosEvento == id);
        }

        public void Cadastrar(ComentariosEvento comentariosEvento)
        {
            _eventContext.ComentariosEvento.Add(comentariosEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            ComentariosEvento comentariosEventoBuscado = _eventContext.ComentariosEvento.Find(id);

            _eventContext.ComentariosEvento.Remove(comentariosEventoBuscado);

            _eventContext.SaveChanges();
        }

        public List<ComentariosEvento> Listar()
        {
            return _eventContext.ComentariosEvento.ToList();
        }
    }
}
