using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExtensionMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            int sayi = str.ToInt32();

            byte sayimiz = 120;

            int[] sayilar = new int[]
            {
                10,3,5,50,20,15,1
            };

            List<double> sayilar2 = new List<double>
            {
                10,3,5,50,20,15,1
            };

            Console.WriteLine("En bÜyük Eleman : {0}",sayilar.EnBuyuk());

           // Console.WriteLine(sayimiz.AralikTesti<byte>(50, 100)); 


            int testSayi = 25;
            //Console.WriteLine(testSayi.CiftMi());

            //Console.WriteLine(sayi+3);

            Console.ReadKey();
            
        }
    }

    public static class EkMetotlar
    {
        public static int ToInt32(this string s)
        {
            return Convert.ToInt32(s);
        }

        public static bool CiftMi(this int sayi)
        {
            return sayi % 2 == 0;
        }

        public static bool AralikTesti<T>(this T sayi,T kSayi,T bSayi)
            where T:IComparable<T>
        {
            if (sayi.CompareTo(kSayi) >= 0 && sayi.CompareTo(bSayi) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static T EnBuyuk<T>(this IEnumerable<T> elemanlar)
       where T : IComparable
        {
            T enb = default(T);
            foreach (var item in elemanlar)
            {
                if (item.CompareTo(enb) >= 0)
                    enb = item;
            }
            return enb;
        }
    }
   
}
