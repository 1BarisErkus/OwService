using ConsoleApp1.DatabaseOperations.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Timers;
using VardabitService.DatabaseOperations;
using VardabitService.DatabaseOperations.Concretes;
using VardabitService.DatabaseOperations.Context;

namespace ConsoleApp2
{
    internal class Program
    {
        static Timer timer;
        static MainDatabaseContext mainDatabaseContext;
        static UsDatabaseContext usDatabaseContext;
        static StokManager stokManager;
        static VStokManager vstokManager;
        static Operations operations;
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddTransient<IStokService, StokManager>()
                                           .AddTransient<IVStokService, VStokManager>()
                                           .BuildServiceProvider();


            mainDatabaseContext = new MainDatabaseContext();
            usDatabaseContext = new UsDatabaseContext();
            stokManager = new StokManager(mainDatabaseContext);
            vstokManager = new VStokManager(usDatabaseContext);
            operations = new Operations(stokManager, vstokManager);

            timer = new Timer();
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;

            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            operations.WriteOnDbForStok();
        }
    }
}
