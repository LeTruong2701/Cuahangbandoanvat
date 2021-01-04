using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cuahangbandoanvat.DAL
{
    class HoaDonDAL
    {
        private static string file = "hoadon.txt";
        private static string file_chitiet = "hoadonchitiet.txt";
        private static string file_hanghoa = "hanghoa.txt";
        private HangHoaDAL hhDAl = new HangHoaDAL();

        //lấy thông tin hóa đơn để in ra thông tin trong chức năng xóa
        public void LaythongtinHD(string maHD)
        {
            StreamReader sr = new StreamReader(file);
            
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == maHD)
                {
                    Console.WriteLine("\t\t║  {0,-5}    ║  {1,-5}    ║    {2,-18}       ║    {3,-10}         ║    {4,-25}║    {5,-12}  ║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5]);
                }
            }
            sr.Close();
            
        }

        //dùng để lấy mã HD cho KH
        public string Laythongtinhoadon(string maKH)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[1] == maKH)
                {
                    kq = tmp[0];
                }
            }
            sr.Close();
            return kq;
        }


        public List<string> Laydanhsach()
        {
            StreamReader sr = new StreamReader(file);
            string s;
            List<string> ds = new List<string>();
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                String kq = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" + tmp[4]+"\t"+tmp[5];
                ds.Add(kq);
            }
            sr.Close();
            return ds;
        }

        public void HienchitietHD(string maHD)
        {
            StreamReader sr = new StreamReader(file_chitiet);
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == maHD)
                {
                    Console.WriteLine("\t\t║    {0,-40}              Số lượng : {1,-3}               ║", hhDAl.Laythongtinhanghoa(tmp[2]), tmp[3]);
                }
            }
            sr.Close();
        }
        //public List<string> HienchitietHD(string maHD)
        //{
        //    StreamReader sr = new StreamReader(file_chitiet);
        //    string s;
        //    List<string> ds = new List<string>();
        //    while ((s = sr.ReadLine()) != null)
        //    {
        //        string[] tmp = s.Split('#');
        //        if (tmp[0] == maHD)
        //        {
        //            string kq = hhDAl.Laythongtinhanghoa(tmp[2]) + "\t So luong :" + tmp[3];
        //            ds.Add(kq);
        //        }
        //    }
        //    sr.Close();
        //    return ds;
        //}
        public void ThemHD(string maHD,string maKH,string tenKH, string sdtKH,string diachiKH,DateTime ngaygio)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(maHD + "#"+maKH+"#" + tenKH + "#" + sdtKH + "#" +diachiKH+"#"+ngaygio.ToString("MM/dd/yyyy"));
            sw.Close();
        }
        public void ThemchitietHD(string maHD,string maKH,string maHH,int soluong)
        {
            StreamWriter sw = new StreamWriter(file_chitiet, true);
            sw.WriteLine(maHD +"#"+ maKH+ "#" + maHH + "#" + soluong);
            sw.Close();
        }
        public void XoaHD(string maHD)
        {
            StreamReader sr = new StreamReader(file);
            string s;
            string kq = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != maHD)
                {
                    kq += s + "\n";
                }

            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(kq);
            sw.Close();

            kq = "";
            sr = new StreamReader(file_chitiet);
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if(tmp[0]!= maHD)
                {
                    kq += s + "\n";
                }
            }
            sr.Close();
            sw =new StreamWriter(file_chitiet);
            sw.Write(kq);
            sw.Close();

        }
        public void TimkiemKHtheohoadon(string s)
        {
            StreamReader sr = new StreamReader(file);
            
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s)
                {
                    Console.WriteLine("\t\t║ Mã khách hàng :{0,-10}                                                             ║",tmp[1]);
                    Console.WriteLine("\t\t║ Tên khách hàng:{0,-30}                                         ║",tmp[2]);
                    Console.WriteLine("\t\t║ SĐT : {0,-10}                                                                      ║",tmp[3]);
                    Console.WriteLine("\t\t║ Địa chỉ :{0,-30}                   Ngày lập: {1,-15}   ║",tmp[4],tmp[5]);
                        //kq = tmp[1] + "\t" + tmp[2] + "\t" + tmp[3]+"\t"+tmp[4];
                }
            }
            sr.Close();
            
        }
        public void Timkiemhoadon(string s)
        {
            StreamReader sr = new StreamReader(file);
            
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if(tmp[0] == s || tmp[1] == s || tmp[2] == s || tmp[3] == s || tmp[4] == s||tmp[5]==s)
                {
                    Console.WriteLine("\t\t║  {0,-5}    ║  {1,-5}    ║    {2,-18}       ║    {3,-10}         ║    {4,-25}║    {5,-12}  ║", tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], tmp[5]);
                    //kq +=tmp[0]+"\t"+ tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" + tmp[4]+"\n";
                }
            }
            sr.Close();
            
        }
        public string KiemTra(string s)//Kiem tra xem mahoadon da ton tai hay chua
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s)
                {
                    kq = "X";
                    break;
                }
                else
                {
                    kq = "V";
                }
            }
            sr.Close();
            return kq;
        }
        // kiểm tra thông tin hóa đơn có trong tệp hay không
        public string KiemtrathongtinHD(string s)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s || tmp[1] == s || tmp[2] == s || tmp[3] == s||tmp[4]==s||tmp[5]==s)
                {
                    kq = "X";
                    break;
                }
                else
                {
                    kq = "Y";
                }
            }
            sr.Close();
            return kq;
        }

        //tính tổng tiền cua hóa đơn
        public double Tongtien(string maHD)
        {
            StreamReader sr1 = new StreamReader(file_chitiet);
            string a;
            string b;
            double Tong = 0;
            while ((a = sr1.ReadLine()) != null)
            {
                
                string[] tmp1 = a.Split('#');
                if (tmp1[0] == maHD)
                {
                    StreamReader sr2 = new StreamReader(file_hanghoa);
                    while ((b = sr2.ReadLine()) != null)
                    {
                        string[] tmp2 = b.Split('#');
                        if (tmp1[2] == tmp2[0])
                        {
                            double k = double.Parse(tmp1[3]);
                            double j = double.Parse(tmp2[3]);
                            Tong += k * j;
                        }
                    }
                }
                
            }
            return Tong;
        }
        //kiem tra sdt 
        public bool checkNum(string s)
        {
            foreach (char x in s)
            {
                if (!char.IsNumber(x))
                    return false;
            }
            return true;
        }
        //KIEM TRA XEM MAKH đã tồn tại hay chưa
        public string KiemtramaKH(string s)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[1] == s)
                {
                    kq = "X";
                    break;
                }
                else
                {
                    kq = "Y";
                }
            }
            sr.Close();
            return kq;
        }
    }
}