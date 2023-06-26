using CoffeeBook.Helpers;
using CoffeeBook.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CoffeeBook.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<JwtService>();
            // configure strongly typed settings object
            services.Configure<AppSetting>(configuration.GetSection("AppSettings"));

            var secretKey = configuration["AppSettings:Secret"];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        // Tự cấp token
                        ValidateIssuer = false,
                        ValidateAudience = false,

                        // Cấu hình cho sinh token
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes)
                    };
                });

            return services;
        }
    }
}