using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExampleDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","99999999999")]
        [Required(ErrorMessage = "Preencha um Valor")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }

        [DisplayName("Cliente")]
        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}