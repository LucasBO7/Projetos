using System.ComponentModel.DataAnnotations;

namespace webapi.banco.digital.Repositories
{
    public class Conta
    {
        [Key]
        public Guid IdConta { get; set; }

        [Required]
        [StringLength(15)]
        public string Numero { get; set; }

        [Required]
        [StringLength(15)]
        public float Saldo { get; set; }
    }
}
