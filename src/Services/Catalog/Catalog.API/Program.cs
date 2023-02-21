using Catalog.API.Data;
using Catalog.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

/* Database Context Dependency Injection */
//var dbHost = "(localdb)\\MSSQLLocalDB";// Environment.GetEnvironmentVariable("DB_HOST");
//var dbName = "dms_customer";// Environment.GetEnvironmentVariable("DB_NAME");
//var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};Trusted_Connection=true";

builder.Services.AddDbContext<CatalogDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CatalogDBConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
