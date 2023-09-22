using webapi.event_.manha.Contexts;
using webapi.event_.manha.Domains;
using webapi.event_.manha.Interfaces;

namespace webapi.event_.manha.Repositores
{
    public class PresencaEventoRepository : IPresencaEvento
    {
        private readonly EventContext _eventContext;
        public PresencaEventoRepository()
        {
            _eventContext = new EventContext();
        }


        public PresencasEvento BuscarPorId(Guid id)
        {
            return _eventContext.PresencaEvento.FirstOrDefault(e => e.IdPresencasEvento == id);
        }

        public void Cadastrar(PresencasEvento presencasEvento)
        {
            _eventContext.PresencaEvento.Add(presencasEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            PresencasEvento presencasEventos = _eventContext.PresencaEvento.Find(id);

            _eventContext.PresencaEvento.Remove(presencasEventos);

            _eventContext.SaveChanges();
        }

        public List<PresencasEvento> Listar()
        {
            return _eventContext.PresencaEvento.ToList();
        }
    }
}

