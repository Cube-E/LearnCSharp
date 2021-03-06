using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;
using PersonalDataLibrary.Validators;
using System;
using System.Windows.Forms;

namespace PharmaUi
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceCollection = new ServiceCollection ();
            ConfigureServices (serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider ();

            SignUpForm form = serviceProvider.GetService<SignUpForm> ();
            Application.Run(form);
        }

        private static void ConfigureServices (ServiceCollection service) {
            Action<ILoggingBuilder> configure = Configure;
            service.AddLogging (configure);
            service.Configure<LoggerFilterOptions> (ConfigureLogging);
            service.AddTransient<PersonalDataValidator> ();
            service.AddTransient<SignUpForm> ();
        }

        private static void Configure(ILoggingBuilder iloggingBuilder) {
            iloggingBuilder.AddConsole ();
            iloggingBuilder.AddDebug ();
        }

        private static void ConfigureLogging (LoggerFilterOptions options) {
            options.AddFilter<DebugLoggerProvider> (null /* category*/ , LogLevel.Information /* min level */);
            options.AddFilter<ConsoleLoggerProvider> (null  /* category*/ , LogLevel.Warning /* min level */);
        }
    }
}
