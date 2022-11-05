using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmbarkAPI.Models
{
    [Table("Pct_viagem")]
    public class Pct_viagem
    {

        [Key]
        public int Id_destino { get; set; }

        [Required(ErrorMessage = "Informe o valor")]
        public int preco { get; set; }

        [Required(ErrorMessage = "Informe a data da viagem")]
        public DateTime data_da_viagem { get; set; }

        [Required(ErrorMessage = "Informe o destino")]
        [StringLength(40)]
        public string destno { get; set; }

        [Required(ErrorMessage = "Informe o veiculo")]
        [StringLength(40)]
        public string veiculo { get; set; }

    }
}
