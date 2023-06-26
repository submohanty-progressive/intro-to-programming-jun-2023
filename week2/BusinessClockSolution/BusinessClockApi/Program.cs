

using BusinessClockApi.Models;
using BusinessClockApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<BusinessClockService>();
builder.Services.AddSingleton<ISystemTime, GmtSystemTime>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/status", (BusinessClockService service) =>
{
    var response = service.GetCurrentStatus();
    return Results.Ok(response);
});

app.Run();

