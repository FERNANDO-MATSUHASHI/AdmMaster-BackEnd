using AdmMaster.Infra.MemoryDb.Interfaces;
using AdmMaster.Infra.MemoryDb.Repositories;
using Infra;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
//IOC - Dependency Injection
//Dependency Injection Repository
//builder.Services.AddScoped<IAlunoRepository, AlunoRepositorySqlServer>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IAtendimentoRepository, AtendimentoRepository>();
builder.Services.AddScoped<ICargoRepository, CargoRepository>();
builder.Services.AddScoped<ITipo_ServicoRepository, Tipo_ServicoRepository>();
builder.Services.AddScoped<ITipo_VeiculoRepository, Tipo_VeiculoRepository>();
builder.Services.AddScoped<ITipo_ViaturaRepository, Tipo_ViaturaRepository>();
builder.Services.AddScoped<INivelRepository, NivelRepository>();
builder.Services.AddScoped<IViaturaRepository, ViaturaRepositorySqlServer>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();

builder.Services.AddScoped<SqlContext, SqlContext>();

////Dependency Injection SqlContext
builder.Services.AddScoped<SqlContext, SqlContext>();

builder.Services.AddControllers().AddJsonOptions(x =>
   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

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
app.UseCors("corsapp");
app.UseAuthorization();
app.MapControllers();
app.Run();
app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});
