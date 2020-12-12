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
        private HangHoaBus hhBUS = new HangHoaBus();
        private LoaiHangGUI lhGUI = new LoaiHangGUI();
        public void HienMENU()
        {
            bool kt = false;
            while (! kt)
            {
                Console.Clear();
                Console.WriteLine("QUAN LY HANG HOA");
                Console.WriteLine("1.Hien thi hang hoa");
                Console.WriteLine("2.Them hang hoa");
                Console.WriteLine("3.Sua hang hoa");
                Console.WriteLine("4.Xoa hang hoa");
                Console.WriteLine("5.Tim kiem hang hoa");
                Console.WriteLine("6.Quay lai");
                Console.Write("Ban chon :");
                char key = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (key)
                {
                    case '1':HienHangHoa();Console.ReadKey();break;
                    case '2':ThemHangHoa();Console.ReadKey();break;
                    case '3':SuaHangHoa();Console.ReadKey();break;
                    case '4':XoaHangHoa();Console.ReadKey();break;
                    case '5':TimKiemHangHoa();Console.ReadKey();break;
                    case '6':kt = true;break;
                }
            }
        }
        public void HienHangHoa()
        {
            Console.WriteLine("Danh sach hang hoa");
            foreach(string s in hhBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
        }
        public void TimKiemHangHoa()
        {
            Console.WriteLine("Nhap thong tin hang hoa can tim kiem");
            Console.Write("Nhap  hang hoa ban muon tim:");
            string s = Console.ReadLine();
            Console.WriteLine("hang hoa ban muon tim");
            Console.WriteLine(hhBUS.Timkiem(s));
            
        }
        public void ThemHangHoa()
        {
            Console.WriteLine("Nhap thong tin hang hoa can them");
            lhGUI.HienLoaiHang();
            Console.Write("Nhap loai hang ban muon them :");
            string maLH = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Danh sach hang hoa da co trong cua hang");
            foreach (string s in hhBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }
            string maHH = "";
            while (maHH == "" || hhBUS.KiemTra(maHH)=="X")
            {
                Random r = new Random();
                int i = r.Next(0, 100);
                maHH = "MH"+i;
            }
            Console.Write("Nhap ten hang hoa:");
            string tenHH = Console.ReadLine();
            while (tenHH == "")
            {
                Console.WriteLine("Khong duoc khac rong,moi ban nhap lai!!");
                Console.Write("Nhap ten hang hoa:");
                tenHH = Console.ReadLine();   
            }
            double giaban = 0;
            while (giaban <= 0)
            {
                try
                {
                    Console.Write("Nhap gia ban:");
                    giaban = double.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Khong hop le, moi ban nhap lai gia ban!!");
                }
            }
            hhBUS.Them(maHH, tenHH,hhBUS.Layloaihang(maLH), giaban);
            Console.WriteLine("Da them thanh cong");
        }
        public void SuaHangHoa()
        {
            Console.WriteLine("Nhap thong tin hang hoa muon sua");
            lhGUI.HienLoaiHang();
            Console.Write("Nhap loai hang ban muon sua:");
            string maLH = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Danh sach mat hang");
            Console.WriteLine(hhBUS.Laydsmathangtheoloaihang(hhBUS.Layloaihang(maLH)));
            Console.Write("Nhap ma hang hoa can sua :");
            string maHH = Console.ReadLine();
            Console.Write("Nhap ten hang hoa moi :");
            string tenHH = Console.ReadLine();
            Console.Write("Nhap gia ban moi:");
            double giaban = double.Parse(Console.ReadLine());
            hhBUS.Sua(maHH, tenHH,hhBUS.Layloaihang(maLH), giaban);
            Console.WriteLine("Da cap nhat thanh cong");
        }
        public void XoaHangHoa()
        {
            Console.WriteLine("Nhap thong tin hang hoa can xoa");
            lhGUI.HienLoaiHang();
            Console.Write("Nhap loai hang :");
            string maLH = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Danh sach loai hang {0}", hhBUS.Layloaihang(maLH));
            Console.WriteLine(hhBUS.Laydsmathangtheoloaihang(hhBUS.Layloaihang(maLH)));
            Console.Write("Nhap ma hang hoa ban muon xoa:");
            string maHH = Console.ReadLine();
            hhBUS.Xoa(maHH);
            Console.WriteLine("Da xoa thanh cong ");
        }
    }
}
