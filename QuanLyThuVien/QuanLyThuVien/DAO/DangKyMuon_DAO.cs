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
            string sqlString = string.Format("select * from DANGKYMUON, SACH, ACCOUNT where DANGKYMUON.MaDocGia = ACCOUNT.MaDocGia and SACH.TenSach = DANGKYMUON.TenSach and ACCOUNT.TenDangNhap = '{0}'", _tdn);
            return GetData(sqlString);
        }

        public void Insert(DangKyMuon _dkm)
        {
            string sql = string.Format("Insert Into DANGKYMUON values('{0}','{1}','{2}','{3}','{4}')",
                _dkm.MaDocGia, _dkm.MaSach, _dkm.TenSach, _dkm.NgayMuon, _dkm.NgayPhaiTra);
            Excute(sql);
        }

        public DataTable Search(string _timkiem, string _loaitk)
        {
            string table = "";
            table = "DANGKYMUON";
            string sqlString = string.Format("select DANGKYMUON.MaDocGia, DOCGIA.HoTen, DANGKYMUON.MaSach, DANGKYMUON.TenSach, DANGKYMUON.NgayMuon, DANGKYMUON.NgayPhaiTra from DOCGIA, DANGKYMUON where DANGKYMUON.MaDocGia = DOCGIA.MaDocGia and {0}.{1} like N'%{2}%'", table, _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
