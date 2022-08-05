using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace area_api.Models.Cadastros;

[Table("Produto")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }
    [Required]
    [StringLength(200)]
    public string? Descricao { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public double Preco { get; set; }
    public int CategoriaId { get; set; } 
    public Categoria? Categoria { get; set; }
    public int MarcaId { get; set; }
    public Marca? Marca { get; set; }    
    public DateTime Datacadastro { get; set; } 

    public bool Ativo { get; set; } 
}
