using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetConsole
{
    internal class Program
    {
        //Ado.Net kullanarak Veritabanına Erişim
        //DRY -> Dont repeat yourself

        static SqlConnection BaglantiOlustur()
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=true");
            return con;
        }

        static int EkleSilGuncelle(string sqlStr, SqlParameter[] parameters)
        {
            SqlConnection con = BaglantiOlustur();
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            // cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            if(parameters != null)
                cmd.Parameters.AddRange(parameters);
            int kayitSayisi = 0;
            try
            {
                con.Open();
                kayitSayisi = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

            return kayitSayisi;

        }

        static SqlDataReader Listele(string sqlStr, SqlParameter[] parameters)
        {
            SqlConnection con = BaglantiOlustur();
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            //cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            if(parameters != null)
                cmd.Parameters.AddRange(parameters);
            SqlDataReader okuyucu = null;
            try
            {
                con.Open();
                okuyucu = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return okuyucu;


        }

        static void Main(string[] args)
        {
            char secim;

            do
            {
                Console.Clear();
                Console.WriteLine("İşlem Tipi");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1-Kayıt Ekleme");
                Console.WriteLine("2-Katıt Güncelleme");
                Console.WriteLine("3-Kayıt Sil");
                Console.WriteLine("4-Kayıt Listesi");
                Console.WriteLine("-Çıkış için <ESC>-");
                Console.WriteLine();
                Console.Write("Seçiminiz : ");


                //Kullanıcını Tercihi alınıyor.
                secim = Console.ReadKey().KeyChar;
                switch (secim)
                {
                    case '1':
                        //Kayıt eklenecek
                        Console.Clear();
                        Console.Write("Kategori Adı : ");
                        string kategoriAdi = Console.ReadLine();
                        Console.Write("Açıklama     : ");
                        string aciklama = Console.ReadLine();
                        string sqlInsStr = "KategoriEkle";
                        SqlParameter[] parametersIns = new SqlParameter[] {
                        new SqlParameter("@CatName",kategoriAdi),
                        new SqlParameter("@Desc",aciklama),
                        new SqlParameter("@CatID",SqlDbType.Int)
                        };

                        //  string sqlInsStr = string.Format("insert into Categories(CategoryName,Description) values('{0}','{1}')",
                        //    kategoriAdi, aciklama);
                        //Console.WriteLine("{0} adet kayıt eklendi. Devam Etmek için bir tuşa basın", EkleSilGuncelle(sqlInsStr,parameters));
                        parametersIns[2].Direction = ParameterDirection.ReturnValue;
                        EkleSilGuncelle(sqlInsStr, parametersIns);
                        //return parametresinin değerine ulaşalım
                        Console.WriteLine("Yeni bir kategori eklendi. Kategoriye {0} id değeri verildi.Devam etmek için bir tuşa basın ", 
                            parametersIns[2].Value);
                        Console.ReadKey();
                        break;
                    case '2':
                        //Kayıt güncellenecek
                        Console.Clear();
                        Console.Write("Güncellenecek Kategori No : ");
                        string upId = Console.ReadLine();
                        Console.Write("Kategorinin Yeni adı      : ");
                        string kategoriYeniAdi = Console.ReadLine();
                        Console.Write("Yeni Açıklama             : ");
                        string yeniAciklama = Console.ReadLine();
                        //  string sqlUpStr = string.Format("update Categories set CategoryName='{0}',Description='{1}' where CategoryID={2}", kategoriYeniAdi, yeniAciklama, upId);
                        string sqlUpStr = "KategoriGuncelle";
                        SqlParameter[] parametersUp = new SqlParameter[] { 
                        new SqlParameter("@CategoryID",upId),
                        new SqlParameter ("@CategoryName",kategoriYeniAdi),
                        new SqlParameter ("@Description",yeniAciklama)
                        };
                        //Console.WriteLine("{0} adet kayıt güncellendi. Devam Etmek için bir tuşa basın", EkleSilGuncelle(sqlUpStr));
                        Console.WriteLine("{0} adet kayıt güncellendi. Devam Etmek için bir tuşa basın",
                            EkleSilGuncelle(sqlUpStr,parametersUp));
                        Console.ReadKey();
                        break;


                    case '3':
                        //Kayıt silinecek
                        Console.Clear();
                        Console.Write("Silinecek Kategori no : ");
                        string delId = Console.ReadLine();
                        // string sqlDelStr = String.Format("delete Categories where CategoryID={0}", delId);
                        string sqlDelStr = "KategoriSil";
                        SqlParameter[] parametersDel = new SqlParameter[] { 
                        new SqlParameter("@CategoryID",delId),
                        new SqlParameter("@Result",SqlDbType.Int)
                        };
                        parametersDel[1].Direction = ParameterDirection.ReturnValue;
                        EkleSilGuncelle(sqlDelStr,parametersDel);
                        if(parametersDel[1].Value.ToString() == "0")
                            Console.Write("Bu kategoride kayıtlı ürünler olduğundan silme işlemi yapılamadı.");
                            else
                            Console.Write("Kategori Başarıyla silindi.");
                        // Console.WriteLine("{0} adet kayıt silindi. Devam Etmek için bir tuşa basın", EkleSilGuncelle(sqlDelStr));
                        Console.WriteLine("Devam Etmek için bir tuşa basınız.");
                        Console.ReadKey();
                        break;
                    case '4':
                        //Kayıtlar listelenecek
                        Console.Clear();
                        // SqlDataReader okuyucum = Listele("select CategoryID,CategoryName,Description from Categories");
                        SqlDataReader okuyucum = Listele("KategorileriGetir", null);
                        while (okuyucum.Read())
                        {
                            int id = okuyucum.GetInt32(okuyucum.GetOrdinal("CategoryID"));
                            string name = okuyucum.GetString(okuyucum.GetOrdinal("CategoryName"));
                            string desc = okuyucum.IsDBNull(okuyucum.GetOrdinal("Description")) ? "Belirtilmemiş" :
                                okuyucum.GetString(okuyucum.GetOrdinal("Description"));
                            Console.WriteLine("{0,-5}{1,-20}{2}", id, name, desc);

                        }
                        okuyucum.Close();
                        Console.WriteLine("Menüye Dönmek İçin Bir Tuşa Basın.");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            } while (secim != (char)27);
        }
    }
}
