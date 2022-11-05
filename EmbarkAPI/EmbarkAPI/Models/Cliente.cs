using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmbarkAPI.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id_cliente { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        [StringLength(40)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do cliente")]
        [StringLength(40)]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        [StringLength(40)]
        public string cidade { get; set; }


        [Required(ErrorMessage = "Informe O CEP")]
        public int cep { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(8)]
        public string senha { get; set; }

        [Required(ErrorMessage = "Informe o Sobrenome do cliente")]
        [StringLength(40)]
        public string sobre_nome { get; set; }

        [Required(ErrorMessage = "Informe o estado do cliente")]
        [StringLength(10)]
        public string estado { get; set; }
    }
}
