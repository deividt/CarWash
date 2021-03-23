// ----------------------------------------------------------------------
// <copyright file="Program.cs" company="Deividt Gemeli">
// Copyright (c) Deividt Gemeli.
// </copyright>
// ----------------------------------------------------------------------

namespace CarWashAPI
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Classe <see cref="Program" />
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Método Main
        /// </summary>
        /// <param name="args">Parâmetro args</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Método CreateHostBuilder
        /// </summary>
        /// <param name="args">Parâmetro args</param>
        /// <returns>Retorna IHostBuilder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
