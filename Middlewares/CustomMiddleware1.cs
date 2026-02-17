namespace Learning_Concepts_of_ASPdotNET_Core.Middlewares
{
    public class CustomMiddleware1
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware1(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            // Pre-processing logic before the request reaches the controller
            Console.WriteLine("CustomMiddleware1: Before processing the request.");
            //Console.WriteLine($"Request Path: {context.Request.Path}");
            
            // Call the next middleware in the pipeline
            await _next(context);
            
            // Post-processing logic after the response is generated
            Console.WriteLine("CustomMiddleware1: After processing the request.");
        }
    }
}
