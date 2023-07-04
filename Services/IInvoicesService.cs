using FluentResults;
using IDEODigital.Models;
using IDEODigital.Requests;

namespace IDEODigital.Services;

public interface IInvoicesService
{
    public List<Invoice> GetInvoices();
    public Result<Invoice> GetInvoice(GetInvoiceRequest request);
    public Result<Invoice> CreateInvoice(CreateInvoiceRequest request);
    public Result<Invoice> EditInvoice(EditInvoiceRequest request);
}