namespace IDEODigital.Models;

public record Invoice(Guid? Id)
{ 
    public DateTime? Date { get; set; }
    public double? Amount { get; set; }
    public string? Status { get; set; }
}