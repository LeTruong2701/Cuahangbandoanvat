using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cuahangbandoanvat.DAL
{
    class HangHoaDAL
    {
        private static string file = "hanghoa.txt";
        private static string file_loaihang = "loaihang.txt";

        public void Them(string maHH,string tenHH,string loaiHH, double giaban)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(maHH + "#" + tenHH + "#" + loaiHH + "#" + giaban);
            sw.Close();
        }
        public string Layloaihang(string s)//lay ten loai hang
        {
            StreamReader sr = new StreamReader(file_loaihang);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s || tmp[1] == s)
                {
                    kq = tmp[1];
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
        public string Laydsmathangtheoloaihang(string s)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[2] == s)
                {
                    kq += tmp[0] + "\t" + tmp[1] + "\t" + tmp[3]+"\n";
                }
            }
            sr.Close();
            return kq;
        }

        public void Sua(string maHH,string tenHH, string loaiHH, double giaban)
        {
            string kq = "";
            string s;
            StreamReader sr = new StreamReader(file);
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if(tmp[0]!= maHH)
                {
                    kq = kq + s + "\n";
                }
                else
                {
                    kq = kq + maHH + "#" + tenHH + "#" + loaiHH + "#" + giaban+"\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(kq);
            sw.Close();
        }
        
        public void Xoa(string maHH)
        {
            string kq = "";
            string s;
            StreamReader sr = new StreamReader(file);
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] != maHH)
                {
                    kq = kq + s + "\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(kq);
            sw.Close();
        }
        public string Timkiem(string s)//Tim kiem hang hoa
        {
            string kq = "";
            string a;
            StreamReader sr = new StreamReader(file);
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s || tmp[1]==s|| tmp[2]==s||tmp[3]==s)
                {
                    kq += tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\n";
                }
            }
            sr.Close();
            return kq;
        }

        public string Laythongtinhanghoa(string maHH)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if( tmp[0]== maHH)
                {
                    kq = tmp[0]+"\t" + tmp[1]+"\t" + tmp[2]+"\t" + tmp[3];
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
                string kq = tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3];
                ds.Add(kq);
            }
            sr.Close();
            return ds;
        }
    }
}
