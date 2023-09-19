﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.event_.manha.Domains
{
    [Table(nameof(ComentariosEvento))]
    public class ComentariosEvento
    {
        [Key]
        public Guid IdComentariosEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName ="TEXT")]
        [Required(ErrorMessage ="A descrição é obrigatória")]
        public string? Descricao { get; set; }

        [Column(TypeName ="BIT")]
        [Required(ErrorMessage ="A descrição de exibição é obrigatória")]

        public bool Exibe { get; set; }

        //ref.tabeala Usuario = FK
        [Required(ErrorMessage = "Usuaário obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }


        //ref.tabela Evento = FK
        [Required(ErrorMessage = "Evento obrigatório")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public Evento? Evento { get; }
    }
}
