using MDC.Server.Service.Mappings;
using MDC.Server.Service.Services;
using MDC.Server.Data.Repositories;
using MDC.Server.Service.Interfaces;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Interfaces.CommunityRoles;
using MDC.Server.Service.Services.CommunityRoles;
using MDC.Server.Data.IRepositories.Languages;
using MDC.Server.Data.Repositories.Languages;
using MDC.Server.Service.Interfaces.Communities;
using MDC.Server.Service.Interfaces.Events;
using MDC.Server.Service.Interfaces.Languages;
using MDC.Server.Service.Services.Events;
using MDC.Server.Service.Services.Languages;

namespace MDC.Server.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));

        // Repository
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IUserEventRepository, UserEventRepository>();
        services.AddScoped<IEventRoleRepository, EventRoleRepository>();
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        // Services
        services.AddScoped<IUserEventService, UserEventService>();
        services.AddScoped<IEventRoleService, EventRoleService>();
        services.AddScoped<ICommunityRoleRepository, CommunityRoleRepository>();
        services.AddScoped<ICommunityRoleService, CommunityRoleService>();
      
        // Generic Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        //User
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        // UserDetail
        services.AddScoped<IUserDetailRepository, UserDetailRepository>();  
        services.AddScoped<IUserDetailService, UserDetailService>();  

        //Language
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();

        // Communities
        services.AddScoped<ICommunityService,CommunityService>();
        services.AddScoped<ICommunityRepository, CommunityRepository>();

        // Events
        services.AddScoped<IEventService, EventService>();
        services.AddScoped<IEventRepository, EventRepository>();

        // EventAssets
        services.AddScoped<IEventAssetService, EventAssetService>();
        services.AddScoped<IEventAssetReposiytory, EventAssetRepository>();


    }
}
