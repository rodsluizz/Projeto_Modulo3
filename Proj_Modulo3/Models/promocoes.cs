using System.ComponentModel.DataAnnotations;

namespace Proj_Modulo3.Models
{
    public class promocoes
    {
        [Key]
        public int id_promocoes { get; set; }
        public string local_viagem { get; set; }
        public string estado { get; set; }
        public float preco_antigo { get; set; }
        public float preco_atual { get; set; }
    }
}
