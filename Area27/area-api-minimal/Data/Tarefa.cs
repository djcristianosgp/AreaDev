using System.ComponentModel.DataAnnotations.Schema;

namespace area_api_minimal.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status);

