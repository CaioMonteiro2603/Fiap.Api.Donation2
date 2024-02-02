using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Api.Donation2.Models
{
    [Table("Produto")]
    [Index(nameof(DataCadastro), IsUnique = false)] // pra nao quebrar o codigo na hora do cadastro de produtos
    public class ProdutoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(5)]
        public bool Disponivel { get; set; }

        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }

        [Required]
        [StringLength (50)]
        public string SugestaoTroca { get; set; }

        [Required]
        public double Valor {  get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }

        [Required]
        public DateTime DataExpiracao { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey(nameof(UsuarioId))]
        public UsuarioModel Usuario { get; set; }

        public int CategoriaId { get; set; }
        [ForeignKey(nameof(CategoriaId))]
        public CategoriaModel Categoria {  get; set; }

        public ProdutoModel()
        {
            
        }

        public ProdutoModel(int produtoId, string nome, bool disponivel, string descricao,
            string sugestaoTroca, double valor, int usuarioId, int categoriaId)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Disponivel = disponivel;
            Descricao = descricao;
            SugestaoTroca = sugestaoTroca;
            Valor = valor;
            DataCadastro = DateTime.Now;
            DataExpiracao = DateTime.Now.AddMonths(20);
            UsuarioId = usuarioId;
            CategoriaId = categoriaId;
        }
    }
}
