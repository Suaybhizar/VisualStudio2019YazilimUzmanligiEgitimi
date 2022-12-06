using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.DbHelper2;
using UzaktanEgitim.WpfApp2.Models;

namespace UzaktanEgitim.WpfApp2.Business
{
    public class KategoriBusiness
    {
        public static List<Kategori> KategorileriGetir()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlDataReader okuyucu = Helper.ExecuteReader("select CategoryID,CategoryName from Categories", CommandType.Text);
            while (okuyucu.Read())
            {
                kategoriler.Add(new Kategori
                {
                    KategoriId = okuyucu.GetInt32(0),
                    KategoriAdi = okuyucu.GetString(1),

                });
            }
            okuyucu.Close();
            return kategoriler;
        }
        public static int KategoriAdinaIdGetir(string KategoriAdi)
        {
            string sql = string.Format("select CategoryID from Categories where CategoryName='{0}'", KategoriAdi);
            object kategoriId = Helper.ExecuteScalar(sql, CommandType.Text);
            return Convert.ToInt32(kategoriId);
        }
    }
}
