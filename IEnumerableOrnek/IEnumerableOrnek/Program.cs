using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 1, 2, 3, 4 };
            //int[] sayilar = new int[4];
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            //sayilar[2] = 3;
            //sayilar[3] = 4;

            //Array.Resize(ref sayilar, sayilar.Length + 1);
            //sayilar[4] = 5;
            ////Array
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            Liste liste = new Liste();
            liste.Add(1);
            liste.Add(2);
            liste.Add(3);
            liste.Add(4);

            liste[0] = 5;

            //for (int i = 0; i < liste.Lenght; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator numeraator = liste.GetEnumerator();
            while (numeraator.MoveNext())
            {
                int item = (int)numeraator.Current;
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class Liste:IEnumerable
    {
        int[] items = new int[1];

        bool isFirstİtem = true;

        public int Lenght
        {
            get
            {
                return items.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public void Add(int item)
        {
            if (isFirstİtem) //Eklenen eleman ilk eleman
            {
                items[0] = item;
                isFirstİtem = false;
            }
            else //Eklenen eleman ilk elemandan sonraki elemanlar
            {
                Array.Resize(ref items, items.Length + 1);
                items[items.Length - 1] = item;
            }
        }

        public int[] GetItems()
        {
            return items;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
