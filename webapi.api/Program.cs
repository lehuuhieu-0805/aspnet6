using Microsoft.EntityFrameworkCore;
using webapi.business.Services;
using webapi.business.Services.Impl;
using webapi.data.Data;
using webapi.data.Repositories;
using webapi.data.Repositories.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddScoped<DbContext, DataContext>();
//Repositories
builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();

//Services
builder.Services.AddTransient<IApplicantService, ApplicantService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
