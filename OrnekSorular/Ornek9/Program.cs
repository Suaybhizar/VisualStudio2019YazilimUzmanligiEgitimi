using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından girilen bir sayının mutlak değerini alarak ekrana yazdıran uygulamayı geliştiriniz.
            //|a|  a>0=a  a<0=-a
            Console.Write("Mutlak değeri alınacak sayı : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int mutlakDeger;
            if (sayi < 0)
                mutlakDeger = -sayi;
            else
                mutlakDeger = sayi;

            Console.WriteLine("|{0}| = {1}",sayi,mutlakDeger);

            Console.ReadKey();

        }
    }
}
