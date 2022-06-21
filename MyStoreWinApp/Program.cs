

using Microsoft.Extensions.Configuration;

namespace MyStoreWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IConfiguration Configuration;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}