using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.banco.digital.Domains
{
    [Index(nameof(this.Number), IsUnique = true)]
    public class Account
    {
        [Key]
        public Guid IdAccount { get; set; }

        [Required]
        [StringLength(15)]
        
        public string Number { get; set; }

        [Required]
        [StringLength(15)]
        public float Balance { get; set; }
    }
}