using Microsoft.EntityFrameworkCore;
using SistemaDeVentas.Application.Services;
using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.Infraestructure.Context;
using SistemaDeVentas.Infraestructure.Repositories;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DBContext.
builder.Services.AddDbContext<DbContextSistema>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SistemaConnection"));
});

// Repository.
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IVentaRepository, VentaRepository>();
// Services.
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IVentaService, VentaService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DbContextSistema>();
    context.Database.Migrate();
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
