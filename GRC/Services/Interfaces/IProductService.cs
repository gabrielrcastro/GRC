using System;
using System.Collections.Generic;
using GRC.Application.Models;

namespace GRC.Application.Services.Interfaces
{
    public interface IProductService : IDisposable
    {
        void Register(ProductViewModel productViewModel);
        IEnumerable<ProductViewModel> GetAll();
        ProductViewModel GetById(int id);
        void Update(ProductViewModel productViewModel);
        void Remove(int id);
    }
}
