using exercise.wwwapi.Repository;
using exercise.wwwapi.Data;
using exercise.wwwapi.Models;
using exercise.wwwapi.EndPoint;
using exercise.wwwapi.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository<Student>, StudentRepository>();
builder.Services.AddScoped<IRepository<Language>, LanguageRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

StudentEndpoints.Initialize(app);
LanguageEndpoints.Initialize(app);
BookEndpoints.Initialize(app);

app.Run();

