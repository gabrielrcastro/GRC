using System;
using System.Collections.Generic;
using System.Text;
using GRC.Domain.Models;

namespace GRC.Domain.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByName(string name);
    }
}
