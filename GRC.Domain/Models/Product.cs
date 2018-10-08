using GRC.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GRC.Domain.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int CategoryId { get; private set; }
        public virtual Category Category { get; private set; }
        public decimal Price { get; private set; }

        public Product(int id, string name, int categoryId, decimal price)
        {
            ValidateValues(name, categoryId, price);
            SetProperties(id, name, categoryId, price);
        }

        // Empty constructor for EF
        protected Product() { }

        private void ValidateValues(string name, int categoryId, decimal price)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Nome é obrigatório");
            DomainException.When(categoryId == 0, "Categoria é obrigatória");
            DomainException.When(price <= 0, "Preço é obrigatório");
        }

        private void SetProperties(int id, string name, int categoryId, decimal price)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Price = price;
        }
    }
}
