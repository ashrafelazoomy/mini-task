﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Infrastructure
{
   public interface IEngine
    {
        T Resolve<T>() where T : class;
        object Resolve(Type type);

        IEnumerable<T> ResolveAll<T>();

        object ManualResolve(Type type);
        void Initialize(IServiceCollection services);

        IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration);
    }
}
