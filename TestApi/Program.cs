using Microsoft.EntityFrameworkCore;
using TestApi.EF;

var builder = WebApplication.CreateBuilder(args);
var ConnctionString = builder.Configuration.GetConnectionString(name: "DefaultString")
    ?? throw new InvalidOperationException("No ConnectionString Was Found");
builder.Services.AddDbContext<ApplicationDbContext>(option =>
                                                    option.UseSqlServer(ConnctionString));
// Add services to the container.

builder.Services.AddControllers();
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

app.Run();
