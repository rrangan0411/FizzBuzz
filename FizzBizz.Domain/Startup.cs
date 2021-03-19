using FizzBizz.Domain.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBizz.Domain
{
    public static class Startup
    {
        public static void InitializeFizzBuzzDomain(this IServiceCollection services)
        {
            services.AddScoped<IFizzBizzDomain, FizzBizzDomain>();
        }
    }
}