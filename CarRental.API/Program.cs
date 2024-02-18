using CarRental.Business.Implementations;
using CarRental.Business.Interfaces;
using CarRental.Data;
using CarRental.Data.Implementations;
using CarRental.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<CarrentalContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IVehicleRepository, VehicleRepository>();
builder.Services.AddTransient<IVehicleBusiness, VehicleBusiness>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
