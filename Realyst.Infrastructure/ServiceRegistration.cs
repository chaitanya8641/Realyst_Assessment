using Microsoft.Extensions.DependencyInjection;
using Realyst.Application.Contracts;
using Realyst.Dapper.Contracts;
using Realyst.Dapper.Services;
using Realyst.Infrastructure.Services;

namespace Realyst.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IDapperRepository, DapperRepository>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductCommentService, ProductCommentService>();
        }
       
    }
}
