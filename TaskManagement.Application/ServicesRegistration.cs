
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace TaskManagement.Application
{
    public static class ServiceRegistration
    {
        public static void AddServicesApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

        }
    }
}
