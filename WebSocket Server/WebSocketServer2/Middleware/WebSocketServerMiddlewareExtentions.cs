using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebSocketServer2.Middleware
{
    public static class WebSocketServerMiddlewareExtentions
    {
        public static IApplicationBuilder UseWebsocketServer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<WebSocketServerMiddleware>();
        }

        public static IServiceCollection AddWebsocketManager(this IServiceCollection services)
        {
            services.AddSingleton<WebsocketServerConnectionManager>();
            return services;
        }
    }
}
