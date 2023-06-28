using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
    class QLDangKyMuon_BUS
    {
        QLDangKyMuon_DAO qldkmDAO = new QLDangKyMuon_DAO();
        public DataTable GetList()
        {
            return qldkmDAO.loadQLDangKyMuon();
        }

        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return qldkmDAO.Search(_timkiem, _loaitk);
        }
    }
}
