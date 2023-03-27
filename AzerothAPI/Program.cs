using AzerothAPI.Auth.Utils;
using AzerothAPI.Data.Context;
using AzerothAPI.Helpers;
using AzerothAPI.Middleware;
using AzerothAPI.Services;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ConfigurationManager config = builder.Configuration;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => options.OperationFilter<AddAccessToken>(config));

CSVLoader.LoadAll();

var allowOrigins = "_allowOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(allowOrigins,
        builder =>
        {
            builder.WithOrigins("*")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});

// Databases
Func<DbContextOptionsBuilder, string, DbContextOptionsBuilder> setupDbService = (o, c) =>
{
    var connection = config.GetConnectionString(c);
    var serverVersion = ServerVersion.AutoDetect(config.GetConnectionString(c));
    return o.UseMySql(connection, serverVersion);
};    
builder.Services.AddDbContext<AuthDb>(o => setupDbService(o, "auth_database"));
builder.Services.AddDbContext<CharDb>(o => setupDbService(o, "char_database"));
builder.Services.AddDbContext<WorldDb>(o => setupDbService(o, "world_database"));
builder.Services.AddDbContext<BlogDb>(o => setupDbService(o, "blog_database"));

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders =
        ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
});

// configure DI for application services
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<IServerService, ServerService>();
builder.Services.AddScoped<IBlogService, BlogService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseForwardedHeaders();

app.UseCors(allowOrigins);

app.UseAuthorization();

app.UseMiddleware<ApiKeyMiddleware>();

app.MapControllers();

app.Run();
