using FluentResults;

namespace IDEODigital.Errors;

public class DuplicatedInvoice : IStatusCodeError
{
    public string Message { get; } = "The invoice with this Id already exists";
    public Dictionary<string, object> Metadata { get; }
    public List<IError> Reasons { get; }
    public int StatusCode { get; } = 409;
}