using QLNS_DTO;
using System.Data;
using System.Data.SqlClient;

namespace QLNS_DAL
{
    public class TK_DAL : Conection_DAL

    {


        // Load

        public static string CheckLoginDTO(TK_DTO tK_DTO)
        {
            string User = null;
            SqlConnection conn = Conection_DAL.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", tK_DTO.Ten_tai_khoan);
            command.Parameters.AddWithValue("@pass", tK_DTO.Mat_khau);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User = reader.GetString(0);
                    return User;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tai khoan va mat khau khong chinh xac";
            }


            return User;
        }



    }
}
