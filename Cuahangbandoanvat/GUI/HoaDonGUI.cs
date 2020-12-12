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
                Console.WriteLine("2.Them hoa don khach hang");
                Console.WriteLine("3.Xoa hoa don khach hang");
                Console.WriteLine("4.Tim kiem hoa don");
                Console.WriteLine("5.Quay lai");
                Console.WriteLine("Ban chon:");
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1':HienDanhSachHoaDon(); break;
                    case '2': ThemHD(); Console.ReadKey(); break;
                    case '3': XoaHoaDon(); Console.ReadKey(); break;
                    case '4':Timkiem();Console.ReadKey(); break;
                    case '5': kt=true; break;
                }
                Console.Clear();
            }
        }
        
        public void HienDanhSachHoaDon()
        {
            bool kt = false;
            while (!kt)
            {
                Console.Clear();
                Console.WriteLine("Danh sach hoa don khach hang");
                foreach (string s in hdBUS.LayDanhSach())
                {
                    Console.WriteLine(s);
                }
                Console.Write("Nhap ma hoa don de xem chi tiet (Nhan Enter de thoat):");
                string maHD = Console.ReadLine().ToUpper();
                if (maHD =="")
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(hdBUS.TimkiemKHtheohoadon(maHD));
                    foreach (string s in hdBUS.LayChiTietHoaDon(maHD))
                    {
                        Console.WriteLine(s);
                    }
                    Console.Write("Ban co muon xem chi tiet hoa don nua khong ? Có(C) Không(K):");
                    string a = Console.ReadLine();
                    if (a == "C" || a == "c")
                    {
                        HienDanhSachHoaDon();
                    }
                    else
                    {
                        kt = true;
                    }
                }
            }
        }
        public void Xemchitiethoadon()
        {
            Console.Write("Ma hoa don muon xem chi tiet:");
            string maHD = Console.ReadLine().ToUpper();
            foreach (string s in hdBUS.LayChiTietHoaDon(maHD))
            {
                Console.WriteLine(s);
            }
        }
        public void Timkiem()
        {
            Console.WriteLine("Tim kiem hoa don");
            Console.Write("Nhap thong tin ve hoa don ban muon tim kiem:");
            string s = Console.ReadLine();
            if (hdBUS.Timkiemhoadon(s) !="")
            {
                Console.WriteLine(hdBUS.Timkiemhoadon(s));
                Console.WriteLine("Nhan ENTER de quay tro lai...");
            }
            else
            {
                Console.WriteLine("Khong co thong tin ban muon tim!");
                Console.WriteLine("Nhan ENTER de quay tro lai...");
            }
        }
        public void ThemHD()
        {
            Console.WriteLine("Nhap thong tin hoa don can them");
            string maHD = "";
            while (maHD == "" || hdBUS.Kiemtra(maHD) == "X")
            {
                Random r = new Random();
                int i = r.Next(0, 100);
                maHD = "HD" + i;
            }
            DateTime ngaygio = DateTime.Now;
            Console.Write("Nhap ma khach hang(KH**):");
            string maKH = Console.ReadLine().ToUpper();
            Console.Write("Nhap ten khach hang:");
            string tenKH = Console.ReadLine();
            Console.Write("Dia chi khach hang:");
            string diachiKH = Console.ReadLine();
            Console.Write("SDT khach hang (10 số):");
            double sdtKH = double.Parse(Console.ReadLine());
            khBUS.ThemKH(maKH, tenKH,sdtKH,diachiKH);
            hdBUS.ThemHoaDon(maHD,maKH,tenKH, sdtKH,diachiKH, ngaygio);
            Console.WriteLine("Nhap chi tiet cho hoa don");
            while (true)
            {
                hhGUI.HienHangHoa();
                Console.Write("Chon ma hang hoa:");
                string maHH = Console.ReadLine().ToUpper();
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
            string maHD= Console.ReadLine().ToUpper();

            hdBUS.Xoa(maHD);
            Console.WriteLine("Da xoa hoa don!");
        }
        //public void SuaHD()
        //{
        //    Console.WriteLine("Danh sach hoa don");
        //    foreach(string s in hdBUS.LayDanhSach())
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.Write("Nhap ma hoa don ban muon sua:");
        //    string maHD = Console.ReadLine();
        //    Console.Clear();
        //    Console.WriteLine("Danh sach cac mat hang trong hoa don");
        //    foreach(string s in hdBUS.LayChiTietHoaDon(maHD))
        //    {
        //        Console.WriteLine(s);
        //    }
        //    Console.Write("Nhap ma hang hoa ban muon sua:");
        //    string maHH = Console.ReadLine();

        //}
    }
}
