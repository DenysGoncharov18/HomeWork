using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Home_Work3
{
    public class Philosopher
    {
        bool isHunger = false;
        string philosopherName;
        int number;
        bool isDeath = false;

        public Philosopher(string Name, int number)
        {
            philosopherName = Name;
            this.number = number;
        }

        void GetFork(List<Fork> fork)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimer);
            timer.Interval = 3000;
            Console.WriteLine($"Philosopher {philosopherName} waiting forks");
            timer.Start();
            Monitor.Enter(fork);
            try
            {
                if (isDeath)
                    return;
                int first = number;
                int second = (number == fork.Count - 1) ? 0 : number + 1;
                if (!fork[first].IsUsing && !fork[second].IsUsing)
                {
                    Console.WriteLine($"Philosopher {philosopherName} getting forks ({timer.Enabled})");
                    timer.Stop();
                    timer.Dispose();
                    fork[first].IsUsing = true;
                    fork[second].IsUsing = true;
                    Console.WriteLine($"Philosopher {philosopherName} eating.", philosopherName);
                    Console.WriteLine($"Forks with numbers {first + 1} and {second + 1} are using." );
                    Thread.Sleep(250);
                    fork[first].IsUsing = false;
                    fork[second].IsUsing = false;
                }
            }
            finally
            {
                Monitor.Exit(fork);
            }
        }

        void OnTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
           
            Console.WriteLine($"Philosopher {philosopherName} is death!");
            
            isDeath = true;
            ((System.Timers.Timer)sender).Stop();
        }

        public void Start(object obj)
        {
            while (true)
            {
                Thread.Sleep(2000 + number * 1000);
                ChangeStatus();
                if (isHunger)
                    GetFork((List<Fork>)obj);
                if (isDeath)
                {
                    return;
                }
            }
        }

        void ChangeStatus()
        {
            isHunger = !isHunger;
            if (!isHunger)
                Console.WriteLine($"Philosopher {philosopherName} thinking.");
        }
    }
}
