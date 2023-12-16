using MDC.Server.Data.IRepositories;
using MDC.Server.Data.Repositories;
using MDC.Server.Service.Interfaces;
using MDC.Server.Service.Mappings;
using MDC.Server.Service.Services.Users;

namespace MDC.Server.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));

        // UserDetail
        services.AddScoped<IUserDetailRepository, UserDetailRepository>();
        services.AddScoped<IUserDetailService, UserDetailService>();

        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

    }
}
