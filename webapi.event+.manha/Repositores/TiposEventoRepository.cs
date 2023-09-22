using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositores
{
    public class TiposEventoRepository : ITiposEventoRepository
    {
        private readonly EventContext _eventContext;
        public TiposEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TiposEvento tiposEvento)
        {
            TiposEvento tiposEventoBuscado = _eventContext.TiposEvento.Find(id);

            if (tiposEventoBuscado != null)
            {
                tiposEventoBuscado.Titulo = tiposEvento.Titulo;
            }

            _eventContext.TiposEvento.Update(tiposEventoBuscado);

            _eventContext.SaveChanges();
        }

        public TiposEvento BuscarPorId(Guid id)
        {
            return _eventContext.TiposEvento.FirstOrDefault(e => e.IdTipoEvento == id);
        }

        public void Cadastrar(TiposEvento tipoEvento)
        {
            _eventContext.TiposEvento.Add(tipoEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposEvento tipoEventoBuscado = _eventContext.TiposEvento.Find(id);

            _eventContext.TiposEvento.Remove(tipoEventoBuscado);

            _eventContext.SaveChanges();
        }

        public List<TiposEvento> Listar()
        {
            return _eventContext.TiposEvento.ToList();
        }
    }
}
