namespace Learning_Concepts_of_ASPdotNET_Core.Middlewares
{
    public class CustomMiddleware2 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Pre-processing logic before the request reaches the controller
            Console.WriteLine("CustomMiddleware2: Before processing the request.");
            //Console.WriteLine($"Request Path: {context.Request.Path}");
            
            // Call the next middleware in the pipeline
            await next(context);
            
            // Post-processing logic after the response is generated
            Console.WriteLine("CustomMiddleware2: After processing the request.");
        }
    }
}
