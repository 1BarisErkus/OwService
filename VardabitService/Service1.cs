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
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            timer = new Timer();
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Operations.WriteOnDbForStok();
        }

        protected override void OnStop()
        {

        }
    }
}
