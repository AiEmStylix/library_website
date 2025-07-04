using library_api.Data;
using library_api.DTOs;
using library_api.Endpoints;
using library_api.Interfaces;
using library_api.Repositories;
using library_api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres")));

builder.Services.AddScoped<IBookRepository, BookRepository>(); 
builder.Services.AddScoped<IBookService, BookServices>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IAuthorService, AuthorServices>();


var app = builder.Build();

app.UseHttpsRedirection();

app.MapAuthorEndpoints();
app.MapBookEndpoints();

app.Run();
