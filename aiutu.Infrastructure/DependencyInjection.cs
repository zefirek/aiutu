using aiutu.Domain.Interfaces;
using aiutu.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace aiutu.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IKontrahentRepository, KontrahentRepository>();
            services.AddTransient<IPojazdRepository, PojazdRepository>();
            return services;
        }
    }
}
