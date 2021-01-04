using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.BUS;

namespace Cuahangbandoanvat.GUI
{
    class ThongKeGUI
    {
        private ThongkeBUS tkBUS = new ThongkeBUS();
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
                Console.Write("\n\t\t║ ║                         THỐNG KÊ BÁO CÁO                          ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║     TỔNG THU NHẬP            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║     TỔNG CHI TIÊU            ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║     MẶT HÀNG BÁN CHẠY        ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║     QUAY LẠI MENU CHÍNH      ║                 ║ ║");
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
                Console.SetCursorPosition(65, 23);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case '1':HienMenuthunhap(); Console.ReadKey(); break;
                        //case '2': ThemLoaiHang(); Console.ReadKey(); break;
                        //case '3': SuaLoaiHang(); Console.ReadKey(); break;
                        //case '4': XoaLoaiHang(); Console.ReadKey(); break;
                        case '4': kt = true; break;
                }
            }
        }
        

        public void HienMenuthunhap()
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
                Console.Write("\n\t\t║ ║                         THỐNG KÊ BÁO CÁO                          ║ ║");
                Console.Write("\n\t\t║ ║                                                                   ║ ║");
                Console.Write("\n\t\t║ ║              ╔═══╦══════════════════════════════╗                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 1.║     TỔNG THU NHẬP THEO NĂM   ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 2.║     TỔNG THU NHẬP THEO THÁNG ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 3.║     TỔNG THU NHẬP THEO NGÀY  ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║___║______________________________║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║   ║                              ║                 ║ ║");
                Console.Write("\n\t\t║ ║              ║ 4.║     QUAY LẠI                 ║                 ║ ║");
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
                Console.SetCursorPosition(65, 23);
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                     case '1': Tongthunhaptheonam(); Console.ReadKey(); break;
                        //case '2': ThemLoaiHang(); Console.ReadKey(); break;
                        //case '3': SuaLoaiHang(); Console.ReadKey(); break;
                        //case '4': XoaLoaiHang(); Console.ReadKey(); break;
                        case '4': kt = true; break;
                }
            }
        }

        public void Tongthunhaptheonam()
        {
            //
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                      TỔNG THU NHẬP                   ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Thu nhập năm :                                      ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            Console.SetCursorPosition(35,4);
            int s = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\t\t╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                      TỔNG THU NHẬP                   ║");
            Console.WriteLine("\t\t╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Thu nhập năm :  {0,-5}                               ║",s);
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t║  Tổng thu nhập năm {0,-5} là {1,-6} đồng              ║",s,tkBUS.Tongtientheonam(s));
            Console.WriteLine("\t\t║                                                      ║");
            Console.WriteLine("\t\t╚══════════════════════════════════════════════════════╝");
            Console.WriteLine("\t\tNhấn phím bất kỳ để tiếp tục...");

        }
        //public void Tonthunhaptheothang()
        //{

        //}
    }
}
