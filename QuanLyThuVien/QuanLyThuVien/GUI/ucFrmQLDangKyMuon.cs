using DevExpress.XtraEditors;
using QuanLyThuVien.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class ucFrmQLDangKyMuon : DevExpress.XtraEditors.XtraUserControl
    {
        QLDangKyMuon_BUS qldkmBUS = new QLDangKyMuon_BUS();
        public ucFrmQLDangKyMuon()
        {
            InitializeComponent();
        }

        private void ucFrmQLDangKyMuon_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = qldkmBUS.GetList();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = qldkmBUS.GetList();

            }
            else
            {
                if (rdoBtnMaDocGia.Checked == true)
                    gridControl1.DataSource = qldkmBUS.TimKiem(txtTimKiem.Text, "MaDocGia");
                else if (rdoBtnMaSach.Checked == true)
                    gridControl1.DataSource = qldkmBUS.TimKiem(txtTimKiem.Text, "MaSach");
                else if (rdoBtnTenDocGia.Checked == true)
                    gridControl1.DataSource = qldkmBUS.TimKiem(txtTimKiem.Text, "HoTen");
                else if (rdoBtnNgayMuon.Checked == true)
                    gridControl1.DataSource = qldkmBUS.TimKiem(txtTimKiem.Text, "NgayMuon");
            }
        }
    }
}
