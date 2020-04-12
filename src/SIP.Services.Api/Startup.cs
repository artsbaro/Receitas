using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DevWebReceitas.Infra.CrossCutting.IoC;
using Swashbuckle.AspNetCore.Swagger;
using Newtonsoft.Json;
using DevWebReceitas.Services.Api.OperationFilter;
using Microsoft.AspNetCore.ResponseCompression;

namespace DevWebReceitas.Services.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            //var builder = new ConfigurationBuilder()
            //.SetBasePath(env.ContentRootPath)
            //.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            //.AddEnvironmentVariables();

            //Configuration = builder.Build();

            Configuration = configuration;
        }

        

        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200",
                                        "http://www.contoso.com");
                });
            });

            //services.AddDistributedRedisCache(options =>
            //{
            //    options.Configuration = Configuration.GetConnectionString("RedisConnection");
            //    options.InstanceName = "Ingredientes:";
            //});

            services
                .AddMvc(options =>
                { options.OutputFormatters.Remove(new XmlDataContractSerializerOutputFormatter()); })
                .AddJsonOptions(options => options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore)
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.Configure<GzipCompressionProviderOptions>(
                o => o.Level = System.IO.Compression.CompressionLevel.Fastest);
            services.AddResponseCompression(
                o => o.Providers.Add<GzipCompressionProvider>());

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "DevWebReceitas Project",
                    Description = "DevWebReceitas API Swagger surface"
                });
                s.OperationFilter<FileUploadOperation>(); //Register File Upload Operation Filter
            });

            // .NET Native DI Abstraction
            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }


            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseSwagger();
                app.UseSwaggerUI(opt =>
                {
                    opt.SwaggerEndpoint("/swagger/v1/swagger.json", "DevWebReceitas Project V1");
                }); 
            }

            //app.UseStaticFiles();
            app.UseResponseCompression();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseMvc();
        }

        private static void RegisterServices(IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
