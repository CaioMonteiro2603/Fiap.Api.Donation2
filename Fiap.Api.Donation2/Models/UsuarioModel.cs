using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.Donation2.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [StringLength(50)]
        [Required]
        public string Nome { get; set; }

        [StringLength(50)]
        [Required]
        public string EmailUsuario {  get; set; }

        [StringLength(15)]
        [Required]
        public string SenhaUsuario { get; set; }

        [StringLength(15)]
        [Required]
        public string? Regra{ get; set; }

        public UsuarioModel()
        {
            
        }

        public UsuarioModel(int usuarioId, string nome, string emailUsuario, string senhaUsuario, string? regra)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            EmailUsuario = emailUsuario;
            SenhaUsuario = senhaUsuario;
            Regra = regra;
        }
    }
}
