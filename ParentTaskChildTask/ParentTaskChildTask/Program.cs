using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentTaskChildTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = Task.Factory.StartNew(() =>
             {
                 Console.WriteLine("Parent Task Başladı.");
                 Task.Factory.StartNew(() =>
                 {
                     Console.WriteLine("Child Task Başladı.");
                     Task.Delay(3000).Wait();
                     Console.WriteLine("Child Task Sonlandı.");
                 },TaskCreationOptions.AttachedToParent);
                 Console.WriteLine("Parent Task Sonlandı.");
             });

            parent.Wait();
        }
    }
}
