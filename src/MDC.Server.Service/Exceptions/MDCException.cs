
namespace MDC.Server.Service.Exceptions;

public class MDCException:Exception
{
    public int StatusCode { get; set; }
    public MDCException(int code,string message):base(message)
    {
        StatusCode=code
    }
}
