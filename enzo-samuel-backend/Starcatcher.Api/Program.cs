using Microsoft.EntityFrameworkCore;
using Starcatcher.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Infrastructure.Data;
using Starcatcher.Api.Application.Services;
using Starcatcher.Api.Infrastructure.Middleware;
using Starcatcher.Api.Common;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IQuotaRepository, QuotaRepository>();
builder.Services.AddScoped<IWalletRepository, WalletRepository>();
builder.Services.AddScoped<IConsortiumRepository, ConsortiumRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IQuotaService, QuotaService>();
builder.Services.AddScoped<IWalletService, WalletService>();
builder.Services.AddScoped<IConsortiumService, ConsortiumService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("JWT_SECRET") ?? "4d82a63bbdc67c1e4784ed6587f3730c"))
    };
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<UserUtils>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
    await dbContext.Database.MigrateAsync();
    await dbContext.SaveChangesAsync();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync();