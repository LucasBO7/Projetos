using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webapi.banco.digital.Domains
{
    [Index(nameof(this.Name), IsUnique = true)]
    public class UserType
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}