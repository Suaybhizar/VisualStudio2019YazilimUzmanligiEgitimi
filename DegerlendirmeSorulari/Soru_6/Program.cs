using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_6
{
    class Program
    {
        static T[] DiziOlustur<T>(int ElemanSayisi)
        {
            //         int[5]
            return new T[ElemanSayisi];
        }
        static void Main(string[] args)
        {
            char[] karakterler = DiziOlustur<char>(3);
            Console.WriteLine(karakterler.Length);

            Console.ReadKey();
        }
    }
}
