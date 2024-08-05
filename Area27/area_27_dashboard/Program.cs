using area_27_dashboard.DB;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace area_27_dashboard
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder().Sources.
                      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                      .Build();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            
            new DbConnectionProvider(Configuration);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}