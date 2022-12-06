using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueWithDeyimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //var task1 = Task.Run<int>(() =>
            //{
            //    return new Random().Next(0, 50);
            //});
            //var ilkSayi = task1.Result;

            //var task2 = Task<int>.Factory.StartNew(() =>
            //{
            //    return new Random().Next(ilkSayi, 100);
            //});

            //var sonSayi = task2.Result;

            var task1 = Task.Run<int>(() =>
            {
                return new Random().Next(0, 50);
            }).ContinueWith(t =>
            {
                return new Random().Next(t.Result, 100);
            });

            Console.WriteLine(task1.Result);

            Console.ReadKey();
        }
    }
}
