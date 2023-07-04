namespace IDEODigital.Requests;

public record EditInvoiceRequest(Guid? Id, DateTime? Date, string? Status, double? Amount) : CommonInvoiceRequest(Date, Status, Amount);