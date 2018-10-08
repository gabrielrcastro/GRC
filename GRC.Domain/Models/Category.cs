using GRC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GRC.Domain.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public virtual List<Product> Products { get; private set; }

        public Category(int? id, string name)
        {
            ValidateNameAndSetName(id, name);
        }

        // Empty constructor for EF
        protected Category() { }

        public void Update(string name)
        {
            ValidateNameAndSetName(0, name);
        }

        public void ValidateNameAndSetName(int? id, string name)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Nome é obrigatório");

            if (id.HasValue && id > 0)
                Id = id.Value;

            Name = name;
        }
    }
}
