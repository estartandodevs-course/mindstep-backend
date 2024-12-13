using mindstep.api.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;

builder.Services.AddSwaggerConfiguration();
builder.Services.AddApiConfiguration(configuration);

var app = builder.Build();

app.UseApiConfiguration();

app.Run();