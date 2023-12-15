
namespace MDC.Server.Service.Exceptions;

public class MDCException:Exception
{
    public int StatusCode { get; set; }
    public MDCException(int code,string message):base(message)
    {
<<<<<<< HEAD
        StatusCode=code
=======
        StatusCode = code;
>>>>>>> 93938f27e57f27554ffe3a8504c55fd4a45dd8eb
    }
}
