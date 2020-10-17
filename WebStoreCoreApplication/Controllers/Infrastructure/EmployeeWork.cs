using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreCoreApplication.Controllers.Infrastructure
{
    public class EmployeeWork
    {
        private const string correct = "qqq1234";
        public RequestDelegate Next { get; }

        public EmployeeWork(RequestDelegate next)
        {
            Next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["usertoken"];

            if (string.IsNullOrEmpty(token))
            {
                await Next.Invoke(context);
                return;
            }
            if (token == correct)
            {
                await Next.Invoke(context);
            }
            else
            {
                await context.Response.WriteAsync("BAAAADDDD!!!!");
            }
        }
        
    }
}
