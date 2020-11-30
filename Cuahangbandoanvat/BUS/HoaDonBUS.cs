using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.DAL;

namespace Cuahangbandoanvat.BUS
{
    class HoaDonBUS
    {
        HoaDonDAL hdDAL = new HoaDonDAL();
        public void ThemHoaDon(string maHD,string maKH, string tenKH, string diachiKH, int sdtKH)
        {
            hdDAL.ThemHD(maHD, tenKH, diachiKH, sdtKH);
        }
        public void ThemChiTietHoaDon(string maHD,string maKH, string maHH, int soluong)
        {
            hdDAL.ThemchitietHD(maHD,maKH, maHH, soluong);
        }
        public void Xoa(string maHD)
        {
            hdDAL.XoaHD(maHD);
        }
        public List<string> LayDanhSach()
        {
           return hdDAL.Laydanhsach();
        }
        public List<string> LayChiTietHoaDon(string maHD)
        {
            return hdDAL.HienchitietHD(maHD);
        }
    }
}
