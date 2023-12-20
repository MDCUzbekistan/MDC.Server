using MDC.Server.Service.Mappings;
using MDC.Server.Service.Services;
using MDC.Server.Data.Repositories;
using MDC.Server.Service.Interfaces;
using MDC.Server.Data.IRepositories;
using MDC.Server.Service.Services.Users;
using MDC.Server.Service.Services.Events;
using MDC.Server.Service.Interfaces.Users;
using MDC.Server.Service.Interfaces.Events;
using MDC.Server.Service.Services.Languages;
using MDC.Server.Data.Repositories.Languages;
using MDC.Server.Data.IRepositories.Languages;
using MDC.Server.Service.Interfaces.Languages;
using MDC.Server.Service.Interfaces.Communities;
using MDC.Server.Service.Services.CommunityRoles;
using MDC.Server.Service.Services.UserCommunities;
using MDC.Server.Service.Interfaces.CommunityRoles;



namespace MDC.Server.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // Repository
        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<IUserEventRepository, UserEventRepository>();
        services.AddScoped<IEventRoleRepository, EventRoleRepository>();
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
        services.AddScoped<IUserLanguageRepository, UserLanguageRepository>();

        // Services
        services.AddScoped<IUserEventService, UserEventService>();
        services.AddScoped<IEventRoleService, EventRoleService>();
        services.AddScoped<ICommunityRoleRepository, CommunityRoleRepository>();
        services.AddScoped<ICommunityRoleService, CommunityRoleService>();

        // Generic Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        // User
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();

        // UserDetail
        services.AddScoped<IUserDetailRepository, UserDetailRepository>();
        services.AddScoped<IUserDetailService, UserDetailService>();

        // Language
        services.AddScoped<ILanguageService, LanguageService>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();

        // Communities
        services.AddScoped<ICommunityService, CommunityService>();
        services.AddScoped<ICommunityRepository, CommunityRepository>();

        // Events
        services.AddScoped<IEventService, EventService>();
        services.AddScoped<IEventRepository, EventRepository>();

        // EventAssets
        services.AddScoped<IEventAssetService, EventAssetService>();
        services.AddScoped<IEventAssetReposiytory, EventAssetRepository>();

        // UserCommunities
        services.AddScoped<IUserCommunityService, UserCommunityService>();
        services.AddScoped<IUserCommunityRepository, UserCommunityRepository>();

    }
}
