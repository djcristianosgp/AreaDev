using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace area_api.Models.Cadastros;

[Table("categoria")]
[Index(nameof(Categoria.Descricao), IsUnique = true, Name = "categoria_index01")]
public class Categoria
{
    public Categoria()
    {
        Produto = new Collection<Produto>();
    }
    [Key]
    [Column(name: "categoriaid")]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(200)]
    [Column(name: "descricao")]
    public string? Descricao { get; set; }

    [Column(name: "datacadastro")]
    public DateTime Datacadastro { get; set; }

    [DefaultValue(true)]
    [Column(name: "ativo")]
    public bool Ativo { get; set; } = true;

    public ICollection<Produto>? Produto { get; set; }
}
