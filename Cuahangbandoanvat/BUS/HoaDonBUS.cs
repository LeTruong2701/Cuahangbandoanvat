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
        public void ThemHoaDon(string maHD,string maKH, string tenKH,string sdtKH, string diachiKH,DateTime ngaygio)
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
        public void LayChiTietHoaDon(string maHD)
        {
             hdDAL.HienchitietHD(maHD);
        }
        public void TimkiemKHtheohoadon(string s)
        {
            hdDAL.TimkiemKHtheohoadon(s);
        }
        public void Timkiemhoadon(string s)
        {
            hdDAL.Timkiemhoadon(s);
        }
        public string KiemtramaHD(string s)
        {
            return hdDAL.KiemTra(s);
        }
        public string KiemtrathongtinHD(string s)
        {
            return hdDAL.KiemtrathongtinHD(s);
        }
        public double Tongtien(string s)
        {
            return hdDAL.Tongtien(s);
        }
        public bool kiemtrachuoi(string s)
        {
            return hdDAL.checkNum(s);
        }
        public string kiemtramaKH(string s)
        {
            return hdDAL.KiemtramaKH(s);
        }
        public void LaythongtinHD(string s)
        {
            hdDAL.LaythongtinHD(s);
        }
    }
}
