using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Uteis.PaoDoDia
{
    [Table("pedidos")]
    public class EntPedido
    {
        [Key]
        public int id_pedidos { get; set; }
        public DateTime data_pedidos { get; set; }
        public DateTime dth_exporta { get; set; }
        [Required]
        [StringLength(200)]
        public string colaborador { get; set; }
        [Required]
        [StringLength(200)]
        public string estacao { get; set; }
        [Required]
        [StringLength(200)]
        public string pao { get; set; }
    }
}
