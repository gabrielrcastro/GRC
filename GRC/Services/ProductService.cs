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
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper,
                                  IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return _productRepository.GetAll().ProjectTo<ProductViewModel>();
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<ProductViewModel>(_productRepository.GetById(id));
        }

        public void Register(ProductViewModel customerViewModel)
        {
            _productRepository.Add(_mapper.Map<Product>(customerViewModel));
            _productRepository.SaveChanges();
        }

        public void Update(ProductViewModel customerViewModel)
        {
            _productRepository.Update(_mapper.Map<Product>(customerViewModel));
            _productRepository.SaveChanges();
        }

        public void Remove(int id)
        {
            _productRepository.Remove(id);
            _productRepository.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
