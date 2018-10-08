using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using GRC.Application.Services.Interfaces;
using GRC.Application.Models;
using GRC.Domain.Interfaces;
using GRC.Domain.Models;

namespace GRC.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        
        public CategoryService(IMapper mapper,
                                  ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        
        public IEnumerable<CategoryViewModel> GetAll()
        {
            return _categoryRepository.GetAll().ProjectTo<CategoryViewModel>();
        }

        public CategoryViewModel GetById(int id)
        {
            return _mapper.Map<CategoryViewModel>(_categoryRepository.GetById(id));
        }

        public void Register(CategoryViewModel customerViewModel)
        {
            _categoryRepository.Add(_mapper.Map<Category>(customerViewModel));
            _categoryRepository.SaveChanges();
        }

        public void Update(CategoryViewModel customerViewModel)
        {
            _categoryRepository.Update(_mapper.Map<Category>(customerViewModel));
            _categoryRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            _categoryRepository.Remove(id);
            _categoryRepository.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
