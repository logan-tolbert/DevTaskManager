using DevTaskManager.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DevTaskDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
    
var app = builder.Build();


app.MapGet("/", () => "Dev Task Manager API is running");

app.Run();
