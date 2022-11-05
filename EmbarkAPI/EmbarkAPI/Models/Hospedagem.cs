using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmbarkAPI.Models
{
    [Table("Hospedagem")]
    public class Hospedagem
    {
        [Key]
        public int Id_hosp { get; set; }

        [Required(ErrorMessage = "Informe o nome da hospedagem")]
        [StringLength(40)]
        public string nome_hosp { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        [StringLength(80)]
        public string cidade { get; set; }

        [Required(ErrorMessage = "Informe o estado")]
        [StringLength(80)]
        public string estado { get; set; }

        [Required(ErrorMessage = "Informe a rua")]
        [StringLength(80)]
        public string rua { get; set; }
    }
}
