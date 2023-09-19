using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table(nameof(PresencasEvento))]
    public class PresencasEvento
    {
        [Key]
        public Guid IdPresencasEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName ="BIT")]
        [Required(ErrorMessage ="Situacao obrigatória!")]
        public bool Situacao { get; set; }


        //ref.tabeala Usuario = FK
        [Required(ErrorMessage ="Usuário obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }


        //ref.tabela Evento = FK
        [Required(ErrorMessage ="Evento obrigatório")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof (IdEvento))]
        public Evento? Evento { get;}
    }
}
