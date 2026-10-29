
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/hello", () =>
{
    return Results.Ok(new
    {
        message = "Hello from .NET Web API!",
        status = "Running"
    });
});

app.Run();
