using System.Linq;
using GRC.Domain.Interfaces;
using GRC.Domain.Models;
using GRC.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GRC.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(GRCContext context)
            : base(context)
        {

        }

        public Product GetByName(string name)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Name == name);
        }
    }
}
