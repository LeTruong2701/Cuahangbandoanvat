using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cuahangbandoanvat.DAL;

namespace Cuahangbandoanvat.BUS
{
    class HangHoaBUS
    {
        private HangHoaDAL hhDAL = new HangHoaDAL();

        public void Them(string maHH, string tenHH,string loaiHH, string giaban)
        {
            hhDAL.Them(maHH, tenHH,loaiHH,giaban);
        }

        public void Sua(string maHH, string tenHH,string loaiHH,string giaban)
        {
            hhDAL.Sua(maHH, tenHH,loaiHH,giaban);
        }

        public void Xoa(string maHH)
        {
            hhDAL.Xoa(maHH);
        }

        public List<String> LayDanhSach()
        {
            return hhDAL.Laydanhsach();
        }
        public void Timkiem(string s)
        {
            hhDAL.Timkiem(s);
        }
        public string KiemTra(string s)
        {
            return hhDAL.KiemTra(s);
        }
        public string Layloaihang(string s)
        {
            return hhDAL.Layloaihang(s);
        }
        public void Laydsmathangtheoloaihang(string s)
        {
            hhDAL.laydshanghoatheoloaihang(s);
        }
        public string KiemtramaLH(string s)
        {
            return hhDAL.KiemTramaLH(s);
        }
        public string KiemtratenHH(string s)
        {
            return hhDAL.KiemTratenHH(s);
        }
        public bool checkgiaban(string s)
        {
            return hhDAL.checkNum(s);
        }
        public void laythongtinhanghoagui(string s)
        {
            hhDAL.laythongtinhanghoagui(s);
        }
        public string KiemtrathongtinHH(string s)
        {
            return hhDAL.KiemtrathongtinHH(s);
        }
    }
}
