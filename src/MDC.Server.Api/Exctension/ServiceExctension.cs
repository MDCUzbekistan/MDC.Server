using MDC.Server.Service.Services;
using MDC.Server.Data.Repositories;
using MDC.Server.Data.IRepositories;
using MDC.Server.Domain.Entities.Communities;
using MDC.Server.Service.Interfaces.Community;

namespace MDC.Server.Api.Exctension;

public static  class ServiceExctension
{
    public static void AddCustomerService(this IServiceCollection service)
    {
        service.AddScoped(typeof(IRepository<Community,long>), typeof(Repository<Community,long>));
        

        service.AddScoped<ICommunityService,CommunityService>();
        service.AddScoped<ICommunityRepository,CommunityRepository>();

    }
}
