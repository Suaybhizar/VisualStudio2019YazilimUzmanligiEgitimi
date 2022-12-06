using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskBaslatma
{
    class Program
    {
        private static readonly object _lock = new object();

        static void TekSay()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Monitor.Enter(_lock);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} ", i);
                    Monitor.Exit(_lock);
                }
                Thread.Sleep(30);
            }
        }

        static void CiftSay()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Monitor.Enter(_lock);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0} ", i);
                    Monitor.Exit(_lock);
                }
                Thread.Sleep(40);
            }
        }

        static int Topla()
        {
            int s1 = 10;
            int s2 = 5;
            Task.Delay(3000).Wait();
            return s1 + s2;
        }

        static void Main(string[] args)
        {
            //    Task tekTask = new Task(TekSay);
            //    Task ciftTask = new Task(CiftSay);

            //    tekTask.Start();
            //    tekTask.Wait();
            //    ciftTask.Start();

            //Task.Factory.StartNew(TekSay);
            //Task.Factory.StartNew(CiftSay);

            //Task.Run(TekSay);
            //Task.Run(CiftSay);




            //Task<int> toplaTask = Task.Run<int>(Topla);
            //Console.WriteLine("Task Başlatılıyor");
            //toplaTask.Start();
            //Console.WriteLine("Task Çalışıyor");
            //int sonuc = toplaTask.Result;
            // Console.WriteLine("Task {0} değerini üretti.", sonuc);

            Task<int> toplaTask = Task<int>.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);
                Task.Delay(3000).Wait();
                return 18;

            });
            int sonuc = toplaTask.Result;
            Console.WriteLine("Task sonucu : {0}", sonuc);



            Console.ReadKey();
        }
    }
}
