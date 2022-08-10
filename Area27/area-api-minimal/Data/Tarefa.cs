using System.ComponentModel.DataAnnotations.Schema;

namespace area_api_minimal.Data;

[Table("tarefas")]
public record Tarefa(int id, string atividade, string status);

