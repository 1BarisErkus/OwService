using ConsoleApp1.DatabaseOperations.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System.ServiceProcess;
using System.Windows.Input;
using VardabitService.DatabaseOperations.Concretes;

namespace VardabitService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddTransient<IStokService, StokManager>()
                                           .AddTransient<IVStokService, VStokManager>()
                                           .BuildServiceProvider();

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
