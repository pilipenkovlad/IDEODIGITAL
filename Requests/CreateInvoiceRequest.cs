namespace IDEODigital.Requests;

public record CreateInvoiceRequest(DateTime? Date, string? Status, double? Amount) : CommonInvoiceRequest(Date, Status, Amount);