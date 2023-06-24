using DevExpress.XtraEditors;
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
        DataProvider _dt = new DataProvider();
        private string tdn;

        public ucFrmDangKyMuonSach(string _tdn)
        {
            InitializeComponent();
            this.tdn = _tdn;
        }

        private void ucFrmDangKyMuonSach_Load(object sender, EventArgs e)
        {
            DataTable dt = _dt.GetData("select * from ACCOUNT, DOCGIA, SACH where ACCOUNT.MaDocGia = DOCGIA.MaDocGia and ACCOUNT.TenDangNhap = '" + tdn + "'");
            txt_MDG.DataBindings.Add("Text", dt, "MaDocGia", true);
            txt_TDG.DataBindings.Add("Text", dt, "HoTen", true);
            cb_TS.DataSource = dt;
            cb_TS.DisplayMember = "TenSach";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
