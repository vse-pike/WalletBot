using Microsoft.EntityFrameworkCore;
using WalletBot.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(o =>
    o.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Применение миграций
using (var serviceScope = app.Services.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationContext>();
    dbContext.Database.Migrate();
}

app.MapGet("/", () => "Hello World!");

app.Run();