using MDC.Server.Service.Mappings;
using MDC.Server.Service.Services.Languages;
using MDC.Server.Service.Services.Users;

namespace MDC.Server.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));

        // Generic Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        //User
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        //Language
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IEventService, EventService>();
    }
}
