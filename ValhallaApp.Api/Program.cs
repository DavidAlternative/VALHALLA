using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using ValhallaApp.Application;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Infrastructure.Persistence;
using ValhallaApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFluentValidation();
builder.Services.AddApplicationServices();
builder.Services.AddDbContext<ValhallaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Valhalla")));

//User
builder.Services.AddTransient<IUserRepository,UserRepository>();
//Products
builder.Services.AddTransient<IProductsRepository,ProductsRepository>();
//Options
builder.Services.AddTransient<IOptionRepository,OptionRepository>();
//Category
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
//ConfiguratedProduct
builder.Services.AddTransient<IConfiguratedProductRepository, ConfiguratedProductRepository>();
//Configuration
builder.Services.AddTransient<IConfigurationRepository, ConfigurationRepository>();
//Orders
builder.Services.AddTransient<IOrderRepository, OrderRepository>();



builder.Services.AddCors(p => p.AddPolicy("ValhallaCors", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ValhallaCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
