using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GRC.Application.Models
{
    public class CategoryViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(2)]
        [MaxLength(200)]
        [DisplayName("Nome")]
        public string Name { get; set; }
    }
}
