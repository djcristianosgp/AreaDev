using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace area_api.Models.Cadastros;
[Table("Marca")]
public class Marca
{
    public Marca()
    {
        Produto = new Collection<Produto>();
    }
    [Key]
    public int MarcaId { get; set; }
    [Required]
    [StringLength(200)]
    public string? Descricao { get; set; }
    public DateTime Datacadastro { get; set; } 
    public bool Ativo { get; set; }

    public ICollection<Produto>? Produto { get; set; }
}
