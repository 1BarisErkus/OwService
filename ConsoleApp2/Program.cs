using ConsoleApp2.Entities.Models.MainDatabase;
using ConsoleApp2.Repositories.Concretes;
using ConsoleApp2.Repositories.Concretes.MainDatabase;
using ConsoleApp2.Repositories.Concretes.UsDatabase;
using ConsoleApp2.Repositories.Contracts;
using ConsoleApp2.Repositories.Contracts.MainDatabase;
using ConsoleApp2.Repositories.Contracts.UsDatabase;
using ConsoleApp2.Services.Concretes;
using ConsoleApp2.Services.Concretes.MainDatabase;
using ConsoleApp2.Services.Concretes.UsDatabase;
using ConsoleApp2.Services.Contracts;
using ConsoleApp2.Services.Contracts.MainDatabase;
using ConsoleApp2.Services.Contracts.UsDatabase;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Timers;

namespace ConsoleApp2
{
    public class Program
    {
        private static IOperations operations;
        static Timer timer;
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddScoped<IStokService, StokManager>()
                .AddScoped<IVStokService, VStokManager>()
                .AddScoped<IOperations, Operations>()
                .AddScoped<IRepositoryManager, RepositoryManager>()
                .AddScoped<IStokRepository, StockRepository>()
                .AddScoped<IVStokRepository, VStokRepository>()
                .AddScoped<IServiceManager, ServiceManager>()
                .AddScoped<IServiceManager, ServiceManager>()
                .BuildServiceProvider();

            timer = new Timer();
            timer.Interval = 10000;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;

            operations = serviceProvider.GetRequiredService<IOperations>();

            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            operations.WriteOnDbForStok();
        }
    }
}
