using System.Linq;
using GRC.Domain.Interfaces;
using GRC.Domain.Models;
using GRC.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GRC.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(GRCContext context)
            : base(context)
        {

        }

        public Category GetByName(string name)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Name == name);
        }
    }
}
