using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GRC.Application.Models
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(2)]
        [MaxLength(200)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Categoria é obrigatória")]
        [DisplayName("Categoria")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Currency, ErrorMessage = "Preço em formato inválido")]
        [DisplayName("Preço")]
        public decimal Price { get; set; }

        public virtual CategoryViewModel Category { get; set; }
    }
}
