//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace Cuahangbandoanvat.DAL
//{
//    class ThongkeDAL
//    {
//        private static string file_hanghoa = "hanghoa.txt";
//        private static string file_hoadon = "hoadon.txt";
//        private static string file_hoadonchitiet = "hoadonchitiet.txt";
//        public void Thongketheonam(int s)
//        {
//            StreamReader sr = new StreamReader(file_hoadon);
//            StreamReader sr2 = new StreamReader(file_hanghoa);
//            StreamReader sr1 = new StreamReader(file_hoadonchitiet);
//            string kq = "";
//            string a;
//            string b;
//            string c;
            
            
//            while ((a = sr.ReadLine()) != null)
//            {
//                string[] tmp = a.Split('#');

//                if (DateTime.Parse(tmp[5]).Year == s)
//                {
//                    while ((b = sr1.ReadLine()) != null)
//                    {
//                        string[] tmp1 = b.Split('#');
//                        if (tmp1[0] == tmp[0])
//                        {
//                            while ((c = sr2.ReadLine()) != null)
//                            {
//                                string[] tmp2 = c.Split('#');
//                                if(tmp2[])
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
