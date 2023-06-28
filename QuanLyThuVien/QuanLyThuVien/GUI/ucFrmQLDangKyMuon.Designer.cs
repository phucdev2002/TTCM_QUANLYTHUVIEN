namespace QuanLyThuVien.GUI
{
    partial class ucFrmQLDangKyMuon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdoBtnNgayMuon = new System.Windows.Forms.RadioButton();
            this.rdoBtnMaSach = new System.Windows.Forms.RadioButton();
            this.rdoBtnMaDocGia = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rdoBtnTenDocGia = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 178);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 178);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(933, 279);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Độc Giả";
            this.gridColumn1.FieldName = "MaDocGia";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ Tên";
            this.gridColumn2.FieldName = "HoTen";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã Sách";
            this.gridColumn3.FieldName = "MaSach";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên Sách";
            this.gridColumn4.FieldName = "TenSach";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày Mượn";
            this.gridColumn5.FieldName = "NgayMuon";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ngày Phải Trả";
            this.gridColumn6.FieldName = "NgayPhaiTra";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdoBtnTenDocGia);
            this.groupControl1.Controls.Add(this.rdoBtnNgayMuon);
            this.groupControl1.Controls.Add(this.rdoBtnMaSach);
            this.groupControl1.Controls.Add(this.rdoBtnMaDocGia);
            this.groupControl1.Location = new System.Drawing.Point(312, 43);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(276, 124);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Tìm Kiếm Theo:";
            // 
            // rdoBtnNgayMuon
            // 
            this.rdoBtnNgayMuon.AutoSize = true;
            this.rdoBtnNgayMuon.Location = new System.Drawing.Point(149, 82);
            this.rdoBtnNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnNgayMuon.Name = "rdoBtnNgayMuon";
            this.rdoBtnNgayMuon.Size = new System.Drawing.Size(80, 17);
            this.rdoBtnNgayMuon.TabIndex = 9;
            this.rdoBtnNgayMuon.Text = "Ngày Mượn";
            this.rdoBtnNgayMuon.UseVisualStyleBackColor = true;
            // 
            // rdoBtnMaSach
            // 
            this.rdoBtnMaSach.AutoSize = true;
            this.rdoBtnMaSach.Location = new System.Drawing.Point(44, 82);
            this.rdoBtnMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnMaSach.Name = "rdoBtnMaSach";
            this.rdoBtnMaSach.Size = new System.Drawing.Size(65, 17);
            this.rdoBtnMaSach.TabIndex = 9;
            this.rdoBtnMaSach.Text = "Mã Sách";
            this.rdoBtnMaSach.UseVisualStyleBackColor = true;
            // 
            // rdoBtnMaDocGia
            // 
            this.rdoBtnMaDocGia.AutoSize = true;
            this.rdoBtnMaDocGia.Checked = true;
            this.rdoBtnMaDocGia.Location = new System.Drawing.Point(44, 48);
            this.rdoBtnMaDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnMaDocGia.Name = "rdoBtnMaDocGia";
            this.rdoBtnMaDocGia.Size = new System.Drawing.Size(79, 17);
            this.rdoBtnMaDocGia.TabIndex = 9;
            this.rdoBtnMaDocGia.TabStop = true;
            this.rdoBtnMaDocGia.Text = "Mã Độc Giả";
            this.rdoBtnMaDocGia.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.Search_icon1;
            this.btnTimKiem.Location = new System.Drawing.Point(592, 10);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(28, 22);
            this.btnTimKiem.TabIndex = 13;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(382, 12);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(206, 20);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(312, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Tìm Kiếm:";
            // 
            // rdoBtnTenDocGia
            // 
            this.rdoBtnTenDocGia.AutoSize = true;
            this.rdoBtnTenDocGia.Location = new System.Drawing.Point(149, 48);
            this.rdoBtnTenDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.rdoBtnTenDocGia.Name = "rdoBtnTenDocGia";
            this.rdoBtnTenDocGia.Size = new System.Drawing.Size(83, 17);
            this.rdoBtnTenDocGia.TabIndex = 10;
            this.rdoBtnTenDocGia.Text = "Tên Độc Giả";
            this.rdoBtnTenDocGia.UseVisualStyleBackColor = true;
            // 
            // ucFrmQLDangKyMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ucFrmQLDangKyMuon";
            this.Size = new System.Drawing.Size(933, 457);
            this.Load += new System.EventHandler(this.ucFrmQLDangKyMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdoBtnTenDocGia;
        private System.Windows.Forms.RadioButton rdoBtnNgayMuon;
        private System.Windows.Forms.RadioButton rdoBtnMaSach;
        private System.Windows.Forms.RadioButton rdoBtnMaDocGia;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
