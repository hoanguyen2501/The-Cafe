using CoffeeBook.Extensions;
using CoffeeBook.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddControllers();
    builder.Services.AddApplicationServices(builder.Configuration);
    builder.Services.AddIdentityServices(builder.Configuration);
    builder.Services.AddDependencyInjection();
}

var app = builder.Build();

{
    app.UseCors(options =>
    {
        options.AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .WithOrigins(new[] { "http://localhost:3000", "http://localhost:3001" });
    });

    //app.UseAuthentication();
    //app.UseAuthorization();

    app.UseMiddleware<ErrorHandlerMiddleware>();

    app.UseMiddleware<JwtMiddleware>();

    app.MapControllers();

    app.Run();
}