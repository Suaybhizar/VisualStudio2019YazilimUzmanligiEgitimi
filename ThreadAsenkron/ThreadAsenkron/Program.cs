using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadAsenkron
{
    class Program
    {
        private static object _Lock = new object();

        static void TekSay()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Monitor.Enter(_Lock);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0} ",i);
                    Monitor.Exit(_Lock);
                    Thread.Sleep(30); 
                }
            }
        }

        static void CiftSay()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Monitor.Enter(_Lock);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Monitor.Exit(_Lock);
                    Console.Write("{0} ",i);
                    Thread.Sleep(30);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread tekSay = new Thread(TekSay);
            Thread ciftSay = new Thread(CiftSay);

            tekSay.Priority = ThreadPriority.Highest;
            ciftSay.Priority = ThreadPriority.Lowest;

            tekSay.Start();
            //tekSay.Join();
            ciftSay.Start();

            Console.ReadKey();
        }
    }
}
