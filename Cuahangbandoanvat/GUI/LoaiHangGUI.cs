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
            Console.Clear();
            Console.WriteLine("\t\t╔════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║           DANH SÁCH CÁC LOẠI HÀNG          ║");
            Console.WriteLine("\t\t╠════════════════╦═══════════════════════════╣");
            Console.WriteLine("\t\t║  Mã Loại Hàng  ║        Tên Loại Hàng      ║");
            Console.WriteLine("\t\t╠════════════════╬═══════════════════════════╣");
            for(int i = 0; i < lhBUS.LayDanhSach().Count;i++)
            {
                string[] tmp = lhBUS.LayDanhSach()[i].Split('\t');
                Console.WriteLine("\t\t║       {0,-5}    ║         {1,-18}║", tmp[0], tmp[1]);
            }
            Console.WriteLine("\t\t╚════════════════╩═══════════════════════════╝");
            Console.Write("\t\tNhấn phím bất kì để kết thúc!");
        }
        public void ThemLoaiHang()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                THÊM LOẠI HÀNG              ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                            ║");
            Console.WriteLine("\t\t║  Mã Loại Hàng :                            ║");
            Console.WriteLine("\t\t║                                            ║");
            Console.WriteLine("\t\t║  Tên Loại Hàng :                           ║");
            Console.WriteLine("\t\t║                                            ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                            ║");
            Console.WriteLine("\t\t╚════════════════════════════════════════════╝");

            Console.SetCursorPosition(34, 4);
            string maLH = Console.ReadLine();
            string a;
            while (maLH.Length > 5 || maLH == ""||lhBUS.KiemTra(maLH)=="X")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(23, 9);
                Console.Write(a);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(34, 4);
                Console.Write(new string(' ', maLH.Length));
                Console.SetCursorPosition(34, 4);
                maLH = Console.ReadLine();
                //Xoa dong chu string a
                Console.SetCursorPosition(23, 9);
                Console.Write(new string(' ',a.Length));
            }
            Console.SetCursorPosition(35, 6);
            string tenLH = Console.ReadLine();
            string b;
            while (tenLH.Length > 20 || tenLH == ""||lhBUS.KiemTra(tenLH)=="X")
            {
                b = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(23, 9);
                Console.Write(b);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(35, 6);
                Console.Write(new string(' ', maLH.Length));
                Console.SetCursorPosition(35, 6);
                tenLH = Console.ReadLine();
                //Xoa dong chu string b
                Console.SetCursorPosition(23, 9);
                Console.Write(new string(' ', b.Length));
            }
            if (tenLH.Length <= 20 && tenLH != "")
            {
                Console.SetCursorPosition(28, 9);
                Console.Write("Đã thêm thành công !!!");
            }
            lhBUS.ThemLH(maLH, tenLH);
        }
        public void SuaLoaiHang()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                      SỬA LOẠI HÀNG                   ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Mã Loại Hàng(muốn sửa) :                            ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Tên Loại Hàng(mới) :                                ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(44, 4);
            string maLH = Console.ReadLine();
            string a;
            while (maLH.Length > 5 || maLH == "")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(26, 9);
                Console.Write(a);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(44, 4);
                Console.Write(new string(' ', maLH.Length));
                Console.SetCursorPosition(44, 4);
                maLH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(26, 9);
                Console.Write(new string(' ',a.Length));
            }
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
