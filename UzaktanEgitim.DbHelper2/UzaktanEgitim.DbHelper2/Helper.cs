using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzaktanEgitim.DbHelper2
{ //CRUD
  //create
  //read
  //update
  //delete
    public class Helper
    {


        private static string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

        public static int ExecuteNonQuery(string sqlstr, CommandType cmdType, SqlParameter[] parameters = null)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = cmdType;
            if (cmdType == CommandType.StoredProcedure)
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
            }
            int numRows = 0;
            try
            {
                con.Open();
                numRows = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return numRows;
        }

        public static SqlDataReader ExecuteReader(string sqlstr, CommandType cmdType, SqlParameter[] parameters = null)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = cmdType;
            if (cmdType == CommandType.StoredProcedure)
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
            }
            SqlDataReader reader = null;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                throw ex;
            }
            return reader;

        }

        //tek bir satır sorgu döndüren fonksiyon sonucu 5,10,15 gibi tek bir deger dönemsi gereklidir.
        public static object ExecuteScalar(string sqlstr, CommandType cmdType, SqlParameter[] parameters = null)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            cmd.CommandType = cmdType;
            if (cmdType == CommandType.StoredProcedure)
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
            }
            object result = null;
            try
            {
                con.Open();
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return result;

        }
    }
}

