using AutoMapper;
using AutoMapper.QueryableExtensions;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.ViewModels;
using StoreMDC.Domain.Entities;
using StoreMDC.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace StoreMDC.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;

        public ProductAppService(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            return _repository.GetAll().ProjectTo<ProductViewModel>();
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<ProductViewModel>(_repository.GetById(id));
        }

        public void Insert(ProductViewModel ViewModel)
        {
            _repository.Add(_mapper.Map<Product>(ViewModel));
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(ProductViewModel ViewModel)
        {
            _repository.Update(_mapper.Map<Product>(ViewModel));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
