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
    public class CountryAppService : ICountryAppService
    {
        private readonly IMapper _mapper;
        private readonly ICountryRepository _repository;

        public CountryAppService(IMapper mapper, ICountryRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<CountryViewModel> GetAll()
        {
            return _repository.GetAll().ProjectTo<CountryViewModel>();
        }

        public CountryViewModel GetById(int id)
        {
            return _mapper.Map<CountryViewModel>(_repository.GetById(id));
        }

        public void Insert(CountryViewModel ViewModel)
        {
            _repository.Add(_mapper.Map<Country>(ViewModel));
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(CountryViewModel ViewModel)
        {
            _repository.Update(_mapper.Map<Country>(ViewModel));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
