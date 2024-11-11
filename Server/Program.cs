var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapGet("/henk/{message}", (string message) => $"Henk says \"{message}\"!");
app.UseCors(config =>
{
    config.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
});
app.Run();
