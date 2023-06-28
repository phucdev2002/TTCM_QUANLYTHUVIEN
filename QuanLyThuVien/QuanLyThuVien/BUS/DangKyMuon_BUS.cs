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

        public void Them(DangKyMuon _dkm)
        {
            dkmDao.Insert(_dkm);
        }

        public DataTable TimKiem(string _timkiem, string _loaitk)
        {
            return dkmDao.Search(_timkiem, _loaitk);
        }

    }
}
