using RealEstateDapper.API.Models.DapperContext;
using RealEstateDapper.API.Repositories.AppUserRepositories;
using RealEstateDapper.API.Repositories.BottomGridRepository;
using RealEstateDapper.API.Repositories.CategoryRepository;
using RealEstateDapper.API.Repositories.ContactRepositories;
using RealEstateDapper.API.Repositories.EmplyeeRepository;
using RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.ChartRepositories;
using RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.LastProductsRepositories;
using RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.StatisticRepositories;
using RealEstateDapper.API.Repositories.MessageRepositories;
using RealEstateDapper.API.Repositories.PopularLocationRepository;
using RealEstateDapper.API.Repositories.ProductImageRepositories;
using RealEstateDapper.API.Repositories.ProductRepository;
using RealEstateDapper.API.Repositories.PropertyAmenityRepositories;
using RealEstateDapper.API.Repositories.ServiceRepository;
using RealEstateDapper.API.Repositories.StatisticsRepositories;
using RealEstateDapper.API.Repositories.SubFatureRepositories;
using RealEstateDapper.API.Repositories.TestimonialRepository;
using RealEstateDapper.API.Repositories.ToDoListRepositories;
using RealEstateDapper.API.Repositories.WhoWeAreDetailRepository;

namespace RealEstateDapper.API.Containers
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddTransient<Context>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IWhoWeAreDetailRepository, WhoWeAreDetailRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IBottomGridRepository, BottomGridRepository>();
            services.AddTransient<IPopularLocationRepository, PopularLocationRepository>();
            services.AddTransient<ITestimonialRepository, TestimonialRepository>();
            services.AddTransient<IEmplyeeRepository, EmplyeeRepository>();
            services.AddTransient<IStatisticsRepository, StatisticsRepository>();
            services.AddTransient<IContactRepository, ContacctRepository>();
            services.AddTransient<IToDoListRepository, ToDoListRepository>();
            services.AddTransient<IStatisticRepository, StatisticRepository>();
            services.AddTransient<IChartRepository, ChartRepository>();
            services.AddTransient<ILast5ProductsRepository, Last5ProductsRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IProductImageRepository, ProductImageRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IPropertyAmenityRepository, PropertyAmenityRepository>();
            services.AddTransient<ISubFeatureRepository, SubFeatureRepository>();
        }
    }
}
