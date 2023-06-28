using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    class QLDangKyMuon_DAO : DataProvider
    {
        public DataTable loadQLDangKyMuon()
        {
            string sqlString = @"select DANGKYMUON.MaDocGia, DOCGIA.HoTen, DANGKYMUON.MaSach, DANGKYMUON.TenSach, DANGKYMUON.NgayMuon, DANGKYMUON.NgayPhaiTra from DOCGIA, DANGKYMUON where DANGKYMUON.MaDocGia = DOCGIA.MaDocGia";
            return GetData(sqlString);
        }

        public DataTable Search(string _timkiem, string _loaitk)
        {

            string table = "";
            if (_loaitk == "HoTen")
                table = "DOCGIA";
            else
                table = "DANGKYMUON";
                string sqlString = string.Format("select DANGKYMUON.MaDocGia, DOCGIA.HoTen, DANGKYMUON.MaSach, DANGKYMUON.TenSach, DANGKYMUON.NgayMuon, DANGKYMUON.NgayPhaiTra from DOCGIA, DANGKYMUON where DANGKYMUON.MaDocGia = DOCGIA.MaDocGia and {0}.{1} like N'%{2}%'", table, _loaitk, _timkiem);
            return GetData(sqlString);
        }
    }
}
