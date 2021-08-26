using System;
using CleanArchitecture.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Api.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArchitecture.Application.AutoMapper.AutoMapperConfiguration));

            AutoMapperConfiguration.RegisterMappings();

        }
    }
}
