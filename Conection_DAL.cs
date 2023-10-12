using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.SqlClient;
namespace QLNS_DAL
{
    public class Conection_DAL
    {
      
        public static SqlConnection Connect() {
            string strcon= @"Data Source=TUNG\MSSQLLVT;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }


        // Phương load CSDL


    }
}

