namespace IDEODigital.Requests;

public abstract record CommonInvoiceRequest(DateTime? Date, string? Status, double? Amount);
