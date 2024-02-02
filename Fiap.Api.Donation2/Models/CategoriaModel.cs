using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.Donation2.Models
{
    [Table("Categoria")]
    public class CategoriaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoincremento
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O nome para a categoria é obrigatório. ")]
        [StringLength(50)]
        [MinLength(4)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string? Descricao { get; set; }

        [NotMapped]
        public string? Token { get; set; }


        public CategoriaModel()
        {
            
        }

        public CategoriaModel(int categoriaId, string nome, string? descricao)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
        }
        public CategoriaModel(int categoriaId, string nome, string? descricao, string? token)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            Token = token;
        }
    }
}
