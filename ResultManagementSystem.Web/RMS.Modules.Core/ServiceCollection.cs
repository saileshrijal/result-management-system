using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Modules.Core
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            AddRepository(services);
            return services;
        }

        private static void AddRepository(IServiceCollection services)
        {
        }
    }
}
