using FluentResults;
using IDEODigital.Errors;
using IDEODigital.Models;
using IDEODigital.Requests;

namespace IDEODigital.Services;

public class InvoicesService : IInvoicesService
{
    private static Dictionary<Guid, Invoice> Storage = new ();

    public List<Invoice> GetInvoices()
    {
        return Storage.Values.ToList();
    }

    public Result<Invoice> GetInvoice(GetInvoiceRequest request)
    {
        if (request == null || request.Id == Guid.Empty)
        {
            return Result.Fail<Invoice>(new BadIdError());
        }

        if (!Storage.ContainsKey(request.Id))
        {
            return Result.Fail<Invoice>(new InvoiceNotFoundError());
        }

        return Result.Ok(Storage[request.Id]);
    }

    public Result<Invoice> CreateInvoice(CreateInvoiceRequest request)
    {
        var id = Guid.NewGuid();
        var invoice = new Invoice(id){Amount = request.Amount, Date = request.Date, Status = request.Status};
        Storage[id] = invoice;
        return Result.Ok(invoice);
    }

    public Result<Invoice> EditInvoice(EditInvoiceRequest request)
    {
        if (request == null || request.Id == null || request.Id == Guid.Empty)
        {
            return Result.Fail<Invoice>(new BadIdError());
        }

        if (!Storage.ContainsKey(request.Id.Value))
        {
            return Result.Fail<Invoice>(new InvoiceNotFoundError());
        }

        var invoice = Storage[request.Id.Value];
        
        if (request.Date != null)
            invoice.Date = request.Date;

        if (request.Status != null)
            invoice.Status = request.Status;
        
        if (request.Amount != null)
            invoice.Amount = request.Amount;

        return Result.Ok(invoice);
    }
}