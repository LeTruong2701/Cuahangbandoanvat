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
        public List<string> Laydanhsach()
        {
            StreamReader sr = new StreamReader(file);
            string s;
            List<string> ds = new List<string>();
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                string kq = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3];
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
        public void ThemHD(string maHD,string tenKH,string diachiKH,int sdtKH)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(maHD + "#" + tenKH + "#" + diachiKH + "#" + sdtKH);
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
    }
}