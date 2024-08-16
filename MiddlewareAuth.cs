using Microsoft.AspNetCore.Builder.Extensions;

namespace ProjectJ
{
    public class MiddlewareAuth
    {
        private readonly RequestDelegate _next;

        public MiddlewareAuth(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Lógica de autenticação ou outra lógica do middleware
            Console.WriteLine("MiddlewareAuth executando...");

            // Continue para o próximo middleware no pipeline
            await _next(context);
        }
    }
}

