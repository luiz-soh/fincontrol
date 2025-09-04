using Application.Category;
using Domain.Entities.Category;
using Infra.Configuration;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetSection("ConnectionString").Value ?? string.Empty;

builder.Services.AddDbContext<ContextBase>(options =>
        options.UseNpgsql(connectionString));

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

if (builder.Environment.IsDevelopment())
{
    await using var scope = app.Services.CreateAsyncScope();
    using var dbApplication = scope.ServiceProvider.GetService<ContextBase>();
    await dbApplication!.Database.MigrateAsync();
}

app.Run();
