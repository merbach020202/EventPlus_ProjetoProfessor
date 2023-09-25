using webapi.event_.manha.Domains;

namespace webapi.event_.manha.Interfaces
{
    public interface IComentariosEventoRepository
    {
        void Cadastrar(ComentariosEvento comentariosEvento);

        void Deletar(Guid id);

        List<ComentariosEvento> Listar();

        ComentariosEvento BuscarPorId(Guid id);
    }
}
