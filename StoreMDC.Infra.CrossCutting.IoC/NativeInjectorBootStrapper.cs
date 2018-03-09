using Microsoft.Extensions.DependencyInjection;
using StoreMDC.Domain.Interfaces.Repository;
using StoreMDC.Domain.Interfaces.Repository.Generics;
using StoreMDC.Infra.Data.Context;
using StoreMDC.Infra.Data.Repository;
using StoreMDC.Infra.Data.Repository.Generics;

namespace StoreMDC.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<StoreMDCContext>();
        }
    }
}
