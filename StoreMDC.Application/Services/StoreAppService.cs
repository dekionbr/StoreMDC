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
    public class StoreAppService : IStoreAppService
    {
        private readonly IMapper _mapper;
        private readonly IStoreRepository _repository;

        public StoreAppService(IMapper mapper, IStoreRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<StoreViewModel> GetAll()
        {
            return _repository.GetAll().ProjectTo<StoreViewModel>();
        }

        public StoreViewModel GetById(int id)
        {
            return _mapper.Map<StoreViewModel>(_repository.GetById(id));
        }

        public void Insert(StoreViewModel ViewModel)
        {
            _repository.Add(_mapper.Map<Store>(ViewModel));
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(StoreViewModel ViewModel)
        {
            _repository.Update(_mapper.Map<Store>(ViewModel));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
