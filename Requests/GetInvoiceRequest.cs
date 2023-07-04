using Microsoft.AspNetCore.Mvc;

namespace IDEODigital.Requests;

public record GetInvoiceRequest
{
    [FromQuery(Name = "invoiceId")]
    public Guid Id { get; set; }
}