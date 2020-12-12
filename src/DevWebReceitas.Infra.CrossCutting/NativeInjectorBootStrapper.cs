using DevWebReceitas.Application.Mappers.Receitas;
using DevWebReceitas.Domain.Interfaces.Repositories;
using DevWebReceitas.Domain.Services;
using DevWebReceitas.Domain.Services.Interfaces;
using DevWebReceitas.Infra.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DevWebReceitas.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        static string _applicationName = "DevWebReceitas";

        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Mappers
            services.AddSingleton<IReceitaEditDtoMapper, ReceitaEditDtoMapper>();
            services.AddSingleton<IReceitaDtoMapper, ReceitaDtoMapper>();
            services.AddSingleton<IReceitaMapper, ReceitaMapper>();


            SetAssemblies();

            services.RegisterRepositories()
                .RegisterDomainServices()
                .RegisterApplicationServices()
                .RegisterMappers();
        }

        static List<Assembly> _assemblies;
        static void SetAssemblies()
        {
            _assemblies = AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(a => a.GetName().Name.Contains(_applicationName))
            .ToList();
        }

        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            // Infra - Data
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            return services;
        }

        public static IServiceCollection RegisterDomainServices(this IServiceCollection services)
        {

            //DomainServices            
            services.AddScoped<IReceitaDomainService, ReceitaDomainService>();
            services.AddScoped<ICategoriaDomainService, CategoriaDomainService>();

            return services;
        }

        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            //AppServices
            //services.AddScoped<IReceitaService, ReceitaService>();
            //services.AddScoped<ICategoriaService, CategoriaService>();

            var assem = _assemblies.FirstOrDefault(x => x.FullName.Contains($"{_applicationName}.Application"));

            //List<Type> list = new List<Type>();


            //var allProviderTypes = assems.Select(x => 
            //    x.GetTypes()
            //    .Where(y => 
            //        y.Namespace != null &&
            //        !y.IsAbstract &&
            //        y.Namespace.Contains($"{_applicationName}.Domain.Services")));

            var allProviderTypes = assem
                .GetTypes().Where(t => t.Namespace != null
                                && t.Namespace.Contains($"{_applicationName}.Application"));

            foreach (var intfc in allProviderTypes.Where(t => t.IsInterface))
            {
                var impl = allProviderTypes.FirstOrDefault(c => c.IsClass && intfc.Name.Substring(1) == c.Name);
                if (impl != null) services.AddScoped(intfc, impl);
            }

            return services;
        }

        public static IServiceCollection RegisterMappers(this IServiceCollection services)
        {
            return services;
        }
    }
}
