using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.BUS;

namespace Cuahangbandoanvat.GUI
{
    class HangHoaGUI
    {
        private HangHoaBUS hhBUS = new HangHoaBUS();
        private LoaiHangBUS lhBUS = new LoaiHangBUS();
        public void HienMENU()
        {
            Console.Clear();
            bool kt = false;
            while (!kt)
            {
                Console.Clear();


                Console.Write("\n\t\t╔═══════════════════════════════════════════════════════════════════════╗");
                Console.Write("\n\t\t║                CHƯƠNG TRÌNH QUẢN LÝ CỦA CỬA HÀNG ĐỒ ĂN VẶT            ║");
                Console.Write("\n\t\t╠═══════════════════════════════════════════════════════════════════════╣");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t║ ╔═══════════════════════════════════════════════════════════════════╗ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                        QUẢN LÝ HÀNG HÓA                           ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║               ╔═══╦══════════════════════════════╗                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 1.║     HIỂN THỊ DS HÀNG HÓA     ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 2.║     THÊM HÀNG HÓA            ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 3.║     SỬA HÀNG HÓA             ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 4.║     XÓA HÀNG HÓA             ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 5.║     TÌM KIẾM HÀNG HÓA        ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 6.║     QUAY LẠI MENU CHÍNH      ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║ Bấm phím theo số để chọn:    ║                ║ ║");
                Console.Write("\n\t\t║ ║               ╚═══╩══════════════════════════════╝                ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ╚═══════════════════════════════════════════════════════════════════╝ ║");
                Console.Write("\n\t\t║                                                                       ║");
                Console.Write("\n\t\t╚═══════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(65, 29);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1': HienHangHoa(); Console.ReadKey(); break;
                    case '2': ThemHangHoa(); Console.ReadKey(); break;
                    case '3': SuaHangHoa(); Console.ReadKey(); break;
                    case '4': XoaHangHoa(); Console.ReadKey(); break;
                    case '5':TimKiemHangHoa(); Console.ReadKey(); break;
                    case '6': kt = true; break;
                }

            }
        }
        public void HienHangHoa()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                          DANH SÁCH HÀNG HÓA                                       ║");
            Console.WriteLine("\t\t╠═════════════╦════════════════════════════════╦══════════════════════════╦═════════════════════════╣");
            Console.WriteLine("\t\t║    Mã HH    ║         Tên Hàng Hóa           ║      Loại Hàng Hóa       ║      Gía Thành          ║ ");
            Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬═════════════════════════╣");
            for (int i = 0; i < hhBUS.LayDanhSach().Count; i++)
            {
                string[] tmp = hhBUS.LayDanhSach()[i].Split('\t');
                Console.WriteLine("\t\t║    {0,-5}    ║      {1,-18}        ║      {2,-10}          ║        {3,-10}       ║", tmp[0], tmp[1], tmp[2], tmp[3]);
            }
            Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩═════════════════════════╝");
            Console.Write("\t\tNhấn phím bất kì để kết thúc!");

        }
        public void TimKiemHangHoa()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                 TÌM KIẾM HÀNG HÓA                    ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Thông tin hàng hóa(muốn tìm):                       ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(50, 4);
            string s = Console.ReadLine();
            if (hhBUS.KiemtrathongtinHH(s) == "X")
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("\t\tThông tin hàng hóa cần tìm");
                Console.WriteLine("\t\t╔═════════════╦════════════════════════════════╦══════════════════════════╦═════════════════════════╗");
                Console.WriteLine("\t\t║    Mã HH    ║         Tên Hàng Hóa           ║      Loại Hàng           ║        Gía Thành        ║");
                Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬═════════════════════════╣");
                hhBUS.Timkiem(s);
                Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩═════════════════════════╝");
                Console.WriteLine("\t\t Nhấn ENTER để thoát");
            }
            else if (hhBUS.KiemtrathongtinHH(s) == "Y")
            {
                Console.WriteLine("\n\n\n");
                Console.Write("\t\t Không tìm thấy thông tin hàng hóa !!! Nhấn '0' để tìm lại ( ENTER để thoát) :");
                string a = Console.ReadLine();
                if (a == "")
                {
                    HienMENU();
                }
                else if (a == "0")
                {
                    TimKiemHangHoa();
                }
            }
            
        }
        public void ThemHangHoa()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║           DANH SÁCH CÁC LOẠI HÀNG          ║");
            Console.WriteLine("\t\t╠════════════════╦═══════════════════════════╣");
            Console.WriteLine("\t\t║  Mã Loại Hàng  ║        Tên Loại Hàng      ║");
            Console.WriteLine("\t\t╠════════════════╬═══════════════════════════╣");
            for (int i = 0; i < lhBUS.LayDanhSach().Count; i++)
            {
                string[] tmp = lhBUS.LayDanhSach()[i].Split('\t');
                Console.WriteLine("\t\t║     {0,-5}      ║    {1,-18}     ║", tmp[0], tmp[1]);
            }
            Console.WriteLine("\t\t╚════════════════╩═══════════════════════════╝");
            Console.WriteLine("\t\t╔════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║  Nhập mã loại hàng muốn thêm:              ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                            ║");
            Console.WriteLine("\t\t╚════════════════════════════════════════════╝");
            Console.SetCursorPosition(48, 10);
            string maLH = Console.ReadLine();
            string a;
            while (maLH.Length > 5 || maLH == "" || hhBUS.KiemtramaLH(maLH) == "Y")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(23, 12);
                Console.Write(a);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(48, 10);
                Console.Write(new string(' ', maLH.Length));
                Console.SetCursorPosition(48, 10);
                maLH = Console.ReadLine();
                //Xoa dong chu string a
                Console.SetCursorPosition(23, 12);
                Console.Write(new string(' ', a.Length));
            }
            Console.Clear();

            Console.WriteLine("\t\t╔═════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                THÊM HÀNG HÓA                ║");
            Console.WriteLine("\t\t╠═════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                             ║");
            Console.WriteLine("\t\t║  Tên Hàng :                                 ║");
            Console.WriteLine("\t\t║                                             ║");
            Console.WriteLine("\t\t║  Gía Thành :                                ║");
            Console.WriteLine("\t\t║                                             ║");
            Console.WriteLine("\t\t╠═════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                             ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════╝");
            string maHH = "";
            while (maHH == "" || hhBUS.KiemTra(maHH) == "X")
            {
                Random r = new Random();
                int i = r.Next(0, 100);
                maHH = "MH" + i;
            }

            Console.SetCursorPosition(31,4);
            string tenHH = Console.ReadLine();
            string b;
            while (tenHH.Length > 30 || tenHH == "" || hhBUS.KiemtratenHH(tenHH) == "X")
            {
                b = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(24, 9);
                Console.Write(b);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(31, 4);
                Console.Write(new string(' ', tenHH.Length));
                Console.SetCursorPosition(31, 4);
                tenHH = Console.ReadLine();
                //Xoa dong chu string a
                Console.SetCursorPosition(24, 9);
                Console.Write(new string(' ', b.Length));
            }

            Console.SetCursorPosition(32, 6);
            string giaban = Console.ReadLine();
            string c;
            while (giaban.Length > 6 || giaban == ""||hhBUS.checkgiaban(giaban)==false)
            {
                c = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(24, 9);
                Console.Write(c);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(32, 6);
                Console.Write(new string(' ', giaban.Length));
                Console.SetCursorPosition(32, 6);
                giaban = Console.ReadLine();
                //Xoa dong chu string a
                Console.SetCursorPosition(24, 9);
                Console.Write(new string(' ', c.Length));
            }
            if (giaban.Length <= 6 && giaban != "")
            {
                Console.SetCursorPosition(27, 9);
                Console.Write("Đã thêm thành công !!!");
            }
            hhBUS.Them(maHH, tenHH, hhBUS.Layloaihang(maLH), giaban);
            Console.WriteLine("\n\n");
            Console.Write("\t\tNhấn phím bất kì để tiếp tục...");

        }
        public void SuaHangHoa()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔═══════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║           DANH SÁCH CÁC LOẠI HÀNG             ║");
            Console.WriteLine("\t\t╠════════════════╦══════════════════════════════╣");
            Console.WriteLine("\t\t║  Mã Loại Hàng  ║        Tên Loại Hàng         ║");
            Console.WriteLine("\t\t╠════════════════╬══════════════════════════════╣");
            for (int i = 0; i < lhBUS.LayDanhSach().Count; i++)
            {
                string[] tmp = lhBUS.LayDanhSach()[i].Split('\t');
                Console.WriteLine("\t\t║     {0,-5}      ║    {1,-18}        ║", tmp[0], tmp[1]);
            }
            Console.WriteLine("\t\t╚════════════════╩══════════════════════════════╝");
            Console.WriteLine("\t\t╔═══════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║  Nhập tên loại hàng muốn sửa :                ║");
            Console.WriteLine("\t\t╠═══════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                               ║");
            Console.WriteLine("\t\t╚═══════════════════════════════════════════════╝");
            Console.SetCursorPosition(48, 10);
            string tenLH = Console.ReadLine();
            string a;
            while (tenLH.Length > 20 || tenLH == "")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(23, 12);
                Console.Write(a);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(48, 10);
                Console.Write(new string(' ', tenLH.Length));
                Console.SetCursorPosition(48, 10);
                tenLH = Console.ReadLine();
                //Xoa dong chu string a
                Console.SetCursorPosition(23, 12);
                Console.Write(new string(' ', a.Length));
            }
            Console.Clear();
            Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                          DANH SÁCH HÀNG HÓA                                       ║");
            Console.WriteLine("\t\t╠═════════════╦════════════════════════════════╦══════════════════════════╦═════════════════════════╣");
            Console.WriteLine("\t\t║    Mã HH    ║         Tên Hàng Hóa           ║      Loại Hàng Hóa       ║      Gía Thành          ║ ");
            Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬═════════════════════════╣");
            hhBUS.Laydsmathangtheoloaihang(tenLH);
            Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩═════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                          SỬA THÔNG TIN HÀNG HÓA                                  ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║    Nhập mã hàng hóa muốn sửa TT:                                                 ║ ");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(52, 12);
            string maHH = Console.ReadLine();
            string b;
            while (maHH.Length > 5 || maHH == "" || hhBUS.KiemTra(maHH)=="Y")
            {
                b = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(26, 14);
                Console.Write(b);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(52, 12);
                Console.Write(new string(' ', maHH.Length));
                Console.SetCursorPosition(52,12);
                maHH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(26, 14);
                Console.Write(new string(' ', b.Length));
            }
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                          SỬA THÔNG TIN HÀNG HÓA                                  ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                                                  ║");
            Console.WriteLine("\t\t║    Nhập Tên Hàng Hóa mới :                                                       ║");
            Console.WriteLine("\t\t║                                                                                  ║");
            Console.WriteLine("\t\t║    Nhập Gía thành mới :                                                          ║");
            Console.WriteLine("\t\t║                                                                                  ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                                                  ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(45, 4);
            string tenHH = Console.ReadLine();
            string c;
            while (tenHH.Length > 30 || tenHH == "" || hhBUS.KiemtratenHH(tenHH) == "X")
            {
                c = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(24, 9);
                Console.Write(c);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(45, 4);
                Console.Write(new string(' ', tenHH.Length));
                Console.SetCursorPosition(45, 4);
                tenHH = Console.ReadLine();
                //Xoa dong chu string a
                Console.SetCursorPosition(24, 9);
                Console.Write(new string(' ', c.Length));
            }

            Console.SetCursorPosition(43, 6);
            string giaban = Console.ReadLine();
            string d;
            while (giaban.Length > 6 || giaban == "" || hhBUS.checkgiaban(giaban) == false)
            {
                d = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(24, 9);
                Console.Write(d);
                //Xoa nhung gi da nhap
                Console.SetCursorPosition(43, 6);
                Console.Write(new string(' ', giaban.Length));
                Console.SetCursorPosition(43, 6);
                giaban = Console.ReadLine();
                //Xoa dong chu string a
                Console.SetCursorPosition(24, 9);
                Console.Write(new string(' ', d.Length));
            }
            if (giaban.Length <= 6 && giaban != "")
            {
                Console.SetCursorPosition(34, 9);
                Console.Write("Đã thêm thành công !!!");
            }
            hhBUS.Sua(maHH, tenHH, hhBUS.Layloaihang(tenLH), giaban);
            Console.Write("\n\n\t\tNhấn phím bất kì để tiếp tục...");
            
        }
        public void XoaHangHoa()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                      XÓA HÀNG HÓA                    ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Mã Hàng Hóa (muốn xóa) :                            ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(44, 4);
            string maHH = Console.ReadLine();
            string a;
            while (maHH.Length > 5 || maHH == "" || hhBUS.KiemTra(maHH) == "Y")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(26, 7);
                Console.Write(a);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(44, 4);
                Console.Write(new string(' ', maHH.Length));
                Console.SetCursorPosition(44, 4);
                maHH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(26, 7);
                Console.Write(new string(' ', a.Length));
            }

            Console.WriteLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t Thông tin hàng hóa");
            Console.WriteLine("\t\t╔═════════════╦════════════════════════════════╦══════════════════════════╦════════════════════╗");
            Console.WriteLine("\t\t║    Mã HH    ║         Tên Hàng Hóa           ║      Loại Hàng Hóa       ║      Gía Thành     ║ ");
            Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬════════════════════╣");
            hhBUS.laythongtinhanghoagui(maHH);
            Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩════════════════════╝");
            Console.WriteLine();
            Console.Write("\t\tNhấn ENTER để xóa , 0 để thoát:");
            string kt = Console.ReadLine();
            if (kt == "")
            {
                hhBUS.Xoa(maHH);
            }
            else if (kt == "0")
            {
                HienMENU();
            }
        }
    }
}
