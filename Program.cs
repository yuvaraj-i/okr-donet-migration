using helloWorld.DBContex;
using helloWorld.Repositories;
using helloWorld.Services;
using helloWorld.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var log = new LoggerConfiguration()
    .WriteTo.Console()
    //WriteTo.("log.txt")
    .CreateLogger();

builder.Logging.AddSerilog(log);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization using bearer scheme (\"Bearer {token}\" ) ",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    c.OperationFilter<SecurityRequirementsOperationFilter>();
});

builder.Services.AddDbContext<AppDbContex>(options =>
{
    var connString = builder.Configuration.GetConnectionString("Default");
    options.UseMySql(connString, ServerVersion.AutoDetect(connString));
});

builder.Services.AddScoped<AppDbContex>();
builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IObjectiveService, ObjectiveService>();
builder.Services.AddScoped<IDashboardReposistory, DashboardReposistory>();
builder.Services.AddScoped<IObjectiveReposistory, ObjectiveReposistory>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillSetMappingRepository, SkillSetMappingRepository>();

builder.Services.AddSingleton<IJwtTokenUtils, JwtTokenUtils>();


builder.Services.AddAuthentication(Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
    options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("my favourite token is here thank you")),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

builder.Host.UseSerilog();

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
