using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.banco.digital.Domains
{
    public class Transfer
    {
        [Key]
        public Guid IdTransfer { get; set; }

        // Usuário remetente
        [ForeignKey(nameof(IdSenderUser))]
        public User SenderUser { get; set; }
        public Guid IdSenderUser { get; set; }


        // Usuario destinatário
        [ForeignKey(nameof(IdRecipientUser))]
        public User RecipientUser { get; set; }
        public Guid IdRecipientUser { get; set; }

        [Required]
        [StringLength(15)]
        public float Value { get; set; }

        [Required]
        public DateOnly Date { get; set; }
    }
}