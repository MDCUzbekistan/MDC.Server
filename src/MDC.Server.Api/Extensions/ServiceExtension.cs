using MDC.Server.Data.IRepositories;
using MDC.Server.Data.Repositories;
using MDC.Server.Service.Interfaces.Events;
using MDC.Server.Service.Mappers;
using MDC.Server.Service.Services.Events;

namespace MDC.Server.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile));
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IEventService, EventService>();
    }
}
