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
    public class UrunBusiness
    {
        public static List<Urun> UrunleriGetir()
        {
            string sqlstr = "select P.ProductID,P.ProductName,C.CategoryName,P.UnitsInStock,P.UnitPrice,C.CategoryID from Products P inner join Categories C on P.CategoryID = C.CategoryID";
            SqlDataReader okuyucu = Helper.ExecuteReader(sqlstr, CommandType.Text);
            List<Urun> urunler = new List<Urun>();
            while (okuyucu.Read())
            {
                urunler.Add(new Urun
                {

                    UrunId = okuyucu.GetInt32(0),
                    UrunAdi = okuyucu.GetString(1),
                    KategoriAdi = okuyucu.GetString(2),
                    StokAdedi = okuyucu.GetInt16(3),
                    BirimFiyati = okuyucu.GetDecimal(4),
                    // KategoriId=okuyucu.GetInt32(5)

                });


            }
            okuyucu.Close();
            return urunler;
        }

        public static int UrunGuncelle(int urunId, string urunAdi, object kategoriId, string birimfiyati, string stokAdedi)
        {
            string sql = string.Format("update Products set ProductName='{0}',CategoryID={1},UnitPrice={2},UnitsInStock={3} where ProductID={4}",
                urunAdi, kategoriId, birimfiyati, stokAdedi, urunId);
            return Helper.ExecuteNonQuery(sql, CommandType.Text);
        }

        public static int UrunEkle(string urunAdi, object kategoriId, string birimfiyati, string stokAdedi)
        {
            string sql = string.Format("insert into Products(ProductName,CategoryID,UnitPrice,UnitsInStock) values('{0}',{1},{2},{3})", urunAdi, kategoriId, birimfiyati, stokAdedi);
            return Helper.ExecuteNonQuery(sql, CommandType.Text);
        }

        public static int UrunSil(int urunId)
        {
            string sql = string.Format("delete Products where ProductID={0}", urunId);
            return Helper.ExecuteNonQuery(sql, CommandType.Text);
        }
    }
}
