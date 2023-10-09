using QLNS_DTO;

namespace QLNS_DAL
{
    public class TK_ACCESS:TK_DAL
    {
        public string CheckLogin(TK_DTO tK_DTO)
        {
            string info = CheckLoginDTO(tK_DTO);
            return info;
        }
    }
}
