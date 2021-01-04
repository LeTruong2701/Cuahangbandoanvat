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
        private HangHoaBUS hhBUS = new HangHoaBUS(); 
        private KhachhangBUS khBUS = new KhachhangBUS();
        
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
                Console.Write("\n\t\t║ ║                        QUẢN LÝ BÁN HÀNG                           ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║               ╔═══╦══════════════════════════════╗                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 1.║     HIỂN THỊ DS HÓA ĐƠN      ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 2.║     THÊM HÓA ĐƠN             ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 3.║     XÓA HÓA ĐƠN              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║___║______________________________║                ║ ║");
                Console.Write("\n\t\t║ ║               ║   ║                              ║                ║ ║");
                Console.Write("\n\t\t║ ║               ║ 4.║     TÌM KIẾM HÓA ĐƠN         ║                ║ ║");
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
                    case '1': HienDanhSachHoaDon(); Console.ReadKey(); break;
                    case '2': ThemHD(); Console.ReadKey(); break;
                    
                    case '3': XoaHoaDon(); Console.ReadKey(); break;
                    case '4': Timkiem(); Console.ReadKey(); break;
                    case '5': kt = true; break;
                }


                }
            }
        
        public void HienDanhSachHoaDon()
        {
            bool kt = false;
            while (!kt)
            {
                Console.Clear();
                Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                                              DANH SÁCH HÓA ĐƠN                                                               ║");
                Console.WriteLine("\t\t╠═══════════╦═══════════╦═════════════════════════════╦═══════════════════════╦═════════════════════════════╦══════════════════╣");
                Console.WriteLine("\t\t║   Mã HD   ║   Mã KH   ║        Tên Khách Hàng       ║    SĐT Khách Hàng     ║      Địa Chỉ Khách Hàng     ║    Ngày Lập HD   ║");
                Console.WriteLine("\t\t╠═══════════╬═══════════╬═════════════════════════════╬═══════════════════════╬═════════════════════════════╬══════════════════╣");
                for(int i = 0; i < hdBUS.LayDanhSach().Count; i++)
                {
                    string[] tmp = hdBUS.LayDanhSach()[i].Split('\t');
                    Console.WriteLine("\t\t║  {0,-5}    ║  {1,-5}    ║    {2,-18}       ║    {3,-10}         ║    {4,-25}║    {5,-12}  ║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4],tmp[5]);
                }
                Console.WriteLine("\t\t╚═══════════╩═══════════╩═════════════════════════════╩═══════════════════════╩═════════════════════════════╩══════════════════╝");
                
                Console.Write("\t\tNhập mã hóa đơn để xem chi tiết (nhấn ENTER để thoát): ");
                string maHD = Console.ReadLine().ToUpper();
                if (maHD =="")
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("\t\t║                                     HÓA ĐƠN                                           ║");
                    Console.WriteLine("\t\t║                                                                                       ║");
                    hdBUS.TimkiemKHtheohoadon(maHD);
                    Console.WriteLine("\t\t╠═══════════════════════════════════════════════════════════════════════════════════════╣");
                    Console.WriteLine("\t\t║                                CHI TIẾT HÓA ĐƠN                                       ║");
                    Console.WriteLine("\t\t║                                                                                       ║");
                    hdBUS.LayChiTietHoaDon(maHD);
                    Console.WriteLine("\t\t║                                                                                       ║");
                    Console.WriteLine("\t\t╠═══════════════════════════════════════════════════════════════════════════════════════╣");
                    Console.WriteLine("\t\t║                                                          Tổng tiền : {0,-8}         ║",hdBUS.Tongtien(maHD));
                    Console.WriteLine("\t\t╚═══════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.Write("\n\t\t Nhập 0 để tiếp tục xem chi tiết hóa đơn (ENTER để thoát):");
                    string a = Console.ReadLine();
                    if (a == "0")
                    {
                        HienDanhSachHoaDon();
                    }
                    else if (a == "")
                    {
                        kt = true;
                    }

                   
                }
            }
        }
        
        public void Timkiem()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                           TÌM KIẾM HÓA ĐƠN                                                     ║");
            Console.WriteLine("\t\t╠════════════════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║    Nhập thông tin hóa đơn muốn tìm kiếm:                                                                       ║ ");
            Console.WriteLine("\t\t╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(63, 3);
            string s = Console.ReadLine();
            if (hdBUS.KiemtrathongtinHD(s) == "X")
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t\tThông tin hóa đơn cần tìm");
                Console.WriteLine("\t\t╔═══════════╦═══════════╦═════════════════════════════╦═══════════════════════╦═════════════════════════════╦══════════════════╗");
                Console.WriteLine("\t\t║   Mã HD   ║   Mã KH   ║        Tên Khách Hàng       ║    SĐT Khách Hàng     ║      Địa Chỉ Khách Hàng     ║    Ngày Lập HD   ║");
                Console.WriteLine("\t\t╠═══════════╬═══════════╬═════════════════════════════╬═══════════════════════╬═════════════════════════════╬══════════════════╣");
                hdBUS.Timkiemhoadon(s);
                Console.WriteLine("\t\t╚═══════════╩═══════════╩═════════════════════════════╩═══════════════════════╩═════════════════════════════╩══════════════════╝");
                Console.WriteLine("\t\t Nhấn ENTER để thoát");
            }
            else if (hdBUS.KiemtrathongtinHD(s) == "Y")
            {
                Console.WriteLine("\n");
                Console.Write("\t\t Không tìm thấy thông tin hóa đơn!!! Nhấn '0' để tìm lại ( ENTER để thoát) :");
                string a = Console.ReadLine();
                if (a == "")
                {
                    HienMENU();
                }
                else if (a == "0")
                {
                    Timkiem();
                }
            }

     
        }
        public void ThemHD()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                           HÓA ĐƠN MUA HÀNG                               ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                                          ║");
            Console.WriteLine("\t\t║    Mã Khách Hàng :                                                       ║");
            Console.WriteLine("\t\t║                                                                          ║");
            Console.WriteLine("\t\t║    Tên Khách Hàng :                                                      ║");
            Console.WriteLine("\t\t║                                                                          ║");
            Console.WriteLine("\t\t║    Địa Chỉ Khách Hàng :                                                  ║");
            Console.WriteLine("\t\t║                                                                          ║");
            Console.WriteLine("\t\t║    SĐT Khách Hàng :                                                      ║");
            Console.WriteLine("\t\t║                                                                          ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                                          ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════════════════════════╝");

            string maHD = "";
            while (maHD == "" || hdBUS.KiemtramaHD(maHD) == "X")
            {
                Random r = new Random();
                int i = r.Next(0, 100);
                maHD = "HD" + i;
            }
            DateTime ngaygio = DateTime.Now;

            Console.SetCursorPosition(37, 4);
            string maKH = Console.ReadLine();
            string a;
            while (maKH.Length >6 || maKH == ""||hdBUS.kiemtramaKH(maKH)=="X" )
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(36, 13);
                Console.Write(a);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(37, 4);
                Console.Write(new string(' ', maKH.Length));
                Console.SetCursorPosition(37, 4);
                maKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(36, 13);
                Console.Write(new string(' ', a.Length));
            }

            Console.SetCursorPosition(38, 6);
            string tenKH = Console.ReadLine();
            string b;
            while (tenKH.Length > 20 || tenKH == "")
            {
                b = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(36, 13);
                Console.Write(b);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(38, 6);
                Console.Write(new string(' ', tenKH.Length));
                Console.SetCursorPosition(38,6);
                tenKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(36, 13);
                Console.Write(new string(' ', b.Length));
            }

            Console.SetCursorPosition(42, 8);
            string diachiKH = Console.ReadLine();
            string c;
            while (diachiKH.Length > 30 || diachiKH == "")
            {
                c = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(36, 13);
                Console.Write(c);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(42, 8);
                Console.Write(new string(' ', diachiKH.Length));
                Console.SetCursorPosition(42, 8);
                diachiKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(36, 13);
                Console.Write(new string(' ', c.Length));
            }


            Console.SetCursorPosition(38, 10);
            string sdtKH = Console.ReadLine();
            string d;
            while (sdtKH.Length != 10 || sdtKH == "" || hdBUS.kiemtrachuoi(sdtKH) == false)
            {
                d = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(36, 13);
                Console.Write(d);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(38, 10);
                Console.Write(new string(' ', sdtKH.Length));
                Console.SetCursorPosition(38, 10);
                sdtKH = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(36, 13);
                Console.Write(new string(' ', d.Length));
            }
            khBUS.ThemKH(maKH, tenKH, sdtKH, diachiKH);
            hdBUS.ThemHoaDon(maHD, maKH, tenKH, sdtKH, diachiKH, ngaygio);

            
            Console.Clear();
            while (true)
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
                Console.WriteLine("\n");
                Console.Write("\t\tNhập mã hàng hóa : ");
                string maHH = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.Write("\t\tSố lượng : ");
                int soluong = int.Parse(Console.ReadLine());
                hdBUS.ThemChiTietHoaDon(maHD, maKH, maHH, soluong);
                Console.Write("\n\t\t Nhấn 0 để tiếp tục thêm hàng hóa(ENTER để kết thúc): ");
                string s = Console.ReadLine();
                if (s != "0")
                {
                    Console.WriteLine("\n\t\t ĐÃ THÊM HÓA ĐƠN!!!");
                    break;
                }
            }
            Console.Clear();
            Console.Write("\n\t\t Nhập 1 để tiếp tục thêm hóa đơn(ENTER để trở vê màn hình chính) : ");
            string x = Console.ReadLine();
            if (x == "1")
            {
                ThemHD();
            }
            else if (x == "")
            {
                HienMENU();
            }
            
            
        }
        public void XoaHoaDon()
        {
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                     XÓA HÓA ĐƠN                      ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Mã Hóa Đơn(muốn xóa) :                              ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");

            Console.SetCursorPosition(44, 4);
            string maHD = Console.ReadLine();
            string a;
            while (maHD.Length > 5 || maHD == "" || hdBUS.KiemtramaHD(maHD) == "Y")
            {
                a = "Không hợp lệ ! Mời bạn nhập lại";
                Console.SetCursorPosition(26, 7);
                Console.Write(a);
                //Xoa nhung gi vua nhap
                Console.SetCursorPosition(44, 4);
                Console.Write(new string(' ', maHD.Length));
                Console.SetCursorPosition(44, 4);
                maHD = Console.ReadLine();
                //xoa dong string a
                Console.SetCursorPosition(26, 7);
                Console.Write(new string(' ', a.Length));
            }
            Console.WriteLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t Thông tin hóa đơn");
            Console.WriteLine("\t\t╔═══════════╦═══════════╦═════════════════════════════╦═══════════════════════╦═════════════════════════════╦══════════════════╗");
            Console.WriteLine("\t\t║   Mã HD   ║   Mã KH   ║        Tên Khách Hàng       ║    SĐT Khách Hàng     ║      Địa Chỉ Khách Hàng     ║    Ngày Lập HD   ║");
            Console.WriteLine("\t\t╠═══════════╬═══════════╬═════════════════════════════╬═══════════════════════╬═════════════════════════════╬══════════════════╣");
            hdBUS.LaythongtinHD(maHD);
            Console.WriteLine("\t\t╚═══════════╩═══════════╩═════════════════════════════╩═══════════════════════╩═════════════════════════════╩══════════════════╝");
            Console.WriteLine();
            Console.Write("\t\tNhấn ENTER để xóa , 0 để thoát:");
            string kt = Console.ReadLine();
            if (kt == "")
            {
                hdBUS.Xoa(maHD);
                Console.Write("\t\t ĐÃ XÓA HÓA ĐƠN!!!");
            }
            else if (kt == "0")
            {
                HienMENU();
            }

            
        }
    }
}
