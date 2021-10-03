using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Todo.UserInterface
{
    public class UserInterfaceWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<UserInterfaceWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}