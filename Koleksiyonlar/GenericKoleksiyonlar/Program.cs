using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<char> karakter = new List<char> 
            //{
            //    'A','B','C','1'
            //};
            //karakter.Add('D');
            //karakter.Remove('A');
            //karakter.RemoveAt(1);
            //karakter.Clear();
            //for (int i = 0; i < karakter.Count; i++)
            //{
            //    Console.WriteLine(karakter[i]);
            //}

            //SortedList<int, string> sl = new SortedList<int, string>();
            //sl.Add(5, "abc");
            //sl.Add(2, "def");
            //sl.Add(1, "ghı");

            //foreach (KeyValuePair<int, string> item in sl)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}",item.Key,item.Value);
            //}


            //Dictionary<int, string> sl = new Dictionary<int, string>();
            //sl.Add(5, "abc");
            //sl.Add(2, "def");
            //sl.Add(1, "ghı");

            //foreach (KeyValuePair<int, string> item in sl)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", item.Key, item.Value);
            //}

            Stack<int> yigin = new Stack<int>();//LIFO
            yigin.Push(1);

            Queue<string> kuyruk = new Queue<string>();//FIFO
            kuyruk.Enqueue("a2");


            Console.ReadKey();

        }
    }
}
