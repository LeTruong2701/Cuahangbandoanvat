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
        //private HoaDonBUS hdBUS = new HoaDonBUS();
        public void HienMenu()
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
                Console.Write("\n\t\t║ ║                       QUẢN LÝ KHÁCH HÀNG                          ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║               ╔═══╦══════════════════════════════╗                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 1.║     HIỂN THỊ DS KHÁCH HÀNG   ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 2.║     SỬA TT KHÁCH HÀNG        ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 3.║     XÓA TT KHÁCH HÀNG        ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 4.║     TÌM KIẾM KHÁCH HÀNG      ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 5.║     QUAY LẠI MENU CHÍNH      ║                ║ ║");
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
                Console.SetCursorPosition(65, 26);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1': HienDSKhachhang(); Console.ReadKey(); break;
                    case '2': SuaTTKhachhang(); Console.ReadKey(); break;
                    case '3': XoaTTKhachhang(); Console.ReadKey(); break;
                    case '4': TimkiemKH(); Console.ReadKey(); break;
                    case '5': kt = true; break;
                }

                //Console.Clear();
                //bool kt = false;
                //while (!kt)
                //{
                //    Console.Clear();
                //    Console.WriteLine("QUAN LY KHACH HANG");
                //    Console.WriteLine("1.Hien thi danh sach khach hang");
                //    Console.WriteLine("2.Sua thong tin khach hang");
                //    Console.WriteLine("3.Xoa thong tin khach hang");
                //    Console.WriteLine("4.Tim kiem kh");
                //    Console.WriteLine("5.Quay lai");
                //    Console.Write("Ban chon : ");
                //    string s = Console.ReadLine();
                //    switch (s)
                //    {
                //        case "1":HienDSKhachhang();Console.ReadKey();break;
                //        case "2":SuaTTKhachhang();Console.ReadKey();break;
                //        case "3":XoaTTKhachhang();Console.ReadKey();break;
                //        case "4":TimkiemKH();Console.ReadKey();break;
                //        case "5": kt = true;break;
                //    }
            }
        }
        public void HienDSKhachhang()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                              DANH SÁCH KHÁCH HÀNG                                              ║");
            Console.WriteLine("\t\t╠═════════════╦════════════════════════════════╦══════════════════════════╦══════════════════════════════════════╣");
            Console.WriteLine("\t\t║    Mã KH    ║         Tên Khách Hàng         ║      SĐT Khách Hàng      ║         Địa Chỉ Khách Hàng           ║ ");
            Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬══════════════════════════════════════╣");
            for (int i = 0; i < khBUS.LayDanhSach().Count; i++)
            {
                string[] tmp = khBUS.LayDanhSach()[i].Split('\t');
                Console.WriteLine("\t\t║    {0,-5}    ║      {1,-18}        ║      {2,-10}          ║     {3,-30}   ║", tmp[0], tmp[1],tmp[2],tmp[3]);
            }
            Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩══════════════════════════════════════╝");
            Console.Write("\t\tNhấn phím bất kì để kết thúc!");



            //Console.WriteLine("Danh sach khach hang");
            //foreach(string s in khBUS.LayDanhSach())
            //{
            //    Console.WriteLine(s);
            //}
        }
        public void SuaTTKhachhang()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                           SỬA THÔNG TIN KHÁCH HÀNG                                             ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║    Nhập mã khách hàng muốn sửa TT:                                                                             ║ ");
            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(54, 3);
            string maKH = Console.ReadLine();
            string a;
            while (maKH.Length > 5 || maKH == "" || khBUS.Kiemtra(maKH) == "Y")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(65, 3);
                Console.Write(a);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(54, 3);
                Console.Write(new string(' ', maKH.Length));
                Console.SetCursorPosition(54, 3);
                maKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(26, 5);
                Console.Write(new string(' ', a.Length));
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t Thông tin cũ khách hàng");
            Console.WriteLine("\t\t╔═════════════╦════════════════════════════════╦══════════════════════════╦══════════════════════════════════════╗");
            Console.WriteLine("\t\t║    Mã KH    ║         Tên Khách Hàng         ║      SĐT Khách Hàng      ║         Địa Chỉ Khách Hàng           ║ ");
            Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬══════════════════════════════════════╣");
            khBUS.Laythongtinkhachhang(maKH);
            Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩══════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                           SỬA THÔNG TIN KHÁCH HÀNG                                             ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                                                                                ║");
            Console.WriteLine("\t\t║    Nhập Tên Khách Hàng mới :                                                                                   ║");
            Console.WriteLine("\t\t║                                                                                                                ║");
            Console.WriteLine("\t\t║    Nhập SĐT Khách Hàng mới :                                                                                   ║");
            Console.WriteLine("\t\t║                                                                                                                ║");
            Console.WriteLine("\t\t║    Nhập Địa Chỉ Khách Hàng mới :                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                                                                                ║");
            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(47, 12);
            string tenKH = Console.ReadLine();
            string b;
            while (tenKH.Length > 18 || tenKH == "")
            {
                b = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(50, 19);
                Console.Write(b);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(47, 12);
                Console.Write(new string(' ', tenKH.Length));
                Console.SetCursorPosition(47, 12);
                maKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(50, 19);
                Console.Write(new string(' ', b.Length));
            }

            Console.SetCursorPosition(47, 14);
            string sdtKH =Console.ReadLine();
            string c;
            while (sdtKH.Length != 10 || sdtKH == ""||khBUS.ktrachuoi(sdtKH)==false)
            {
                c = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(50, 19);
                Console.Write(c);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(47, 14);
                Console.Write(new string(' ', sdtKH.Length));
                Console.SetCursorPosition(47, 14);
                sdtKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(50, 19);
                Console.Write(new string(' ', c.Length));
            }

            Console.SetCursorPosition(51, 16);
            string diachiKH = Console.ReadLine();
            string d;
            while (diachiKH.Length > 30 || diachiKH == "")
            {
                d = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(50, 19);
                Console.Write(d);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(51, 16);
                Console.Write(new string(' ', diachiKH.Length));
                Console.SetCursorPosition(51, 16);
                diachiKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(50, 19);
                Console.Write(new string(' ', d.Length));
            }

            if(diachiKH.Length<30 && diachiKH != "")
            {
                Console.SetCursorPosition(50, 19);
                Console.WriteLine("Sửa Thông Tin Thành Công");
            }
            khBUS.Sua(maKH, tenKH, sdtKH, diachiKH);
            Console.WriteLine();
            Console.WriteLine("\t\tNhấn Phím Bất Kì Để Quay Lại");

            //foreach(string s in khBUS.LayDanhSach())
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("Nhap thong tin khach hang muon sua");
            //Console.Write("Nhap ma khach hang muon sua:");
            //string maKH = Console.ReadLine();
            //Console.Write("Nhap ten khach hang moi :");
            //string tenKH = Console.ReadLine();
            //Console.Write("Nhap dia chi khach hang moi :");
            //string diachiKH = Console.ReadLine();
            //Console.Write("Nhap SDT khach hang moi :");
            //int sdtKH = int.Parse(Console.ReadLine());
            //khBUS.Sua(maKH, tenKH,sdtKH, diachiKH);
            //Console.WriteLine("Cap nhat thanh cong!!");

        }
        public void XoaTTKhachhang()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                     XÓA KHÁCH HÀNG                   ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Mã Khách Hàng(muốn xóa) :                           ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(44, 4);
            string maKH = Console.ReadLine();
            string a;
            while (maKH.Length > 5 || maKH == "" ||khBUS.Kiemtra(maKH)=="Y")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(26, 7);
                Console.Write(a);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(44, 4);
                Console.Write(new string(' ', maKH.Length));
                Console.SetCursorPosition(44, 4);
                maKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(26, 7);
                Console.Write(new string(' ', a.Length));
            }
            Console.WriteLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t Thông tin khách hàng");
            Console.WriteLine("\t\t╔═════════════╦════════════════════════════════╦══════════════════════════╦══════════════════════════════════════╗");
            Console.WriteLine("\t\t║    Mã KH    ║         Tên Khách Hàng         ║      SĐT Khách Hàng      ║         Địa Chỉ Khách Hàng           ║ ");
            Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬══════════════════════════════════════╣");
            khBUS.Laythongtinkhachhang(maKH);
            Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩══════════════════════════════════════╝");
            Console.WriteLine();
            Console.Write("\t\tNhấn ENTER để xóa , 0 để thoát:");
            string kt = Console.ReadLine();
            if (kt == "")
            {
                khBUS.Xoa(maKH);
            }
            else if (kt == "0")
            {
                HienMenu();
            }

            //foreach(string s in khBUS.LayDanhSach())
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("Nhap thong tin khach hang muon xoa");
            //Console.Write("Ma khach hang muon xoa :");
            //string maKH = Console.ReadLine();
            //khBUS.Xoa(maKH);
            //Console.WriteLine("Da xoa khach hang!!!");
        }
        public void TimkiemKH()
        {

            Console.Clear();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                           TÌM KIẾM KHÁCH HÀNG                                                  ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║    Nhập thông tin khách hàng muốn tìm kiếm:                                                                    ║ ");
            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(63, 3);
            string s = Console.ReadLine();
            if (khBUS.KiemtrathongtinKH(s) == "X")
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\tThông tin khách hàng cần tìm");
                Console.WriteLine("\t\t╔═════════════╦════════════════════════════════╦══════════════════════════╦══════════════════════════════════════╗");
                Console.WriteLine("\t\t║    Mã KH    ║         Tên Khách Hàng         ║      SĐT Khách Hàng      ║         Địa Chỉ Khách Hàng           ║ ");
                Console.WriteLine("\t\t╠═════════════╬════════════════════════════════╬══════════════════════════╬══════════════════════════════════════╣");
                khBUS.Timkiem(s);
                Console.WriteLine("\t\t╚═════════════╩════════════════════════════════╩══════════════════════════╩══════════════════════════════════════╝");
                Console.WriteLine("\t\t Nhấn ENTER để thoát");
            }
            else if (khBUS.KiemtrathongtinKH(s) == "Y")
            {
                Console.WriteLine("\n");
                Console.Write("\t\t Không tìm thấy thông tin khách hàng!!! Nhấn '0' để tìm lại ( ENTER để thoát) :");
                string a = Console.ReadLine();
                if (a == "")
                {
                    HienMenu();
                }
                else if (a == "0")
                {
                    TimkiemKH();
                }
            }
            

            //Console.Write("Nhap thong tin lien quan den khach hang ban muon tim kiem :");
            //string s = Console.ReadLine();
            //Console.WriteLine("Khach hang ban muon tim");
            //Console.WriteLine(khBUS.Timkiem(s));
        }
    }
}
