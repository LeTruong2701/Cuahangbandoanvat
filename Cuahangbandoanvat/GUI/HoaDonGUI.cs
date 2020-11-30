using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.BUS;

namespace Cuahangbandoanvat.GUI
{
    class HoaDonGUI
    {
        private HoaDonBUS hdBUS = new HoaDonBUS();
        private HangHoaGUI hhGUI = new HangHoaGUI();
        private KhachhangBUS khBUS = new KhachhangBUS();
        public void HienMENU()
        {
            Console.Clear();
            bool kt = false;
            while (!kt)
            {
                Console.WriteLine("QUAN LY BAN HANG");
                Console.WriteLine("1.Hien thi danh sach hoa don khach hang");
                Console.WriteLine("2.Hien thi chi tiet hoa don khach hang");
                Console.WriteLine("3.Them hoa don khach hang");
                Console.WriteLine("4.Xoa hoa don khach hang");
                Console.WriteLine("5.Quay lai");
                Console.WriteLine("Ban chon:");
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1':HienDanhSachHoaDon(); Console.ReadKey(); break;
                    case '2': HienChiTietHoaDonKH(); Console.ReadKey(); break;
                    case '3': ThemHD(); Console.ReadKey(); break;
                    case '4': XoaHoaDon(); Console.ReadKey(); break;
                    case '5': kt=true; break;
                }
                Console.Clear();
            }
        }
        public void HienDanhSachHoaDon()
        {
            Console.WriteLine("DANH SACH HOA DON KHACH HANG");
            foreach (string s in hdBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
        }
        public void HienChiTietHoaDonKH()
        {
            foreach(string s in hdBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
            Console.Write("Ma hoa don muon xem chi tiet:");
            string maHD = Console.ReadLine();
            foreach(string s in hdBUS.LayChiTietHoaDon(maHD))
            {
                Console.WriteLine(s); 
            }
        }
        public void ThemHD()
        {
            Console.WriteLine("Nhap thong tin hoa don can them");
            Console.Write("Nhap ma hoa don:");
            string maHD = Console.ReadLine();
            Console.Write("Nhap ma khach hang :");
            string maKH = Console.ReadLine();
            Console.Write("Nhap ten khach hang:");
            string tenKH = Console.ReadLine();
            Console.Write("Dia chi khach hang:");
            string diachiKH = Console.ReadLine();
            Console.Write("SDT khach hang :");
            int sdtKH = int.Parse(Console.ReadLine());
            khBUS.ThemKH(maKH, tenKH,diachiKH,sdtKH);
            hdBUS.ThemHoaDon(maHD,maKH,tenKH,diachiKH, sdtKH);
            Console.WriteLine("Nhap chi tiet cho hoa don");
            while (true)
            {
                hhGUI.HienHangHoa();
                Console.Write("Chon ma hang hoa:");
                string maHH = Console.ReadLine();
                Console.Write("So luong: ");
                int soluong = int.Parse(Console.ReadLine());
                hdBUS.ThemChiTietHoaDon(maHD,maKH, maHH, soluong);
                Console.Write("Ban co muon nhap tiep khong?");
                string s = Console.ReadLine();
                if (s.ToLower() != "c")
                {
                    break;
                }
            }
            Console.WriteLine("Da them hoa don");
        }
        public void XoaHoaDon()
        {
            Console.Write("Nhap ma hoa don can xoa: ");
            string maHD= Console.ReadLine();

            hdBUS.Xoa(maHD);
            Console.WriteLine("Da xoa hoa don!");
        }
    }
}
