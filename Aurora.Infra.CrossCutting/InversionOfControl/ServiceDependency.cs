using Aurora.Domain.Interfaces;
using Aurora.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Aurora.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        // Injeção de dependência
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceWorker, WorkerService>();
        }
    }
}
