// ----------------------------------------------------------------------
// <copyright file="Startup.cs" company="Deividt Gemeli">
// Copyright (c) Deividt Gemeli.
// </copyright>
// ----------------------------------------------------------------------

namespace CarWashAPI
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;

    /// <summary>
    /// Classe <see cref="Startup" />
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Inicia uma nova instância da classe <see cref="Startup" />
        /// </summary>
        /// <param name="configuration">Parâmetro IConfiguration</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Obtém um valor que indica se Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Método Services
        /// This method gets called by the runtime. Use this method to add services to the container
        /// </summary>
        /// <param name="services">Parâmetro IServiceCollection</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CarWashAPI", Version = "v1" });
            });
        }

        /// <summary>
        /// Método Configure
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        /// </summary>
        /// <param name="app">Parâmetro app</param>
        /// <param name="env">Parâmetro env</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarWashAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
