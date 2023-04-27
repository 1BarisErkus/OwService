using System.ServiceProcess;
using System.Timers;
using VardabitService.DatabaseOperations;
using VardabitService.DatabaseOperations.Concretes;
using VardabitService.DatabaseOperations.Context;

namespace VardabitService
{
    public partial class Service1 : ServiceBase
    {
        Timer timer;
        MainDatabaseContext mainDatabaseContext;
        UsDatabaseContext usDatabaseContext;
        StokManager stokManager;
        VStokManager vstokManager;
        Operations operations;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            mainDatabaseContext = new MainDatabaseContext();
            usDatabaseContext = new UsDatabaseContext();
            stokManager = new StokManager(mainDatabaseContext);
            vstokManager = new VStokManager(usDatabaseContext);
            operations = new Operations(stokManager, vstokManager);

            timer = new Timer();
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            operations.WriteOnDbForStok();
        }

        protected override void OnStop()
        {

        }
    }
}
