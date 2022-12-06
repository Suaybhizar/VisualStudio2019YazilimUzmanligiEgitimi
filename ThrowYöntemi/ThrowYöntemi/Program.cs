using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowYöntemi
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            try
            {
                a.MetodA();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }

    class A : B
    {
        public void MetodA()
        {
            try
            {
                MetodB();
            }
            catch (Exception gelenEx)
            {
                throw gelenEx;
                
            }
        }
    }
    class B
    {
        public void MetodB()
        {
            int x = 0;

            try
            {
                int y = 5 / x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
