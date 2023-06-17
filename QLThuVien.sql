
--drop database QLThuVien
create database QLThuVien
go
use QLThuVien
go

-----
--drop table DOCGIA
create table DOCGIA
(
	MaDocGia nchar(10),
	TenDangNhap nchar(30),
	HoTen nchar(30),
	GioiTinh nchar(5),
	NamSinh date,
	DiaChi nvarchar(100),
	PRIMARY KEY (MaDocGia),
)
--drop table SACH
create table SACH
(
	MaSach nchar(10),
	TenSach nchar(50),
	TacGia nchar(30),
	TheLoai nchar(30),
	NhaXuatBan nchar(50),
	GiaSach int,
	SoLuong int,
	TinhTrang nchar(10),
	PRIMARY KEY (MaSach),
)
--drop table PHIEUMUON
create table PHIEUMUON
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayMuon date,
	NgayPhaiTra date,
	PRIMARY KEY (MaPhieu),
)
--drop table PHIEUTRA
create table PHIEUTRA
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayTra date,
	PRIMARY KEY (MaPhieu),
)

create table ACCOUNT
(
	MaDocGia nchar(10) PRIMARY KEY,
	TenDangNhap nchar(30),
	MatKhau nchar(30),
	Quyen int,
)


alter table PHIEUMUON add
	constraint FK_PHIEUMUON_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUMUON_SACH foreign key (MaSach) references SACH (MaSach)

alter table PHIEUTRA add
	constraint FK_PHIEUTRA_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUTRA_SACH foreign key (MaSach) references SACH (MaSach)

ALTER TABLE dbo.DOCGIA ADD
	CONSTRAINT FK_DOCGIA_ACCOUNT FOREIGN KEY (MaDocGia) REFERENCES dbo.ACCOUNT(MaDocGia)



insert into ACCOUNT values ('DG001','nguyenbamanh', '123456', 1)
insert into ACCOUNT values ('DG002','chauthisuong', '123456', 1)
insert into ACCOUNT values ('DG003','phamhaingoc', '123456', 1)
insert into ACCOUNT values ('DG004','tranquangthang', '123456', 1)
insert into ACCOUNT values ('DG005','nguyenphong', '123456', 1)
insert into ACCOUNT values ('AD01','admin1', '111', 0)
insert into ACCOUNT values ('AD02','admin2', '222', 0)
----
insert into DOCGIA values ('DG001','nguyenbamanh',N'Nguyễn Bá Mạnh','Nam','2002-02-20',N'385 Trường Chinh, TP Tuy Hòa, Phú Yên')
insert into DOCGIA values ('DG002','chauthisuong',N'Châu Thị Sương','Nu','2003-03-22',N'961 Hậu Giang, P.11, Q.6, TPHCM')
insert into DOCGIA values ('DG003','phamhaingoc',N'Phạm Hải Ngọc','Nam','2002-07-14',N'83/5 Trương Đăng Qué, Gò Vấp, TP HCM')
insert into DOCGIA values ('DG004','tranquangthang',N'Trần Quang Thắng',N'Nam','2000-02-27',N'128b/ 13 Tân Hòa Đông, P.14, Q.6, TPHCM')
insert into DOCGIA values ('DG005','nguyenphong',N'Nguyễn Minh Phong',N'Nam','2004-07-7',N'6/12 Nguyễn Siêu, P.Bến Nghé, TPHCM')


----
insert into SACH values ('S001', N'Lập trình hướng đối tượng', N'Không biết', N'Lập trình', 'UCT2', 150000, 3, N'Còn')
insert into SACH values ('S002', N'Nhập môn lập trình', N'Không biết', N'Lập trình', 'UCT2', 1500000, 10, N'Còn')
insert into SACH values ('S003', N'Kỹ Thuật Lập Trình', N'Không biết', N'Lập trình', 'UCT2', 300000, 5, N'Còn')
insert into SACH values ('S004', N'Thiết Kế Phần Mềm', N'Không biết', N'Lập trình', 'UCT2', 250000, 0, N'Hết')
---
insert into PHIEUMUON values ('PM001','DG001','S001','2023-06-14', '2023-06-16')
insert into PHIEUMUON values ('PM002','DG004','S001','2023-05-23', '2023-06-1')
insert into PHIEUMUON values ('PM003','DG005','S003','2023-06-2', '2023-06-7')

---
insert into PHIEUTRA values ('PT001','DG001','S001','2023-06-16')
insert into PHIEUTRA values ('PT002','DG004','S001','2023-05-28')

---


select DOCGIA.HoTen from ACCOUNT, DOCGIA where ACCOUNT.MaDocGia = DOCGIA.MaDocGia