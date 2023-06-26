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
            DataTable dt = _dt.GetData("select * from ACCOUNT, DOCGIA, SACH where ACCOUNT.MaDocGia = DOCGIA.MaDocGia and ACCOUNT.TenDangNhap = '" + tdn + "'");
            txt_MDG.DataBindings.Add("Text", dt, "MaDocGia", true);
            txt_TDG.DataBindings.Add("Text", dt, "HoTen", true);
            cb_TS.DataSource = dt;
            cb_TS.DisplayMember = "TenSach";
            if(cb_TS == T)

            gridControl1.DataSource = dkmBUS.GetList(tdn);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DangKyMuon _dkm = new DangKyMuon();
            
            _dkm.MaDocGia = txt_MDG.Text;
            _dkm.MaSach = txt_MS.Text;

            if (d_NM.Text == "")
                _dkm.NgayMuon = DateTime.Now;
            else
                _dkm.NgayMuon = d_NM.DateTime;
            if (d_NPT.Text == "")
                _dkm.NgayPhaiTra = DateTime.Now;
            else
                _dkm.NgayPhaiTra = d_NPT.DateTime;

            int check = dkmBUS.Them(_dkm);
            if (check == -1)
                //lb_Trung.Visible = true;
            else
                ucFrmDangKyMuonSach_Load(sender, e);
        }
    }
}
