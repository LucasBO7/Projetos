using System.ComponentModel.DataAnnotations;

namespace webapi.banco.digital.Repositories
{
    public class TipoUsuario
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome { get; set; }
    }
}
