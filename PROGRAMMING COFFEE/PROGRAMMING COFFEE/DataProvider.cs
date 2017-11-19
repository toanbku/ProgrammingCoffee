using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMMING_COFFEE
{
    class DataProvider
    {
        // Connection String thiết lập các thông số để kết nối.
        public static string cnStr = @"Data Source=DESKTOP-EVHTUID\SQLEXPRESS;Initial Catalog=CoffeeProgram;Integrated Security=True";

        // Tạo kết nối
        public static SqlConnection cn = new SqlConnection(cnStr);

        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();
            cn = new SqlConnection(cnStr);
            SqlCommand cm = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }
        //insert, update, delete
        static public int Change(string sql)
        {
            cn = new SqlConnection(cnStr);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand(sql, cn);
            int kq = cm.ExecuteNonQuery();
            cn.Close();
            return kq;
        }
    }
}
