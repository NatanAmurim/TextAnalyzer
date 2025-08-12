using TextAnalyzer.Api.Application.Handlers;
using TextAnalyzer.Api.Application.Handlers.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AddApplicationServices(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void AddApplicationServices(IServiceCollection services)
{
    services.AddScoped<TextAnayzerHandler>();
    services.AddScoped<IWordExtractorHandler, WordExtractorHandler>();    
}

