using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNS_DTO;
using QLNS_DAL;


namespace QLNS_BUS
{
    public class TK_BUS
    {
        TK_ACCESS tk = new TK_ACCESS();
        public string CheckLogin(TK_DTO tK_DTO)
        {
            if (tK_DTO.Ten_tai_khoan == "")
            {
                return "requeid_taikhoan";
            }
            if (tK_DTO.Mat_khau == "")
            {
                return "requeid_matkhau";
            }
      

            string info =tk.CheckLogin(tK_DTO);
            return info;
        }


    }
}

        

