using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı adı "admin" parolanında "12345" olduğu bilindiğine göre
            //kullanıcıdan alınacak kullanıcı adı ve parolanın doğru olması halinde 
            //"Sisteme giriş başarılı", aksi halde "Sisteme giriş başarısız" yazan uygulamayı geliştirin.
            Console.Write("Kullanıcı Adınız : ");
            string kullaniciadi = Console.ReadLine();
            Console.Write("Parolanız        : ");
            string parola = Console.ReadLine();

            if (kullaniciadi == "admin" && parola == "12345")
            Console.WriteLine("Sisteme giriş başarılı.");
            else
                Console.WriteLine("Sisteme giriş başarısız.");

            Console.ReadKey();
        }
    }
}
