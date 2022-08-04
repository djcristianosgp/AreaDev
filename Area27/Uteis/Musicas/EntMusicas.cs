using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uteis.Musicas
{
    public class EntMusicas
    {
        public string title { get; set; } = "";
        public string artist { get; set; } = "Sem Artista";
        public string genres { get; set; } = "Sem Genero";
        public string track { get; set; } = "0";
        public string year { get; set; } = "1961";
        public string fullname { get; set; } = "";
        public string name { get; set; } = "";
        public DateTime datecreate { get; set; }
    }
}
