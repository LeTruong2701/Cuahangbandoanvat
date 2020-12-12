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
        public void Sua(string maKH, string tenKH, double sdtKH, string diachiKH)
        {
            khDAL.Sua(maKH, tenKH,sdtKH,diachiKH);
        }
        public void ThemKH(string maKH,string tenKH, double sdtKH, string diachiKH)
        {
            khDAL.ThemKH(maKH, tenKH,sdtKH ,diachiKH);
        }
        public string Timkiem(string maKH)
        {
            return khDAL.Timkiem(maKH);
        }
    }
}
