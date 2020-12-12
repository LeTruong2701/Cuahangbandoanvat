using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Cuahangbandoanvat.DAL;

namespace Cuahangbandoanvat.BUS
{
    class HangHoaBus
    {
        private HangHoaDAL hhDAL = new HangHoaDAL();

        public void Them(string maHH, string tenHH,string loaiHH, double giaban)
        {
            hhDAL.Them(maHH, tenHH,loaiHH,giaban);
        }

        public void Sua(string maHH, string tenHH,string loaiHH,double giaban)
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
        public string Timkiem(string s)
        {
            return hhDAL.Timkiem(s);
        }
        public string KiemTra(string s)
        {
            return hhDAL.KiemTra(s);
        }
        public string Layloaihang(string s)
        {
            return hhDAL.Layloaihang(s);
        }
        public string Laydsmathangtheoloaihang(string s)
        {
            return hhDAL.Laydsmathangtheoloaihang(s);
        }
    }
}
