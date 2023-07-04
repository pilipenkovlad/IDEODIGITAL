using IDEODigital.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IInvoicesService, InvoicesService>();


var app = builder.Build();
app.MapControllers();
app.Run();