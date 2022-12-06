using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTemelleri
{
    class Kisi
    {

        //Fields
        int id;
        string ad;
        string soyad;


        //Properties
        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }

        //Methods
        public string KisiBilgileriniGetir()
        {
            return string.Format("{0} - {1} {2}", Id, Ad, Soyad);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kisi kisi = new Kisi();
            //kisi.Ad = "Adı";
            //kisi.Soyad = "soyad";
            //kisi.Id = 1;
            //Console.WriteLine(kisi.KisiBilgileriniGetir());

            //Type type = kisi.GetType();// kullanalbilmek için sınıfın kurulu olması gereklidir.
            //Type type = Type.GetType("ReflectionTemelleri.Kisi,ReflectionTemelleri");
            //Type type = Assembly.GetExecutingAssembly().GetType("ReflectionTemelleri.Kisi");
            Type type = typeof(Kisi);
            ConstructorInfo ci = type.GetConstructor(Type.EmptyTypes);//default constructor için kullanılır.
            Kisi kisi = (Kisi)ci.Invoke(null);

            //var idField = type.GetField("id", BindingFlags.Instance | BindingFlags.NonPublic);
            //idField.SetValue(kisi, 1);

            //var adField = type.GetField("ad", BindingFlags.Instance | BindingFlags.NonPublic);
            //adField.SetValue(kisi, "Adımız");

            //var soyad = type.GetField("soyad", BindingFlags.Instance | BindingFlags.NonPublic);
            //soyad.SetValue(kisi, "Soyadımız");

            var adProp = type.GetProperty("Ad", BindingFlags.Instance | BindingFlags.Public);
            adProp.SetValue(kisi, "Adımız");

            var soyadProp = type.GetProperty("Soyad", BindingFlags.Instance | BindingFlags.Public);
            soyadProp.SetValue(kisi, "Soyadımız");

            var idProp = type.GetProperty("Id", BindingFlags.Instance | BindingFlags.Public);
            idProp.SetValue(kisi, 1);

            var kisiBilgileriMetod = type.GetMethod("KisiBilgileriniGetir");
            string sonuc = (string)kisiBilgileriMetod.Invoke(kisi, null);

            Console.WriteLine(sonuc);
            Console.WriteLine("--------------------------------");

            Type typeSql = typeof(SqlConnection);
            var properties = typeSql.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name);
            }

            Console.ReadKey();
        }
    }
}
