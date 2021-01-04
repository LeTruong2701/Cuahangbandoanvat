using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cuahangbandoanvat.DAL
{
    class ThongkeDAL
    {
        private static string file_hanghoa = "hanghoa.txt";
        private static string file_hoadon = "hoadon.txt";
        private static string file_hoadonchitiet = "hoadonchitiet.txt";
        public double Thongketheonam(int s)
        {
            StreamReader sr1 = new StreamReader(file_hoadon);
            
            
            string a;
            string b;
            string c;
            double tong = 0;


            while ((a = sr1.ReadLine()) != null)
            {
                string[] tmp1 = a.Split('#');

                if (DateTime.Parse(tmp1[5]).Year == s)
                {
                    StreamReader sr2 = new StreamReader(file_hoadonchitiet);
                    while ((b = sr2.ReadLine()) != null)
                    {
                        string[] tmp2 = b.Split('#');
                        if (tmp2[0] == tmp1[0])
                        {
                            StreamReader sr3 = new StreamReader(file_hanghoa);
                            while ((c=sr3.ReadLine()) != null)
                            {
                                string[] tmp3 = c.Split('#');
                                if (tmp3[0] == tmp2[2])
                                {
                                    double k = double.Parse(tmp3[3]);
                                    double j = double.Parse(tmp2[3]);
                                    tong+=k*j;
                                }
                            }
                        }
                    }
                }
            }
            return tong;
        }
        //public double Thongketheothang(string s)
        //{
        //    string a, b, c;
        //    double tong = 0;
        //    StreamReader sr1 = new StreamReader(file_hoadon);
        //    while ((a = sr1.ReadLine()) != null)
        //    {
        //        string[] tmp1 = a.Split('#');
        //        if (DateTime.Parse(tmp1[5]).Month==))
        //    }
        //}
    }
}
