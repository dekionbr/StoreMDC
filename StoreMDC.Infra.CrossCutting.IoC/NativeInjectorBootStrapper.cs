using Microsoft.Extensions.DependencyInjection;
using StoreMDC.Application.Interfaces.Services;
using StoreMDC.Application.Services;
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

            // Application
            services.AddScoped<ICategoryAppService, CategoryAppService>();
            services.AddScoped<ICityAppService, CityAppService>();
            services.AddScoped<ICountryAppService, CountryAppService>();
            services.AddScoped<IProductAppService, ProductAppService>();
            services.AddScoped<IStateAppService, StateAppService>();
            services.AddScoped<IStoreAppService, StoreAppService>();

            // Infra - DATA
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<IStoreRepository, StoreRepository>();
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<StoreMDCContext>();
        }
    }
}
