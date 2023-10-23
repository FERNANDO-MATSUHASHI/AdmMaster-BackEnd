using Application.Service.Application;
using Application.Service.Interface;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Infra;
using Infra.Interfaces;
using Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

//IOC Inversion of Control - Dependency Injection

//Dependency Injection Repository
builder.Services.AddScoped<IAtendimentoRepository, AtendimentoRepository>();
builder.Services.AddScoped<ICargoRepository, CargoRepository>();
builder.Services.AddScoped<INivelRepository, NivelRepository>();
builder.Services.AddScoped<ITipoServicoRepository, TipoServicoRepository>();
builder.Services.AddScoped<ITipoVeiculoRepository, TipoVeiculoRepository>();
builder.Services.AddScoped<ITipoViaturaRepository, TipoViaturaRepository>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IViaturaRepository, ViaturaRepository>();


//Dependency Injection Application
builder.Services.AddScoped<INivelApplication, NivelApplication>();
builder.Services.AddScoped<IAtendimentoApplication, AtendimentoApplication>();
builder.Services.AddScoped<ICargoApplication, CargoApplication>();
builder.Services.AddScoped<ITipoServicoApplication, TipoServicoApplication>();
builder.Services.AddScoped<ITipoVeiculoApplication, TipoVeiculoApplication>();


//Dependency Injection Service
builder.Services.AddScoped<INivelService, NivelService>();
builder.Services.AddScoped<IAtendimentoService, AtendimentoService>();
builder.Services.AddScoped<ICargoService, CargoService>();
builder.Services.AddScoped<ITipoServicoService, TipoServicoService>();
builder.Services.AddScoped<ITipoVeiculoService, TipoVeiculoService>();

////Dependency Injection SqlContext
builder.Services.AddScoped<SqlContext, SqlContext>();

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
