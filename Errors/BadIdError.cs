using FluentResults;

namespace IDEODigital.Errors;

public class BadIdError : IStatusCodeError
{
    public string Message { get; } = "there is no Invoice Id in the request or it's invalid.";
    public Dictionary<string, object> Metadata { get; }
    public List<IError> Reasons { get; }
    public int StatusCode { get; } = 400;
}