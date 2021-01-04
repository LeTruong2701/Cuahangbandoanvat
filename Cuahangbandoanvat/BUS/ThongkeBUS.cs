using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.DAL;

namespace Cuahangbandoanvat.BUS
{
     
    class ThongkeBUS
    {
        private ThongkeDAL tkDAL = new ThongkeDAL();
        public double Tongtientheonam(int s)
        {
           return tkDAL.Thongketheonam(s);
        }
    }
}
