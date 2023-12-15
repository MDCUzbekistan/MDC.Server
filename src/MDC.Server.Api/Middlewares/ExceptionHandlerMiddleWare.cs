using MDC.Server.Api.Helpers;
using MDC.Server.Service.Exceptions;

namespace MDC.Server.Api.Middlewares
{
    public class ExceptionHandlerMiddleWare
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
         
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (MDCException ex)
            {
                context.Response.StatusCode = ex.StatusCode;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = ex.StatusCode,
                    Message = ex.Message
                });
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(new Response
                {
                    StatusCode = 500,
                    Message = ex.Message
                });
            }
        }
    }
}
