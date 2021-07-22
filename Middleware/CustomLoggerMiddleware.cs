using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Middleware
{
    public class CustomLoggerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("This is before request");
            await next(context);
            Console.WriteLine("This is after request");
        }
    }
}
