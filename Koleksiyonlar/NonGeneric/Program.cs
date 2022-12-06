using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable, ICollection
            //IDictionary
            //IList

            //ArrayList liste = new ArrayList();
            //liste.Add(1);
            //liste.Add("abc");
            //liste.Add(new ArrayList());
            //liste.Add(new Program());
            //liste.Add(true);

            //for (int i = 0; i < liste.Count; i++)
            //{
            //    //liste[i].GetType() listedeki değer tipini öğrenmek istediğimizde kullanılır.
            //    Console.WriteLine("Tipi : {0} Değeri : {1}",liste[i].GetType(),liste[i]);
            //}

            //Console.Write("Başlangıçta ");
            //Console.WriteLine("Kapasitesi : {0} Eleman sayısı : {1}",liste.Capacity,liste.Count);
            //liste.Add(1);
            //Console.Write("Bir eleman eklendi ");
            //Console.WriteLine("Kapasitesi : {0} Eleman sayısı : {1}", liste.Capacity, liste.Count);
            //liste.Add("abc");
            //Console.Write("ikinci eleman eklendi ");
            //Console.WriteLine("Kapasitesi : {0} Eleman sayısı : {1}", liste.Capacity, liste.Count);
            //liste.Add(new ArrayList());
            //Console.Write("üçüncü eleman eklendi");
            //Console.WriteLine("Kapasitesi : {0} Eleman sayısı : {1}", liste.Capacity, liste.Count);
            //liste.Add(new Program());
            //Console.Write("dördüncü eleman eklendi ");
            //Console.WriteLine("Kapasitesi : {0} Eleman sayısı : {1}", liste.Capacity, liste.Count);
            //liste.Add(true);
            //Console.Write("beşinci eleman eklendi ");
            //Console.WriteLine("Kapasitesi : {0} Eleman sayısı : {1}", liste.Capacity, liste.Count);

            SortedList s1 = new SortedList();
            s1.Add(1, "İlk Elaman");
            s1.Add(2, "İkinci Elaman");
            s1.Add(3, "Üçüncü Elaman");
            s1.Add(4, "Dördüncü Eleman");

            //string eleman = s1[3].ToString();
            //Console.WriteLine(eleman);

            //ICollection keys = s1.Keys;
            //foreach (var item in keys)
            //{
            //    Console.WriteLine(item);
            //}

            //if (s1.ContainsKey(1))
            //{
            //    Console.WriteLine(s1[1]);
            //}

            //foreach (DictionaryEntry item in s1)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", item.Key, item.Value);
            //}

            //Hashtable table = new Hashtable();
            //table.Add('A', "Ahmet");
            //table.Add('B', "Ali");
            //table.Add('C', "Osman");

            //foreach (DictionaryEntry item in table)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", item.Key, item.Value);
            //}

            Stack yigin = new Stack();//SON GİREN İLK ÇIKAR 
            //LAST İNPUT FİRST OUTPUT LIFO
            yigin.Push(1);
            yigin.Push(true);
            yigin.Push('A');

            char chr = (char)yigin.Pop();
            bool boo = (bool)yigin.Pop();

            int sayi = (int)yigin.Pop();

            Console.ReadKey();
        }
    }
}
