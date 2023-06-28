using DevExpress.XtraEditors;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class ucFrmDangKyMuonSach : DevExpress.XtraEditors.XtraUserControl
    {
        DangKyMuon_BUS dkmBUS = new DangKyMuon_BUS();
        DataProvider _dt = new DataProvider();
        private string tdn;

        public ucFrmDangKyMuonSach(string _tdn)
        {
            InitializeComponent();
            tdn = _tdn;
        }

        private void ucFrmDangKyMuonSach_Load(object sender, EventArgs e)
        {           
            DataTable dt = _dt.GetData("select ACC.TenDangNhap, ACC.MaDocGia, DG.MaDocGia, DG.HoTen, S.TenSach, S.MaSach from ACCOUNT ACC, DOCGIA DG, SACH S where ACC.MaDocGia = DG.MaDocGia and ACC.TenDangNhap = '" + tdn + "'");
            txt_MDG.DataBindings.Add("Text", dt, "MaDocGia", true);
            txt_TDG.DataBindings.Add("Text", dt, "HoTen", true);
            cb_TS.DataSource = dt;
            cb_TS.DisplayMember = "TenSach";
            if(cb_TS.DisplayMember == "TenSach")
            {
                txt_MS.DataBindings.Add("Text", dt, "MaSach", true);
            }
            gridControl1.DataSource = dkmBUS.GetList(tdn);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DangKyMuon _dkm = new DangKyMuon();
            
            _dkm.MaDocGia = txt_MDG.Text;
            _dkm.MaSach = txt_MS.Text;
            _dkm.TenSach = cb_TS.Text;
            if (d_NM.Text == "")
                _dkm.NgayMuon = DateTime.Now;
            else
                _dkm.NgayMuon = d_NM.DateTime;
            if (d_NPT.Text == "")
                _dkm.NgayPhaiTra = DateTime.Now;
            else
                _dkm.NgayPhaiTra = d_NPT.DateTime;

            dkmBUS.Them(_dkm);
            ucFrmDangKyMuonSach_Load(sender, e);
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = dkmBUS.GetList(tdn);

            }
            else
            {
                if(rdoBtnTenSach.Checked == true)
                    gridControl1.DataSource = dkmBUS.TimKiem(txtTimKiem.Text, "TenSach");              
            }
        }
    }
}
