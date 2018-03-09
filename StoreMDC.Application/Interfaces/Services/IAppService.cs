using System;
using System.Collections.Generic;

namespace StoreMDC.Application.Interfaces.Services
{
    public interface IAppService<TViewModel> : IDisposable where TViewModel : class
    {
        IEnumerable<TViewModel> GetAll();

        TViewModel GetById(int id);

        void Insert(TViewModel ViewModel);

        void Remove(int id);

        void Update(TViewModel ViewModel);
    }
}
