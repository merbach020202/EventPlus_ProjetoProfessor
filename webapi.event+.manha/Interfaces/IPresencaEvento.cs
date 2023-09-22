using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IPresencaEvento
    {
        void Cadastrar(PresencasEvento presencasEvento);

        void Deletar(Guid id);

        List<PresencasEvento> Listar();

        PresencasEvento BuscarPorId(Guid id);
    }
}
