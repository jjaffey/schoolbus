﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SchoolBusClient.Handlers
{
    public class SwaggerProxyMiddleware : ProxyMiddlewareBase<SwaggerProxyServerOptions>
    {
        public SwaggerProxyMiddleware(RequestDelegate next, IOptions<SwaggerProxyServerOptions> serverOptions, ILoggerFactory loggerFactory) 
            : base(next, serverOptions, loggerFactory)
        {
        }
    }
}

