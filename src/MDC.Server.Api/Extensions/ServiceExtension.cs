using MDC.Server.Data.IRepositories;
using MDC.Server.Data.IRepositories.Languages;
using MDC.Server.Data.Repositories;
using MDC.Server.Data.Repositories.Languages;
using MDC.Server.Service.Interfaces.Communities;
using MDC.Server.Service.Interfaces.Languages;
using MDC.Server.Service.Interfaces.Users;
using MDC.Server.Service.Mappings;
using MDC.Server.Service.Services;
using MDC.Server.Service.Services.Users;
using MDC.Server.Service.Services.Languages;

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

        //Communities
        services.AddScoped<ICommunityService,CommunityService>();
        services.AddScoped<ICommunityRepository, CommunityRepository>();
    }
}
