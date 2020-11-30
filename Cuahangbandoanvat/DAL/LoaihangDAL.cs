using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cuahangbandoanvat.DAL
{
    class LoaiHangDAL
    {
        private static string file = "loaihang.txt";

        public void Them(string maLH,string tenLH)
        {
            StreamWriter sw = new StreamWriter(file, true);
            sw.WriteLine(maLH + "#" + tenLH);
            sw.Close();
        }

        public void Sua(string maLH,string tenLH)
        {
            string kq = "";
            string s;
            StreamReader sr = new StreamReader(file);
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if(tmp[0]!= maLH)
                {
                    kq = kq + s + "\n";
                }
                else
                {
                    kq = kq + maLH + "#" + tenLH + "\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(kq);
            sw.Close();
        }
        public void Xoa(string maLH)
        {
            string kq = "";
            string s;
            StreamReader sr = new StreamReader(file);
            while((s=sr.ReadLine())!= null)
            {
                string[] tmp = s.Split('#');
                if(tmp[0]!= maLH)
                {
                    kq = kq + s + "\n";
                }
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);
            sw.Write(kq);
            sw.Close();
        }
        public List<String> Laydanhsach()
        {
            StreamReader sr = new StreamReader(file);
            String s;
            List<String> ds = new List<string>();
            while ((s = sr.ReadLine()) != null)
            {

                String[] tmp = s.Split('#'); 

                String kq = tmp[0] + "\t" + tmp[1];
                ds.Add(kq);
            }

            sr.Close();

            return ds;
        }
    }
}
