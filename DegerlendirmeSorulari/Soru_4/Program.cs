using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    class Program
    {
      
        static int Faktoryel(int n)
        {
            
            if (n == 0)
                return 1;
           
            return  n * Faktoryel(n - 1);
            
        }

      
        static void Main(string[] args)
        {
            //Kendisine gönderilen sayının faktöryelini hesaplayan recursive metodu geliştiriniz.
            //faktöryel
            //5!=5*4*3*2*1
            //3!=3*2*1


             Console.Write("Faktöryeli alınacak sayı :");
             int sayi = int.Parse(Console.ReadLine());
             Console.WriteLine("{0}! = {1}", sayi, Faktoryel(sayi));
            

          /* 
            Console.WriteLine("1! + 2! + 3! + . . . + n! İşleminin Sonucu :");
            Console.Write("n değerini giriniz :");
            int n = int.Parse(Console.ReadLine());
            int toplam=0;
            for (int k = 1; k <=n; k++)
            {
                toplam += Faktoryel(k);
            }
            Console.WriteLine("Sonuç : {0}",toplam);
           */
            Console.ReadKey();

        }
    }
}
