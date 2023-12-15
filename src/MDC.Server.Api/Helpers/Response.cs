namespace MDC.Server.Api.Helpers;

public class Response
{
    public int StatusCode = 200;
    public string Message { get; set; }
    public object Data { get; set; }
}
