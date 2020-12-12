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
        public void ThemHoaDon(string maHD,string maKH, string tenKH,double sdtKH, string diachiKH,DateTime ngaygio)
        {
            hdDAL.ThemHD(maHD,maKH, tenKH, sdtKH, diachiKH,ngaygio);
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
        public string TimkiemKHtheohoadon(string s)
        {
            return hdDAL.TimkiemKHtheohoadon(s);
        }
        public string Timkiemhoadon(string s)
        {
            return hdDAL.Timkiemhoadon(s);
        }
        public string Kiemtra(string s)
        {
            return hdDAL.KiemTra(s);
        }
        //public void SuaChitietHD(string maHD,string maKH,string maHH,int soluong)
        //{
        //    hdDAL.SuaChitiettrongHD(maHD, maKH, maHH, soluong);
        //}
    }
}
