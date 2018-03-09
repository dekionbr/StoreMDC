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
    public class CityAppService : ICityAppService
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _repository;

        public CityAppService(IMapper mapper, ICityRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<CityViewModel> GetAll()
        {
            return _repository.GetAll().ProjectTo<CityViewModel>();
        }

        public CityViewModel GetById(int id)
        {
            return _mapper.Map<CityViewModel>(_repository.GetById(id));
        }

        public void Insert(CityViewModel ViewModel)
        {
            _repository.Add(_mapper.Map<City>(ViewModel));
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(CityViewModel ViewModel)
        {
            _repository.Update(_mapper.Map<City>(ViewModel));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
