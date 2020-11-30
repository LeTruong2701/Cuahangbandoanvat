using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cuahangbandoanvat.DAL
{
    class KhachHangDAL
    {
        private static string file = "khachhang.txt";
        private static string file_hoadon = "hoadon.txt";
        private static string file_hoadonchitiet = "hoadonchitiet.txt";
        public List<String> Laydanhsach()
        {
            StreamReader sr = new StreamReader(file);
            String s;
            List<String> ds = new List<string>();
            while ((s = sr.ReadLine()) != null)
            {

                String[] tmp = s.Split('#');

                String kq = tmp[0] + "\t" + tmp[1]+"\t"+tmp[2]+"\t"+tmp[3];
                ds.Add(kq);
            }

            sr.Close();
            return ds;
        }
        public void Xoa(string maKH)
        {
            string kq = "";
            string s;
            StreamReader sr = new StreamReader(file);
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != maKH)
                {
                    kq = kq + s + "\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(kq);
            sw.Close();

            string kq2 = "";
            StreamReader sr2 = new StreamReader(file_hoadon);
            while ((s = sr2.ReadLine()) != null)
            {
                string [] tmp2 = s.Split('#');
                if (tmp2[1] != maKH)
                {
                    kq2 = kq2 + s + "\n";
                }
            }
            sr2.Close();
            StreamWriter sw2 = new StreamWriter(file_hoadon);
            sw2.Write(kq2);
            sw2.Close();

            string kq3 = "";
            StreamReader sr3 = new StreamReader(file_hoadonchitiet);
            while ((s = sr3.ReadLine()) != null)
            {
                string[] tmp3 = s.Split('#');
                if (tmp3[1] != maKH)
                {
                    kq3 = kq3 + s + "\n";
                }
            }
            sr3.Close();
            StreamWriter sw3 = new StreamWriter(file_hoadonchitiet);
            sw3.Write(kq3);
            sw3.Close();

        }
        public void Sua(string maKH,string tenKH,string diachiKH,int sdtKH)
        {
            string kq = "";
            string s;
            StreamReader sr = new StreamReader(file);
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != maKH)
                {
                    kq = kq + s + "\n";
                }
                else
                {
                    kq = kq + maKH + "#" + tenKH + "#" + diachiKH + "#" + sdtKH + "\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(kq);
            sw.Close();
        }
        public void ThemKH(string maKH,string tenKH,string diachiKH,int sdtKH)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(maKH + "#" + tenKH + "#" + diachiKH + "#" + sdtKH);
            sw.Close();
        }
    }
}
