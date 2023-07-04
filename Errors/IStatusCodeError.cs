using FluentResults;

namespace IDEODigital.Errors;

public interface IStatusCodeError : IError
{
    public int StatusCode { get; }
}