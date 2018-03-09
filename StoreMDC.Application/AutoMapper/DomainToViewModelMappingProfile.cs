using AutoMapper;
using StoreMDC.Application.ViewModels;
using StoreMDC.Domain.Entities;

namespace StoreMDC.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<City, CityViewModel>();
            CreateMap<Country, CountryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<State, StateViewModel>();
            CreateMap<Store, StoreViewModel>();
        }
    }
}
