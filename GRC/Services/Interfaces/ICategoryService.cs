using System;
using System.Collections.Generic;
using GRC.Application.Models;

namespace GRC.Application.Services.Interfaces
{
    public interface ICategoryService : IDisposable
    {
        void Register(CategoryViewModel productViewModel);
        IEnumerable<CategoryViewModel> GetAll();
        CategoryViewModel GetById(int id);
        void Update(CategoryViewModel productViewModel);
        void Remove(int id);
    }
}
