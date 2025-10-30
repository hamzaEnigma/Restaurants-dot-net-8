﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicaiton(this IServiceCollection services)
        {
            var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddAutoMapper(applicationAssembly);
            services.AddValidatorsFromAssembly(applicationAssembly);
        }
    }
}
