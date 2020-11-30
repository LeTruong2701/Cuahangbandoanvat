using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.DAL;

namespace Cuahangbandoanvat.BUS
{
    class KhachhangBUS
    {
        private KhachHangDAL khDAL = new KhachHangDAL();
        public List<String> LayDanhSach()
        {
            return khDAL.Laydanhsach();
        }
        public void Xoa(string maKH)
        {
            khDAL.Xoa(maKH);
        }
        public void Sua(string maKH, string tenKH, string diachiKH, int sdtKH)
        {
            khDAL.Sua(maKH, tenKH, diachiKH, sdtKH);
        }
        public void ThemKH(string maKH,string tenKH,string diachiKH,int sdtKH)
        {
            khDAL.ThemKH(maKH, tenKH, diachiKH, sdtKH);
        }
    }
}
