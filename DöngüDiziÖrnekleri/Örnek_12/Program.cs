using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Örnek_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,3,5,A,a,X,4,T,t karakterlerini rasgele kullanarak 4 haneli bir güvenlik resmi oluşturan 
            //uygulamayı geliştirin.
            char[] karakteler = { '1', '3', '5', 'A', 'a', 'X', '4', 'T', 't' };

            string guvenlikResmi = "";
            while (guvenlikResmi.Length!=4)
            {
                Thread.Sleep(new Random().Next(0,100));//milisaniye 10000 milisaniye 1 saniye
                Random rnd = new Random();
                int rasgeleIndis = rnd.Next(0, karakteler.Length-1);
                guvenlikResmi += karakteler[rasgeleIndis];
            }
            Console.WriteLine("Güvenlik resmi : {0}", guvenlikResmi);
            Console.ReadKey();

        }
    }
}
