using WebAppPcto.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
string connString = builder.Configuration.GetConnectionString("Default") ?? "Application.db";
builder.Services.AddSqlite<AgenziaDbContext>(connString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseAuthorization();

app.MapControllers();
app.UseStaticFiles();
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/") { context.Response.Redirect("/index/index.html");
        return;
    }
    await next();
});
app.Run();
