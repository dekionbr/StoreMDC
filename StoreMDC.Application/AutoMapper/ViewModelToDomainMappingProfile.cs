using AutoMapper;
using StoreMDC.Application.ViewModels;
using StoreMDC.Domain.Entities;

namespace StoreMDC.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<CityViewModel, City>();
            CreateMap<CountryViewModel, Country>();
            CreateMap<ProductViewModel, Product>();
            CreateMap<StateViewModel, State>();
            CreateMap<StoreViewModel, Store>();
        }
    }
}
