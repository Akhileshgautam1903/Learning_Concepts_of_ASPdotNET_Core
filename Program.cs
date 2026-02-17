using Learning_Concepts_of_ASPdotNET_Core.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<CustomMiddleware2>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 1: Before");
    await next(context);
    Console.WriteLine("Middleware 1: After");
});

app.UseMiddleware<CustomMiddleware1>();

app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 2: Before");
    await next(context);
    Console.WriteLine("Middleware 2: After");
});

app.UseMiddleware<CustomMiddleware2>();

//app.Run(async (context) => await context.Response.WriteAsync("Terminated successfully!!"));

app.MapControllers();

app.Run();
