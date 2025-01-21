using Serilog;

namespace akmsservice.Extensions
{
    public static class SerilogLoggingExtensions
    {
        public static void AddSerilogLogging(this WebApplicationBuilder builder)
        {
            // Configure Serilog from appsettings.json and additional settings
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .WriteTo.File("Logs/log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            // Replace default logging with Serilog
            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog();
            builder.Host.UseSerilog(); // Ensure the host uses Serilog
        }
    }
}
