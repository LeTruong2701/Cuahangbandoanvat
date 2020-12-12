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
        private HangHoaDAL hhDAl = new HangHoaDAL();
        
        //dùng để lấy mã HD
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
                string kq = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3]+"\t"+tmp[4]+"\t"+tmp[5];
                ds.Add(kq);
            }
            sr.Close();
            return ds;
        }
        public List<string> HienchitietHD(string maHD)
        {
            StreamReader sr = new StreamReader(file_chitiet);
            string s;
            List<string> ds = new List<string>();
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == maHD)
                {
                    string kq = hhDAl.Laythongtinhanghoa(tmp[2]) + "\t So luong :" + tmp[3];
                    ds.Add(kq);
                }
            }
            sr.Close();
            return ds;
        }
        public void ThemHD(string maHD,string maKH,string tenKH, double sdtKH,string diachiKH,DateTime ngaygio)
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
            sw.WriteLine(kq);
            sw.Close();

        }
        public string TimkiemKHtheohoadon(string s)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s || tmp[1] == s || tmp[2] == s || tmp[3] == s||tmp[4]==s)
                {
                    kq = tmp[1] + "\t" + tmp[2] + "\t" + tmp[3]+"\t"+tmp[4];
                }
            }
            sr.Close();
            return kq;
        }
        public string Timkiemhoadon(string s)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if(tmp[0] == s || tmp[1] == s || tmp[2] == s || tmp[3] == s || tmp[4] == s||tmp[5]==s)
                {
                    kq +=tmp[0]+"\t"+ tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\t" + tmp[4]+"\n";
                }
            }
            sr.Close();
            return kq;
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
        //public void SuaChitiettrongHD(string maHD,string maKH,string maHH,int soluong)
        //{
        //    string kq = "";
        //    string s;
        //    StreamReader sr = new StreamReader(file);
        //    while ((s = sr.ReadLine()) != null)
        //    {
        //        string[] tmp = s.Split('#');
        //        if (tmp[0] != maHD)
        //        {
        //            kq = kq + s + "\n";
        //        }
        //        else
        //        {
        //            kq = kq + maHD + "#" + maKH + "#"+maHH+"#"+soluong+"\n";
        //        }
        //    }
        //    sr.Close();
        //    StreamWriter sw = new StreamWriter(file);
        //    sw.Write(kq);
        //    sw.Close();
        //}
    }
}