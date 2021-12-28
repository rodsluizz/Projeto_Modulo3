using System.ComponentModel.DataAnnotations;

namespace Proj_Modulo3.Models
{
    public class destinos
    {
        [Key]
        public int id_destino { get; set; }
        public string local_viagem { get; set; }
        public string estado { get; set; }
        public float valor { get; set;}
    }
}
