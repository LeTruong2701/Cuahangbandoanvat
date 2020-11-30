using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.BUS;

namespace Cuahangbandoanvat.GUI
{
    class LoaiHangGUI
    {
        private LoaiHangBUS lhBUS = new LoaiHangBUS();

        public void HienMENU()
        {
            Console.Clear();
            bool kt = false;
            while (!kt)
            {
                Console.Clear();
                Console.Title = "\t          CHƯƠNG TRÌNH QUẢN LÝ SÁCH CỦA CỬA HÀNG ĐỒ ĂN VẶT ";
                Console.SetWindowSize(103, 40);
                Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t║                CHƯƠNG TRÌNH QUẢN LÝ CỦA CỬA HÀNG ĐỒ ĂN VẶT            ║");
                Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                         QUẢN LÝ LOẠI HÀNG                         ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║     HIỂN THỊ CÁC LOẠI HÀNG   ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║     THÊM LOẠI HÀNG           ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║     SỬA LOẠI HÀNG            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║     XÓA LOẠI HÀNG            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 5.║     QUAY LẠI MENU CHÍNH      ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║ Bấm phím theo số để chọn:    ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ╚═══╩══════════════════════════════╝                 ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(65, 26);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1':HienLoaiHang();Console.ReadKey();break;
                    case '2':ThemLoaiHang();Console.ReadKey();break;
                    case '3':SuaLoaiHang();Console.ReadKey();break;
                    case '4':XoaLoaiHang();Console.ReadKey();break;
                    case '5': kt = true; break;
                }
            }
        }
        public void HienLoaiHang()
        {
            Console.WriteLine("Danh sach cac loai hang");
            foreach (string s in lhBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
        }
        public void ThemLoaiHang()
        {
            Console.WriteLine("Danh sach loai hang da co");
            foreach(string s in lhBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Nhap thong tin loai hang muon them");
            Console.Write("Ma loai hang:");
            string maLH = Console.ReadLine();
            Console.Write("Ten loai hang:");
            string tenLH = Console.ReadLine();
            lhBUS.ThemLH(maLH, tenLH);
            Console.WriteLine("Da them thanh cong!!!");
        }
        public void SuaLoaiHang()
        {
            foreach(string s in lhBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Nhap thong tin loai hang muon sua");
            Console.Write("Nhap ma loai hang muon sua :");
            string maLH = Console.ReadLine();
            Console.Write("Nhap ten loai hang muon sua :");
            string tenLH = Console.ReadLine();
            lhBUS.SuaLH(maLH, tenLH);
            Console.WriteLine("Cap nhat thanh cong !!!");
        }
        public void XoaLoaiHang()
        {
            Console.WriteLine("Nhap thong tin loai hang muon xoa");
            Console.Write("Ma loai hang :");
            string maLH = Console.ReadLine();
            lhBUS.XoaLH(maLH);
            Console.WriteLine("Da xoa loai hang!!!");
        }
    }
}
