using FluentResults;

namespace IDEODigital.Errors;

public class InvoiceNotFoundError : IStatusCodeError
{
    public string Message { get; } = "There is no invoice with this Id";
    public Dictionary<string, object> Metadata { get; }
    public List<IError> Reasons { get; }
    public int StatusCode { get; } = 404;
}