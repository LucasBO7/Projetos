using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.banco.digital.Domains
{
    [Index(nameof(this.CpfOrCnpj), IsUnique = true)]
    [Index(nameof(this.Email), IsUnique = true)]
    public class User
    {
        [Key]
        public Guid Id { get; set; }


        [Required]
        [ForeignKey(nameof(IdAccount))]
        public Account Account { get; set; }
        public Guid IdAccount { get; set; }


        [Required]
        [ForeignKey(nameof(IdUserType))]
        public UserType UserType { get; set; }
        public Guid IdUserType { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(15)]
        public string CpfOrCnpj { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(18)]
        public string Password { get; set; }
    }
}