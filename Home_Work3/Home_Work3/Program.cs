using Home_Work3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static List<Fork> fork = new List<Fork>();
        static List<Philosopher> philosopher = new List<Philosopher>();

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
                fork.Add(new Fork());
            for (int i = 0; i < 5; i++)
                philosopher.Add(new Philosopher((i + 1).ToString(), i));

            Thread t1 = new Thread(philosopher[0].Start);
            Thread t2 = new Thread(philosopher[1].Start);
            Thread t3 = new Thread(philosopher[2].Start);
            Thread t4 = new Thread(philosopher[3].Start);
            Thread t5 = new Thread(philosopher[4].Start);

            t1.Start(fork);
            t2.Start(fork);
            t3.Start(fork);
            t4.Start(fork);
            t5.Start(fork);
        }
    }    
}