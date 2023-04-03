using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
User JohnDoe = new ExpiredUser("John Doe",
                   new TVLicence (new DateTime(2008, 5, 1), STATUS.EXPIRED),
                   new Address (1, "Whoville Lane", "Whoville", "BT1 1JX", "Seuss Land"), 
                   "123456", false, 
                   new Fine (123.50, new DateTime(2021, 5, 1)), 
                   false);

ModelTesting.testProperties();


app.Run();
