using API.Entities;
using API.Extensions;
using DataAccess.Model;
using DataAccess.Utilis;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

// Early init of NLog to allow startup and exception logging, before host is built
//var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
//logger.Debug("init main");

//try
//{


var builder = WebApplication.CreateBuilder(args);


//NLog: setup NLog for dependency injection
builder.Logging.ClearProviders();
builder.Host.UseNLog();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

app.UseStaticFiles();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
try
{
    var context = services.GetRequiredService<ApplicationDbContext>();
    var userManager = services.GetRequiredService<UserManager<User>>();
    var roleManager = services.GetRequiredService<RoleManager<Role>>();
    await context.Database.MigrateAsync();
    await Seed.SeedUsers(userManager, roleManager);
}

catch (Exception ex)
{
    var logger = services.GetService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}




app.Run();
//}
//catch (Exception ex)
//{
//    logger.Error(ex);
//}
//finally
//{
//    LogManager.Shutdown();
//}