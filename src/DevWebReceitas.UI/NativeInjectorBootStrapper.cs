using DevWebReceitas.Application.Interfaces;
using DevWebReceitas.Application.Mappers.Receitas;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DevWebReceitas.UI
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Mappers
            services.AddSingleton<IReceitaEditDtoMapper, ReceitaEditDtoMapper>();
            services.AddSingleton<IReceitaDtoMapper, ReceitaDtoMapper>();
            services.AddSingleton<IReceitaMapper, ReceitaMapper>();

            LoadAllAssemblies();

            services.RegisterRepositories()
                .RegisterDomainServices()
                .RegisterApplicationServices()
                .RegisterMappers();
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            var types = typeof(IRepository<,>)
                .FindInAssembly(x => x.GetName().Name == "DevWebReceitas.Infra.Data");

            foreach (var type in types)
                services.AddScoped(type.Key, type.Value);

            return services;
        }

        public static IServiceCollection RegisterDomainServices(this IServiceCollection services)
        {
            var types = typeof(IDomainService<,>)
                .FindInAssembly(x => x.GetName().Name == "DevWebReceitas.Domain.Services");

            foreach (var type in types)
                services.AddScoped(type.Key, type.Value);

            return services;
        }

        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            var types = typeof(IServiceBase<>)
                .FindInAssembly(x => x.GetName().Name == "DevWebReceitas.Application");

            foreach (var type in types)
                services.AddScoped(type.Key, type.Value);

            return services;
        }

        public static IServiceCollection RegisterMappers(this IServiceCollection services)
        {
            return services;
        }

        #region Helpers

        private static Dictionary<Type, Type> FindInAssembly(this Type type, Func<Assembly, bool> predicate)
        {
            return AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(predicate)
                .SelectMany(x => x.GetExportedTypes())
                .Where(x =>
                    x.IsClass
                    && !x.IsAbstract
                    && x.GetInterfaces().Any()
                    && (
                        // Generic Type.
                        x.GetInterfaces().Any(i =>
                            i.IsGenericType
                            && i.GetGenericTypeDefinition() == type
                        )
                        // Non-Generic Type.
                        || !x.GetInterfaces().Any(i => i.IsGenericType)
                    )
                ).ToDictionary(
                    x => x
                        .GetInterfaces()
                        .Where(i => !i.IsGenericType)
                        .OrderByDescending(i => i.GetInterfaces().Length)
                        .First(),
                    x => x
                );
        }

        private static void LoadAllAssemblies()
        {
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var loadedPaths = loadedAssemblies.Select(a => a.Location).ToArray();

            var referencedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
            var toLoad = referencedPaths.Where(r => !loadedPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase)).ToList();

            toLoad.ForEach(path => loadedAssemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(path))));
        }

        #endregion
    }
}
