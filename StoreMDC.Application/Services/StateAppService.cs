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
    public class StateAppService : IStateAppService
    {
        private readonly IMapper _mapper;
        private readonly IStateRepository _repository;

        public StateAppService(IMapper mapper, IStateRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<StateViewModel> GetAll()
        {
            return _repository.GetAll().ProjectTo<StateViewModel>();
        }

        public StateViewModel GetById(int id)
        {
            return _mapper.Map<StateViewModel>(_repository.GetById(id));
        }

        public void Insert(StateViewModel ViewModel)
        {
            _repository.Add(_mapper.Map<State>(ViewModel));
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(StateViewModel ViewModel)
        {
            _repository.Update(_mapper.Map<State>(ViewModel));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
