using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.banco.digital.Repositories
{
    public class Transferencia
    {
        [Key]
        public Guid IdTransferencia { get; set; }


        [ForeignKey(nameof(this.IdUsuarioRemetente))]
        public Usuario UsuarioRemetente { get; set; }
        public Guid IdUsuarioRemetente { get; set; }



        [ForeignKey(nameof(this.IdUsuarioDestinatario))]
        public Usuario UsuarioDestinatario { get; set; }
        public Guid IdUsuarioDestinatario { get; set; }

        [Required]
        [StringLength(15)]
        public float Valor { get; set; }

        [Required]
        public DateOnly Data { get; set; }
    }
}