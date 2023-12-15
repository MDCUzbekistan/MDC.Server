using MDC.Server.Data.IRepositories;
using MDC.Server.Data.Repositories;
using MDC.Server.Service.Interfaces.CommunityRoles;
using MDC.Server.Service.Mappings;
using MDC.Server.Service.Services.CommunityRoles;

namespace MDC.Server.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // AutoMapper
        services.AddAutoMapper(typeof(MappingProfile));

        services.AddScoped<ICommunityRoleRepository, CommunityRoleRepository>();
        services.AddScoped<ICommunityRoleService, CommunityRoleService>();
    }
}
