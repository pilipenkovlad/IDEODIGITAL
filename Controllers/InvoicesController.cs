using FluentResults;
using IDEODigital.Errors;
using IDEODigital.Requests;
using IDEODigital.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace IDEODigital.Controllers;

[ApiController]
[Route("invoices")]
public class InvoicesController : ControllerBase
{
    private readonly IInvoicesService invoicesService;
    
    public InvoicesController(IInvoicesService invoicesService)
    {
        this.invoicesService = invoicesService;
    }

    [HttpGet("all")]
    public ActionResult GetInvoices()
    {
        return Ok(invoicesService.GetInvoices());
    }
    
    [HttpGet]
    public ActionResult GetInvoice([FromQuery]GetInvoiceRequest request)
    {
        var result = invoicesService.GetInvoice(request);
        if (result.IsFailed)
        {
            var error = result.Errors.First() as IStatusCodeError;
            return Problem(statusCode: error.StatusCode, detail: error.Message);
        }

        return Ok(result.Value);    }
    
    [HttpPatch]
    public ActionResult EditInvoices([FromBody] EditInvoiceRequest request)
    {
        var result = invoicesService.EditInvoice(request);
        if (result.IsFailed)
        {
            var error = result.Errors.First() as IStatusCodeError;
            return Problem(statusCode: error.StatusCode, detail: error.Message);
        }

        return Ok(result.Value);
    }
    
    [HttpPost]
    public async Task<ActionResult> CreateInvoices([FromBody] CreateInvoiceRequest request)
    {
        var result = invoicesService.CreateInvoice(request);
        if (result.IsFailed)
        {
            var error = result.Errors.First() as IStatusCodeError;
            return Problem(statusCode: error.StatusCode, detail: error.Message);
        }

        return Ok(result.Value);
    }
}