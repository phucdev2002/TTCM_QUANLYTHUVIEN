using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
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
        public DataTable GetList(string _tdn)
        {
            return dkmDao.loadDangKyMuon(_tdn);
        }

        public int Them(DangKyMuon _dkm)
        {
            if (string.IsNullOrEmpty(_dkm.MaPhieu))
                return 0;
            if (!dkmDao.Insert(_dkm))
                return -1;
            return 1;
        }
    }
}
