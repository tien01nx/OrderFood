using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {       
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            });

            services.AddCors();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            services.AddScoped<ITokenRepository, TokenRepository>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}