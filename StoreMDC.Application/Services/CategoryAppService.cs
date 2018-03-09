using System.Collections.Generic;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.ViewModels;
using StoreMDC.Domain.Entities;
using AutoMapper;
using StoreMDC.Domain.Interfaces.Repository;
using AutoMapper.QueryableExtensions;
using System;

namespace StoreMDC.Application.Services
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryAppService(IMapper mapper, ICategoryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        
        public IEnumerable<CategoryViewModel> GetAll()
        {
            return _repository.GetAll().ProjectTo<CategoryViewModel>();
        }

        public CategoryViewModel GetById(int id)
        {
            return _mapper.Map<CategoryViewModel>(_repository.GetById(id));
        }

        public void Insert(CategoryViewModel ViewModel)
        {
            _repository.Add(_mapper.Map<Category>(ViewModel));
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(CategoryViewModel ViewModel)
        {
            _repository.Update(_mapper.Map<Category>(ViewModel));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
