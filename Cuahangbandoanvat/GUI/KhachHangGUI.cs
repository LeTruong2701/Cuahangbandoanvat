using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.BUS;

namespace Cuahangbandoanvat.GUI
{
    class KhachHangGUI
    {
        private KhachhangBUS khBUS = new KhachhangBUS();
        private HoaDonBUS hdBUS = new HoaDonBUS();
        public void HienMenu()
        {
            Console.Clear();
            bool kt = false;
            while (!kt)
            {
                Console.Clear();
                Console.WriteLine("QUAN LY KHACH HANG");
                Console.WriteLine("1.Hien thi danh sach khach hang");
                Console.WriteLine("2.Sua thong tin khach hang");
                Console.WriteLine("3.Xoa thong tin khach hang");
                Console.WriteLine("4.Quay lai");
                Console.Write("Ban chon : ");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":HienDSKhachhang();Console.ReadKey();break;
                    case "2":SuaTTKhachhang();Console.ReadKey();break;
                    case "3":XoaTTKhachhang();Console.ReadKey();break;
                    case "4": kt = true;break;
                }
            }
        }
        public void HienDSKhachhang()
        {
            Console.WriteLine("Danh sach khach hang");
            foreach(string s in khBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
        }
        public void SuaTTKhachhang()
        {
            foreach(string s in khBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Nhap thong tin khach hang muon sua");
            Console.Write("Nhap ma khach hang muon sua:");
            string maKH = Console.ReadLine();
            Console.Write("Nhap ten khach hang moi :");
            string tenKH = Console.ReadLine();
            Console.Write("Nhap dia chi khach hang moi :");
            string diachiKH = Console.ReadLine();
            Console.Write("Nhap SDT khach hang moi :");
            int sdtKH = int.Parse(Console.ReadLine());
            khBUS.Sua(maKH, tenKH, diachiKH, sdtKH);
            Console.WriteLine("Cap nhat thanh cong!!");

        }
        public void XoaTTKhachhang()
        {
            foreach(string s in khBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Nhap thong tin khach hang muon xoa");
            Console.Write("Ma khach hang muon xoa :");
            string maKH = Console.ReadLine();
            khBUS.Xoa(maKH);
            Console.WriteLine("Da xoa khach hang!!!");
        }
    }
}
