using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace area_api.Models.Cadastros;

[Table("produto")]
[Index(nameof(Produto.Descricao),IsUnique =true,Name ="produto_index01")]
public class Produto
{
    [Key]
    [Column(name: "produtoid")]
    public int ProdutoId { get; set; }

    [Required]
    [StringLength(200)]
    [Column(name: "descricao")]
    public string? Descricao { get; set; } 

    [Required]
    [DefaultValue(0.00)]
    [Column(name: "preco", TypeName = "decimal(10,2)")]
    public double Preco { get; set; }

    [DefaultValue(0)]
    [Column(name: "categoriaid")]
    public int CategoriaId { get; set; }

    [Column(name: "categoria")]
    public Categoria? Categoria { get; set; }

    [DefaultValue(0)]
    [Column(name: "marcaid")]
    public int MarcaId { get; set; } 

    [Column(name: "marca")]
    public Marca? Marca { get; set; }

    [Column(name: "datacadastro")]
    public DateTime Datacadastro { get; set; }

    [Column(name: "codigogtin")]
    [StringLength(200)]
    public string? CodigoGtin { get; set; }

    [DefaultValue(true)]
    [Column(name: "ativo")]
    public bool Ativo { get; set; } = true;
}
