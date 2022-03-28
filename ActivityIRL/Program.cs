
using ActivityIRL.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer
    ("name=ConnectionStrings:DefaultConnection"));
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

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
app.UseRouting();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

//app.MapHub < something here > ("/");

app.Run();


//Jeg kan åbentbart ikke scaffold controllers lige nu. Idk why