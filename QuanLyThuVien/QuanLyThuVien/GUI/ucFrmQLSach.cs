using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien
{
    public partial class ucFrmQLSach : UserControl
    {
        Sach_BUS sachBUS = new Sach_BUS();
        public ucFrmQLSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
            Sach _s = new Sach();
            //Random rdm = new Random();
            _s.MaSach = txtMaSach.Text;
            _s.TenSach = txtTenSach.Text;
            _s.TacGia = txtTacGia.Text;
            _s.TheLoai = txtTheLoai.Text;
            _s.NhaXuatBan = txtNXB.Text;           
            if (txtGiaSach.Text != "")
                _s.GiaSach = int.Parse(txtGiaSach.Text);
            _s.SoLuong = Convert.ToInt32(nb_SoLuong.Value);
            _s.TinhTrang = txtTinhTrang.Text;

            //kiem tra loi madocgia
            int check = sachBUS.Them(_s);
            if (check == 0)
                lb_MDG.Visible = true;
            else if (check == -1)
                lb_Trung.Visible = true;
            //load lai
            ucFrmQLSach_Load(sender, e);
            ResetGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                sachBUS.Xoa(txtMaSach.Text);
                ResetGridview();
                ucFrmQLSach_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
            Sach _s = new Sach();
            _s.MaSach = txtMaSach.Text;
            _s.TenSach = txtTenSach.Text;
            _s.TacGia = txtTacGia.Text;
            _s.TheLoai = txtTheLoai.Text;
            _s.NhaXuatBan = txtNXB.Text;            
            if (txtGiaSach.Text != "")
                _s.GiaSach = int.Parse(txtGiaSach.Text);
            _s.SoLuong = Convert.ToInt32(nb_SoLuong.Value);
            _s.TinhTrang = txtTinhTrang.Text;

            if (!sachBUS.Sua(_s))
                lb_MDG.Visible = true;
            ucFrmQLSach_Load(sender, e);
            ResetGridview();
        }
        private void ResetGridview()
        {
            txtMaSach.ResetText();
            txtTenSach.ResetText();
            txtTacGia.ResetText();
            txtTheLoai.ResetText();
            txtNXB.ResetText();
            txtGiaSach.ResetText();       
            nb_SoLuong.ResetText();
            txtTinhTrang.ResetText();
        }
        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaSach.Text = gridView1.GetRowCellValue(e.RowHandle, "MaSach").ToString();
            txtTenSach.Text = gridView1.GetRowCellValue(e.RowHandle, "TenSach").ToString();
            txtTacGia.Text = gridView1.GetRowCellValue(e.RowHandle, "TacGia").ToString();
            txtTheLoai.Text = gridView1.GetRowCellValue(e.RowHandle, "TheLoai").ToString();
            txtNXB.Text = gridView1.GetRowCellValue(e.RowHandle, "NhaXuatBan").ToString();
            txtGiaSach.Text = gridView1.GetRowCellValue(e.RowHandle, "GiaSach").ToString();           
            nb_SoLuong.Value = Int32.Parse(gridView1.GetRowCellValue(e.RowHandle, "SoLuong").ToString());
            txtTinhTrang.Text = gridView1.GetRowCellValue(e.RowHandle, "TinhTrang").ToString();
        }

        private void ucFrmQLSach_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = sachBUS.GetList();
        }

        private void txtTimSach_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimSach.Text == "")
            {
                gridControl1.DataSource = sachBUS.GetList();
            }
            else
                gridControl1.DataSource = sachBUS.TimKiem(txtTimSach.Text, "MaSach");
                
        }

     
    }
}
