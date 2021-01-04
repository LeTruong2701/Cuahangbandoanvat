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
        public void Sua(string maKH, string tenKH, string sdtKH, string diachiKH)
        {
            khDAL.Sua(maKH, tenKH,sdtKH,diachiKH);
        }
        public void ThemKH(string maKH,string tenKH, string sdtKH, string diachiKH)
        {
            khDAL.ThemKH(maKH, tenKH,sdtKH ,diachiKH);
        }
        public void Timkiem(string maKH)
        {
            khDAL.Timkiem(maKH);
        }
        public string Kiemtra(string s)
        {
            return khDAL.Kiemtra(s);
        }
        public void Laythongtinkhachhang(string s)
        {
            khDAL.Laythongtinkhachhang(s);
        }
        public bool ktrachuoi(string s)
        {
            return khDAL.checkNum(s);
        }
        public string KiemtrathongtinKH(string s)
        {
            return khDAL.KiemtrathongtinKH(s);
        }
    }
}
