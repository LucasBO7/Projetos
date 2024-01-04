using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.banco.digital.Repositories
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }


        [Required]
        [ForeignKey(nameof(this.IdConta))]
        public Conta Conta { get; set; }
        public Guid IdConta { get; set; }


        [Required]
        [ForeignKey(nameof(this.IdTipoUsuario))]
        public TipoUsuario TipoUsuario { get; set; }
        public Guid IdTipoUsuario { get; set; }

        [Required]
        [StringLength(50)]
        //Lucas Bianchezzi Da Silva Oliveira Santos Júnior
        public string NomeCompleto { get; set; }

        [Required]
        [StringLength(15)]
        public string CpfOrCnpj { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(18)]
        public string Senha { get; set; }
    }
}