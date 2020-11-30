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
        private string file = "hanghoa.txt";

        public void Them(string maHH,string tenHH,string loaiHH, double giaban)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(maHH + "#" + tenHH + "#" + loaiHH + "#" + giaban);
            sw.Close();
        }

        public void Sua(string maHH,string tenHH, string loaiHH, double giaban)
        {
            string kq = "";
            string s;
            StreamReader sr = new StreamReader(file);
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if(tmp[0]!= loaiHH)
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
