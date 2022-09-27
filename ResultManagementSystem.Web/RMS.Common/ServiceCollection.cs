using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Common
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddCommon(this IServiceCollection services)
        {
            AddRepository(services);
            return services;
        }

        private static void AddRepository(IServiceCollection services)
        {
        }
    }
}
