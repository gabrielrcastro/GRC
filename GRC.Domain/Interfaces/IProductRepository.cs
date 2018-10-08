using System;
using System.Collections.Generic;
using System.Text;
using GRC.Domain.Models;

namespace GRC.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByName(string name);
    }
}
