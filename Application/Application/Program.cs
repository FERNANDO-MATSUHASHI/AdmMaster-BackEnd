using Application.Service.Application;
using Application.Service.Interface;
using Domain.Service;
using Domain.Service.Interfaces;
using Domain.Service.Services;
using Infra;
using Infra.Interfaces;
using Infra.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//Autorização para requisição CORs
//builder.Services.AddCors();

//builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
//{
//    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
//}));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", builder =>
        builder.WithOrigins("*")
               .AllowAnyMethod()
               .AllowAnyHeader());
});


var key = Encoding.ASCII.GetBytes(Settings.Secret);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

//IOC Inversion of Control - Dependency Injection
//Dependency Injection Repository
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
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
builder.Services.AddScoped<IUsuarioApplication, UsuarioApplication>();
builder.Services.AddScoped<INivelApplication, NivelApplication>();
builder.Services.AddScoped<IAtendimentoApplication, AtendimentoApplication>();
builder.Services.AddScoped<ICargoApplication, CargoApplication>();
builder.Services.AddScoped<ITipoServicoApplication, TipoServicoApplication>();
builder.Services.AddScoped<ITipoVeiculoApplication, TipoVeiculoApplication>();
builder.Services.AddScoped<ITipoViaturaApplication, TipoViaturaApplication>();
builder.Services.AddScoped<IUsuarioApplication, UsuarioApplication>();
builder.Services.AddScoped<IVeiculoApplication, VeiculoApplication>();
builder.Services.AddScoped<IViaturaApplication, ViaturaApplication>();
builder.Services.AddScoped<ICadastroAdminApplication, CadastroAdminApplication>();


//Dependency Injection Service
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<INivelService, NivelService>();
builder.Services.AddScoped<IAtendimentoService, AtendimentoService>();
builder.Services.AddScoped<ICargoService, CargoService>();
builder.Services.AddScoped<ITipoServicoService, TipoServicoService>();
builder.Services.AddScoped<ITipoVeiculoService, TipoVeiculoService>();
builder.Services.AddScoped<ITipoViaturaService, TipoViaturaService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddScoped<IViaturaService, ViaturaService>();
builder.Services.AddScoped<ICadastroAdminService, CadastroAdminService>();


////Dependency Injection SqlContext
builder.Services.AddScoped<SqlContext, SqlContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "AdmMaster API",
        Version = $"v1",
        Description = "API para consumo de dados do Front em Vue"
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"Autenticação por token JWT. Entre com o valor no formato: Bearer SEU_TOKEN",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

////Autorização para requisição CORs
//app.UseCors("corsapp");
//app.UseAuthorization();

//app.UseAuthentication();
//app.UseAuthorization();
app.UseCors("AllowSpecificOrigin");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

//app.UseCors(c =>
//{
//    c.AllowAnyHeader();
//    c.AllowAnyMethod();
//    c.AllowAnyOrigin();
//});
