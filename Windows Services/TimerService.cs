using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AmanMehara.Windows.Services
{
    public partial class TimerService : ServiceBase
    {
        private Timer timer;

        private Timer getTimer()
        {
            return timer;
        }

        private void setTimer(Timer timer)
        {
            this.timer = timer;
        }

        public TimerService()
        {
            InitializeComponent();
            setTimer(new Timer());
        }

        protected override void OnStart(string[] args)
        {
            Logger.Log("Timer Service Started", Logger.LogLevel.INFO);
            timer.Interval = 2 * 60 * 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            timer.Elapsed -= Timer_Elapsed;
            timer.Enabled = false;
            Logger.Log("Timer Service Stopped", Logger.LogLevel.INFO);

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Logger.Log(String.Format("The Elapsed event was raised at {0}", e.SignalTime), Logger.LogLevel.INFO);
        }
    }
}
