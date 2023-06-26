using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    class DangKyMuon_DAO : DataProvider
    {
        public DataTable loadDangKyMuon(string _tdn)
        {
            string sqlString = string.Format("select * from DANGKYMUON, SACH, ACCOUNT where DANGKYMUON.MaDocGia = ACCOUNT.MaDocGia and SACH.MaSach = DANGKYMUON.MaSach and ACCOUNT.TenDangNhap = '{0}'", _tdn);
            return GetData(sqlString);
        }

        public bool Insert(DangKyMuon _dkm)
        {
            if (GetData("select* from DANGKYMUON where MaPhieu = '" + _dkm.MaPhieu + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("Insert Into DANGKYMUON values('{0}','{1}','{2}','{3}', '{4}')",
                _dkm.MaPhieu, _dkm.MaDocGia, _dkm.MaSach, _dkm.NgayMuon, _dkm.NgayPhaiTra);

            Excute(sql);
            return true;
        }

    }
}
