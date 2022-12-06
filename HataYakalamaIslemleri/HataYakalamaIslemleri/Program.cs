using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYakalamaIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;

            try
            {
                int b = 5 / a;
                string str = "123";
                int c = Convert.ToInt32(str);
                int[] sayilar = { 1, 2, 3, 4, 5 };
                int sayi = sayilar[3];
                //throw new InvalidCastException();
            }
            catch (DivideByZeroException dbzEx)
            {
                Console.WriteLine("Bir Değişkeni sıfıra bölmeye çalıştınız");   
            }
            catch(FormatException fEx)
            {
                Console.WriteLine("Tür dönüşüm işleminde bir hata  var.");
            }
            catch(IndexOutOfRangeException orEx)
            {
                Console.WriteLine("Yazdığınız index değerine karşılık gelen bir eleman yok");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Tanımlanamayan bir hata oluştu. "+ex.Message);
            }
            finally
            {
                Console.WriteLine("Hata olsun veya olmasın çalışan kod. ");
            }

            Console.WriteLine("Bu mesaj try-catch bloğundan sonra geliyor.");

            


            Console.ReadKey();
        }
    }
}
