using System;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrasturcutre.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application layer
            services.AddScoped<ICourseService, CourseService>();

            // Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
