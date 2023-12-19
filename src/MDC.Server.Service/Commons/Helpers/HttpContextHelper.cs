using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace MDC.Server.Service.Commons.Helpers;

public class HttpContextHelper
{
    public static IHttpContextAccessor Accessor { get; set; }
    public static HttpContext HttpContext => Accessor?.HttpContext;
    public static IHeaderDictionary ResponseHeaders => HttpContext?.Response?.Headers;
    public static string UserId => HttpContext?.User?.FindFirst("id")?.Value;
    public static string UserRole => HttpContext?.User?.FindFirst(ClaimTypes.Role)?.Value;
}
