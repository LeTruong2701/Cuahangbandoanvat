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

        public void Them(string maHH,string tenHH,string loaiHH, string giaban)
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
        public string KiemTra(string s)//Kiem tra xem mahanghoa da ton tai hay chua
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
                    kq = "Y";
                }
            }
            sr.Close();
            return kq;
        }
        //kiểm tra tên hàng hóa đã tồn ại hay chua
        public string KiemTratenHH(string s)
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
        //kiểm tra mã loại hàng đã tồn tại chưa
        public string KiemTramaLH(string s)
        {
            StreamReader sr = new StreamReader(file_loaihang);
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
                    kq = "Y";
                }
            }
            sr.Close();
            return kq;
        }

        //lấy danh sách hàng hóa tìm kiếm theo tên loại hàng
        public void laydshanghoatheoloaihang(string tenLH)
        {
            StreamReader sr = new StreamReader(file);

            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[2] == tenLH)
                {
                    Console.WriteLine("\t\t║    {0,-5}    ║      {1,-18}        ║      {2,-15}     ║     {3,-8}            ║", tmp[0], tmp[1], tmp[2], tmp[3]);
                    //kq = tmp[0]+"\t" + tmp[1]+"\t" + tmp[2]+"\t" + tmp[3];
                }
            }
            sr.Close();

        }

        public void Sua(string maHH,string tenHH, string loaiHH, string giaban)
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
        public void Timkiem(string s)//Tim kiem hang hoa
        {

            string a;
            StreamReader sr = new StreamReader(file);
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s || tmp[1]==s|| tmp[2]==s||tmp[3]==s)
                {
                    Console.WriteLine("\t\t║    {0,-5}    ║      {1,-18}        ║      {2,-15}     ║     {3,-8}            ║", tmp[0], tmp[1], tmp[2], tmp[3]);
                    //kq += tmp[0] + "\t" + tmp[1] + "\t" + tmp[2] + "\t" + tmp[3] + "\n";
                }
            }
            sr.Close();
            
        }
        //lấy thông tin hàng hóa để hiện thông tin hàng hóa (xóa)
        public void laythongtinhanghoagui(string maHH)
        {
            StreamReader sr = new StreamReader(file);
            
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if( tmp[0]== maHH)
                {
                    Console.WriteLine("\t\t║    {0,-5}    ║      {1,-18}        ║      {2,-15}     ║     {3,-8}       ║", tmp[0], tmp[1], tmp[2], tmp[3]);
                    //kq = tmp[0]+"\t" + tmp[1]+"\t" + tmp[2]+"\t" + tmp[3];
                }
            }
            sr.Close();
            
        }
        //lay thông tin hàng hóa để thêm vào tệp hóa đơn
        public string Laythongtinhanghoa(string maHH)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] tmp = s.Split('#');
                if (tmp[0] == maHH)
                {
                    
                    kq = /*tmp[0] + "\t" +*/ tmp[1]+ "    " + tmp[2]+ "    " + tmp[3];
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
        //kiểm tra xem có thông tin hàng hóa trong tệp hay không
        public string KiemtrathongtinHH(string s)
        {
            StreamReader sr = new StreamReader(file);
            string kq = "";
            string a;
            while ((a = sr.ReadLine()) != null)
            {
                string[] tmp = a.Split('#');
                if (tmp[0] == s || tmp[1] == s || tmp[2] == s || tmp[3] == s)
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
        //kiểm tra giá bán có phải là số hay không
        public bool checkNum(string s)
        {
            foreach (char x in s)
            {
                if (!char.IsNumber(x))
                    return false;
            }
            return true;
        }
    }
}
