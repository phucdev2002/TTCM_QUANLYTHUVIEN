using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
    class DangKyMuon_BUS
    {
        DangKyMuon_DAO dkmDao = new DangKyMuon_DAO();
        public DataTable GetList()
        {
            return dkmDao.loadDangKyMuon();
        }
    }
}
