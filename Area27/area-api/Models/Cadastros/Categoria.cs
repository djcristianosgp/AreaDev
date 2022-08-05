using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace area_api.Models.Cadastros;

[Table("Categoria")]
public class Categoria
{
    public Categoria()
    {
        Produto = new Collection<Produto>();
    }
    [Key]
    public int CategoriaId { get; set; }
    [Required]
    [StringLength(200)]
    public string? Descricao { get; set; } 
    public DateTime Datacadastro { get; set; }
    public bool Ativo { get; set; }

    public ICollection<Produto>? Produto { get; set; }
}
