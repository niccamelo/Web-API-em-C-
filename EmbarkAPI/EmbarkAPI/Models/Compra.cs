using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmbarkAPI.Models
{
    [Table("Compra")]
    public class Compra
    {
        [Key]
        public int id_compra { get; set; }

        [Required(ErrorMessage = "Informe a data da compra")]
        public DateTime data_compra { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        [StringLength(40)]
        public String nome_cliente { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de compra")]         
        public int quantidade_compra { get; set; }

        [Required(ErrorMessage = "Informe o destino do cliente")]
        [StringLength(40)]
        public String destino { get; set; }

        [Required(ErrorMessage = "Informe o valor da compra")]
        public int valor_compra { get; set; }
    }
}
