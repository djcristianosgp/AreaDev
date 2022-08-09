using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace area_api.Models.Cadastros;
[Table("marca")]
[Index(nameof(Marca.Descricao), IsUnique = true, Name = "marca_index01")]
public class Marca
{
    public Marca()
    {
        Produto = new Collection<Produto>();
    }

    [Key]
    [Column(name: "marcaid")]
    public int MarcaId { get; set; }

    [Required]
    [StringLength(200)]
    [Column(name: "descricao")]
    public string? Descricao { get; set; }

    [Column(name: "datacadastro")]
    public DateTime Datacadastro { get; set; }

    [DefaultValue(true)]
    [Column(name: "ativo")]
    public bool Ativo { get; set; } = true;

    //[JsonIgnore]
    public ICollection<Produto>? Produto { get; set; }
}
