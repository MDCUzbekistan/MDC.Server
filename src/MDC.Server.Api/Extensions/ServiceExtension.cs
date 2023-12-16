using MDC.Server.Service.Mappings;
using MDC.Server.Service.Services;
using MDC.Server.Data.Repositories;
using MDC.Server.Service.Interfaces;
using MDC.Server.Data.IRepositories;

namespace MDC.Server.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile));

        // Repository
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IUserEventRepository, UserEventRepository>();
        services.AddScoped<IEventRoleRepository, EventRoleRepository>();
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        //Services
        services.AddScoped<IUserEventService, UserEventService>();
        services.AddScoped<IEventRoleService, EventRoleService>();
    }
}
