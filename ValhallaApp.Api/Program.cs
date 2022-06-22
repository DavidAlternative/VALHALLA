using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using ValhallaApp.Application;
using ValhallaApp.Application.Interfaces;
using ValhallaApp.Application.Services;
using ValhallaApp.Domain.Interfaces;
using ValhallaApp.Infrastructure.Persistence;
using ValhallaApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "https://localhost:44363",
        ValidAudience = "https://localhost:44363",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("v1d1g17dghf56g4d6gfd84gdd56fg4dfgddfg8"))
    };
});
builder.Services.AddFluentValidation();
builder.Services.AddApplicationServices();
builder.Services.AddDbContext<ValhallaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Valhalla")));
//Repositories
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

//Services
//User
builder.Services.AddTransient<IUserService, UserService>();
//Product
builder.Services.AddTransient<IProductService, ProductService>();
//Order
builder.Services.AddTransient<IOrderService, OrderService>();
//Option
builder.Services.AddTransient<IOptionService, OptionService>();
//Configuration
builder.Services.AddTransient<IConfigurationService, ConfigurationService>();
//ConfigiratedProduct
builder.Services.AddTransient<IConfiguratedProductService, ConfiguratedProductService>();
//Category
builder.Services.AddTransient<ICategoryService, CategoryService>();




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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
