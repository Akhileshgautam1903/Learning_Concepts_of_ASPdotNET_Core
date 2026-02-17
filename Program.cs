var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 1: Before");
    await next(context);
    Console.WriteLine("Middleware 1: After");
});

app.Use(async (context, next) =>
{
    Console.WriteLine("Middleware 2: Before");
    await next(context);
    Console.WriteLine("Middleware 2: After");
});

//app.Run(async (context) => await context.Response.WriteAsync("Terminated successfully!!"));

app.MapControllers();

app.Run();
