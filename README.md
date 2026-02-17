# Learning_Concepts_of_ASPdotNET_Core

## Middlewares in ASP.NET Core
Middlewares are components that are assembled into an application pipeline to handle requests and responses. 
Each component chooses whether to pass the request to the next component in the pipeline and can perform operations before and after the next component is invoked. 
This allows for a modular approach to handling cross-cutting concerns such as authentication, logging, and error handling.

### Types of Middlewares
1. **Built-in Middlewares**: ASP.NET Core provides a variety of built-in middlewares for common tasks such as routing, authentication, and static file serving. Ex. `app.UseRouting()`, `app.UseAuthentication()`, `app.UseStaticFiles()`.
3. **Custom Middlewares**: Developers can create their own custom middlewares to handle specific requirements of their application. Ex. creating a middleware to log request and response details.
4. **Inline Middlewares**: These are defined directly within the program.cs file using lambda expressions, allowing for quick and easy middleware definitions without the need for separate classes. Ex. `app.Use(async (context, next) => { /* middleware logic */ await next.Invoke(); });`
5. **Terminal Middlewares**: These are middlewares that do not call the next middleware in the pipeline, effectively terminating the request processing. Ex. `app.Run(async context => { /* terminal middleware logic */ });`

## Inline Middlewares
Inline middlewares are defined directly within the program.cs file using lambda expressions.
Using .Use() method, you can create an inline middleware that executes custom logic before and after the next middleware in the pipeline.
```
app.Use(async (context, next) =>
{
	// Code to execute before the next middleware
	await next.Invoke();
	// Code to execute after the next middleware
});
```

Using .Run() method, you can create a terminal middleware that executes custom logic and does not call the next middleware in the pipeline.
```
app.Run(async context =>
{
	// Code to execute in the terminal middleware
});
```

## What I Learned
- I learned about the concept of middlewares in ASP.NET Core and how they are used to handle requests and responses in a modular way.
- I learned about the different types of middlewares, including built-in, custom, inline, and terminal middlewares.
- I learned how to create inline middlewares using the .Use() method and terminal middlewares using the .Run() method in the program.cs file.
- I also learned about the importance of middlewares in handling cross-cutting concerns such as authentication, logging, and error handling in ASP.NET Core applications.
- Overall, I gained a deeper understanding of how middlewares work in ASP.NET Core and how they can be used to enhance the functionality and maintainability of web applications.

