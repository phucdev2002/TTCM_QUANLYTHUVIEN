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
        public DataTable loadDangKyMuon()
        {
            string sqlString = @"select DK.MaPhieu, DK.MaDocGia, DG.HoTen, DK.MaSach, S.TenSach, DK.NgayMuon, DK.NgayPhaiTra from DOCGIA DG, DANGKYMUON DK, SACH S where DK.MaDocGia = DG.MaDocGia and DK.MaSach = S.MaSach";
            return GetData(sqlString);
        }

    }
}
