using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuahangbandoanvat.DAL;

namespace Cuahangbandoanvat.BUS
{
    class LoaiHangBUS
    {
        private LoaiHangDAL lhDAL = new LoaiHangDAL();
        public void ThemLH(string maLH, string tenLH)
        {
            lhDAL.Them(maLH, tenLH);
        }
        public void SuaLH(string maLH, string tenLH)
        {
            lhDAL.Sua(maLH, tenLH);
        }
        public void XoaLH(string maLH)
        {
            lhDAL.Xoa(maLH);
        }
        public List<string> LayDanhSach()
        {
            return lhDAL.Laydanhsach();
        }
    }
}
