using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class TimerViewModel : INotifyPropertyChanged
    {

        public TimerViewModel()
        {           
            t.Elapsed += new System.Timers.ElapsedEventHandler(timer_Tick);
            t.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (PropertyChanged != null) // Point 2
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Time"));

            }

        }

        System.Timers.Timer t = new System.Timers.Timer(1000);
        

        public string Time
        {
            get
            {
                return DateTime.Now.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
